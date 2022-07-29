using LiveSplit.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public class PacePlacementComponent : IComponent
    {
        protected InfoTextComponent InternalComponent { get; set; }
        public PacePlacementSettings Settings { get; set; }
        public LiveSplitState CurrentState { get; set; }

        public string ComponentName => "Pace Placement";
        public float HorizontalWidth => InternalComponent.HorizontalWidth;
        public float MinimumHeight => InternalComponent.MinimumHeight;
        public float VerticalHeight => InternalComponent.VerticalHeight;
        public float MinimumWidth => InternalComponent.MinimumWidth;
        public float PaddingTop => InternalComponent.PaddingTop;
        public float PaddingBottom => InternalComponent.PaddingBottom;
        public float PaddingLeft => InternalComponent.PaddingLeft;
        public float PaddingRight => InternalComponent.PaddingRight;
        public IDictionary<string, Action> ContextMenuControls => null;

        protected Dictionary<int, List<Time?>> RealTimePaceDictionary { get; set; }
        protected Dictionary<int, List<Time?>> GameTimePaceDictionary { get; set; }
        protected List<List<Time>> RealTimePaceList { get; set; }
        protected List<List<Time>> GameTimePaceList { get; set; }
        protected int CurrentPacePlacement { get; set; }
        protected bool PrevSplitSkipped { get; set; }
        protected bool PaceListValid { get; set; }
        protected bool CurrentSplitValid { get; set; }

        public PacePlacementComponent(LiveSplitState state)
        {
            Settings = new PacePlacementSettings();
            InternalComponent = new InfoTextComponent("Pace Placement", "...");

            state.OnStart += state_OnStart;
            state.OnSplit += state_OnSplitChange;
            state.OnSkipSplit += state_OnSplitChange;
            state.OnUndoSplit += state_OnSplitChange;
            state.OnReset += state_OnReset;
            CurrentState = state;

            PaceListValid = false;
            CurrentSplitValid = false;
        }

        public void Dispose()
        {
            CurrentState.OnStart -= state_OnStart;
            CurrentState.OnSplit -= state_OnSplitChange;
            CurrentState.OnSkipSplit -= state_OnSplitChange;
            CurrentState.OnUndoSplit -= state_OnSplitChange;
            CurrentState.OnReset -= state_OnReset;
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            InternalComponent.NameLabel.HasShadow
            = InternalComponent.ValueLabel.HasShadow
            = state.LayoutSettings.DropShadows;

            InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
            InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;

            InternalComponent.DrawHorizontal(g, state, height, clipRegion);
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            InternalComponent.DisplayTwoRows = Settings.Display2Rows;

            InternalComponent.NameLabel.HasShadow
                = InternalComponent.ValueLabel.HasShadow
                = state.LayoutSettings.DropShadows;

            InternalComponent.NameLabel.ForeColor = state.LayoutSettings.TextColor;
            InternalComponent.ValueLabel.ForeColor = state.LayoutSettings.TextColor;

            InternalComponent.DrawVertical(g, state, width, clipRegion);
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public Control GetSettingsControl(LayoutMode mode)
        {
            Settings.Mode = mode;
            return Settings;
        }

        public void SetSettings(XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
            if (!PaceListValid)
            {
                PaceListValid = true;
                RealTimePaceDictionary = CalculatePaceDictionary(state, TimingMethod.RealTime);
                GameTimePaceDictionary = CalculatePaceDictionary(state, TimingMethod.GameTime);
                RealTimePaceList = CalculatePaceList(state, TimingMethod.RealTime);
                GameTimePaceList = CalculatePaceList(state, TimingMethod.GameTime);
            }

            if (!CurrentSplitValid && state.CurrentPhase == TimerPhase.Running)
            {
                var paceList = CurrentState.CurrentTimingMethod == TimingMethod.GameTime ?
                                    GameTimePaceList : RealTimePaceList;
                CurrentSplitValid = true;
                CurrentPacePlacement = CalculateCurrentPlacement(state, CurrentState.CurrentTimingMethod);
                string totalCount = state.CurrentSplitIndex > 0 ?
                    (paceList[state.CurrentSplitIndex].Count() + 1).ToString() :
                    state.Run.AttemptCount.ToString();

                bool hidePlacement = PrevSplitSkipped && Settings.HidePlacementOnSkip;

                string display = hidePlacement ? "?" : ToOrdinal(CurrentPacePlacement);
                if (Settings.ShowAllPlaces)
                    display += " of " + totalCount;

                InternalComponent.InformationValue = display;
            }
            InternalComponent.Update(invalidator, state, width, height, mode);
        }

        void state_OnStart(object sender, EventArgs e)
        {
            PaceListValid = false;
            CurrentSplitValid = false;
        }

        void state_OnSplitChange(object sender, EventArgs e)
        {
            CurrentSplitValid = false;
        }

        void state_OnReset(object sender, TimerPhase e)
        {
            CurrentSplitValid = false;
            InternalComponent.InformationValue = "...";
        }

        Dictionary<int, List<Time?>> CalculatePaceDictionary(LiveSplitState state, TimingMethod timingMethod)
        {
            Dictionary<int, List<Time?>> paceDict = new Dictionary<int, List<Time?>>();
            for (int i = 0; i < state.Run.Count(); i++)
            {
                var history = state.Run[i].SegmentHistory;
                foreach (int index in history.Keys)
                {
                    if (index <= 0)
                        continue;

                    if (i == 0)
                        paceDict[index] = new List<Time?>();

                    if (!paceDict.ContainsKey(index) || paceDict[index].Count() < i)
                    {
                        paceDict.Remove(index);
                        continue;
                    }

                    bool nullValue = timingMethod == TimingMethod.RealTime ?
                        !history[index].RealTime.HasValue :
                        !history[index].GameTime.HasValue;

                    DebugDisplay("Failed Pacing: " + i + " " + index + " " + paceDict[index].Count()
                                + " " + nullValue);

                    if (nullValue)
                    {
                        paceDict[index].Add(null);
                        continue;
                    }

                    Time prevTime = Time.Zero;
                    if (i > 0)
                    {
                        DebugDisplay("Failed pt: " + i + " " + index + " " + paceDict[index][0]);

                        int x = 1;
                        while (!paceDict[index][i - x].HasValue && x < i)
                            x += 1;

                        if (paceDict[index][i - x].HasValue)
                            prevTime = paceDict[index][i - x].Value;
                    }

                    paceDict[index].Add(prevTime + history[index]);
                }
            }
            DebugDisplay("Done Pacing");

            return paceDict;
        }

        List<List<Time>> CalculatePaceList(LiveSplitState state, TimingMethod timingMethod)
        {
            List<List<Time>> paces = new List<List<Time>>();
            var paceDict = timingMethod == TimingMethod.GameTime ?
                GameTimePaceDictionary : RealTimePaceDictionary;

            for (int i = 0; i <= state.Run.Count(); i++)
            {
                var orderedList = new List<Time>();
                paces.Add(new List<Time>());
                if (i > 0)
                {
                    foreach (int index in paceDict.Keys)
                    {
                        if (paceDict[index].Count() < i)
                            continue;

                        DebugDisplay("Failed Listing: " + i + " " + index);

                        if (paceDict[index][i - 1].HasValue)
                            orderedList.Add(paceDict[index][i - 1].Value);
                    }
                }
                else
                    orderedList.Add(Time.Zero);

                if (timingMethod == TimingMethod.GameTime)
                    paces[i] = orderedList.OrderBy(x => x.GameTime.Value).ToList();
                else
                    paces[i] = orderedList.OrderBy(x => x.RealTime.Value).ToList();
            }
            DebugDisplay("Done ordering");

            return paces;
        }

        int CalculateCurrentPlacement(LiveSplitState state, TimingMethod timingMethod)
        {
            if (state.CurrentSplitIndex == 0)
            {
                PrevSplitSkipped = false;
                return 1;
            }

            int place = 1;
            var paceList = CurrentState.CurrentTimingMethod == TimingMethod.GameTime ?
                                    GameTimePaceList : RealTimePaceList;
            int x = 0;
            bool nullValue;
            do
            {
                x += 1;
                nullValue = timingMethod == TimingMethod.GameTime ?
                    state.Run[state.CurrentSplitIndex - x].SplitTime.GameTime == null :
                    state.Run[state.CurrentSplitIndex - x].SplitTime.RealTime == null;

            } while (nullValue && state.CurrentSplitIndex > x);

            PrevSplitSkipped = x > 1 || (x == 1 && nullValue);

            Time prevSplitTime = state.Run[state.CurrentSplitIndex - x].SplitTime;

            //pace list is off by one of split index
            List<Time> currentSplitPaces = paceList[state.CurrentSplitIndex - x + 1];
            DebugDisplay("Fastest Pace: " + currentSplitPaces[0]);

            for (int i = 0; i < currentSplitPaces.Count; i++)
            {
                var paceEquality = timingMethod == TimingMethod.GameTime ?
                    currentSplitPaces[i].GameTime - prevSplitTime.GameTime :
                    currentSplitPaces[i].RealTime - prevSplitTime.RealTime;

                if (paceEquality >= TimeSpan.Zero)
                    break;

                place += 1;
            }

            return place;
        }

        string ToOrdinal(int num)
        {
            int mod = num % 10;
            if (mod == 1)
            {
                if (num % 100 == 11)
                    return num.ToString() + "th";
                else
                    return num.ToString() + "st";
            }
            if (mod == 2)
            {
                if (num % 100 == 12)
                    return num.ToString() + "th";
                else
                    return num.ToString() + "nd";
            }
            if (mod == 3)
            {
                if (num % 100 == 13)
                    return num.ToString() + "th";
                else
                    return num.ToString() + "rd";
            }
            else
                return num.ToString() + "th";
        }

        void DebugDisplay(string debugText)
        {
            if (Settings.ShowDebugText)
                InternalComponent.InformationValue = debugText;
        }
    }
}