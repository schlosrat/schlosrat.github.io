// Decompiled with JetBrains decompiler
// Type: KSP.Game.TripPlanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Messages;
using KSP.Sim.DeltaV;
using KSP.UI;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  [RequireComponent(typeof (RectTransform))]
  [RequireComponent(typeof (CanvasGroup))]
  public class TripPlanner : PopUpUIManagerBase
  {
    [SerializeField]
    [Header("Self")]
    private ContextBindRoot tripPlannerBindRoot;
    [SerializeField]
    private RectTransform _rectTransform;
    [SerializeField]
    private CanvasGroup _canvasGroup;
    [SerializeField]
    private DropdownExtended _destinationDropdown;
    [SerializeField]
    private RectTransform _destinationDV;
    [Header("Default window position")]
    [SerializeField]
    private float _defaultXWindowOffset;
    [SerializeField]
    private float _defaultYWindowOffset;
    [SerializeField]
    [Header("Forecast Messaging")]
    [Space(10f)]
    private string[] withinRangeForecasts;
    [SerializeField]
    private string[] outsideRangeForecasts;
    [SerializeField]
    private Color withinRangeBackgroundColour;
    [SerializeField]
    private Color outsideRangeBackgroundColour;
    [SerializeField]
    private Color noSelectionBrackgroundColour;
    [Header("Prefab To Inject")]
    public string tripItemPrefabKey;
    public ContextBindRoot tripItemPrefab;
    [HideInInspector]
    private PropertyReadonly<ContextBindRoot> TripItemPrefab;
    private bool _isInitialized;
    private int _currentDestiationIndex;
    private int _currentOriginIndex;
    private double _destinationCost;
    private string _forecastMessage;
    private string _forecastMessageUnlocalized;
    [SerializeField]
    private double _targetUT;
    private bool _destinationWithinRange;
    private bool _foreCastMessageUpdatedOnce;
    private SubscriptionHandle _onDeltavValueChanged;
    private SubscriptionHandle _OABNewAssemblyHandle;
    private SubscriptionHandle _TripPlanerOriginOrDestinationChangedyHandle;
    private SubscriptionHandle _OnTimeWapCompleted;
    private List<string> _celestialBodiesNames;
    private List<TripEdge> _tripPath;
    [HideInInspector]
    public string TargetCelestialBodyName;
    private DataContext _uiData;
    private Property<double> _vesselDeltavValue;
    private Property<bool> _oneWayTrip;
    private Property<bool> _roundTrip;
    private Property<string> _originDisplayNameValue;
    private Property<string> _forecastMessageValue;
    private Property<Color> _forecastColorValue;
    private Property<bool> _destinationVisible;
    private Property<string> _destinationName;
    private Property<int> _destinationDVValue;
    private Property<bool> _timeWarpLaunchBtnInteractive;
    private Property<double> _displayTargetUT;

    public ContextListProperty<TripPlanner.TripEdgeDataContext> TripEdgeData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BindContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OneWayTripSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RoundTripSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTimeWarpCompleted(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool GetVisibleStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void SetVisibilityOfManager(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateDiscoveredDestinations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetOriginName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDisplayVesselDeltaV(VesselDeltaVComponent vesselDeltaVComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetAssemblyOABDeltaV(VesselDeltaVComponent vesselDeltaVComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABNewAssemblyMessage(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeltavValueChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateForecast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValueChangedOriginDropDown(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTripDataContext(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearResults() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NoDestinationSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TimeWarpToTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateTimeWarpLaunchbuttonInteractivity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TripPlanner() => throw null;

    public class TripEdgeDataContext : DataContext
    {
      private const string TRIPPLANNER_LOC_SLUG = "VAB/TripPlanner/";
      private string _destinationName;
      public Property<string> LocalizedDestination;
      public Property<double> DeltaVTotalCost;
      public Property<double> DeltaVCost;
      public Property<double> InclinationCost;
      public Property<bool> AerobrakePossible;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TripEdgeDataContext(
        string destinationName,
        double deltaVTotalCost,
        double deltaVCost,
        double inclinationCost,
        bool aerobrakePossible)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void LocalizeDestination() => throw null;
    }
  }
}
