// Decompiled with JetBrains decompiler
// Type: KSP.Game.TripPlanner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
  public class TripPlanner : KerbalMonoBehaviour
  {
    [Header("Self")]
    [SerializeField]
    private ContextBindRoot tripPlannerBindRoot;
    [SerializeField]
    private RectTransform _rectTransform;
    [SerializeField]
    private CanvasGroup _canvasGroup;
    [SerializeField]
    private DropdownExtended _destinationDropdown;
    [SerializeField]
    private RectTransform _destinationDV;
    [SerializeField]
    [Header("Default window position")]
    private float _defaultXWindowOffset;
    [SerializeField]
    private float _defaultYWindowOffset;
    [Header("Forecast Messaging")]
    [Space(10f)]
    [SerializeField]
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
    [SerializeField]
    private double _targetUT;
    private bool _destinationWithinRange;
    private bool _foreCastMessageUpdatedOnce;
    private SubscriptionHandle _onDeltavValueChanged;
    private SubscriptionHandle _gameStateChangedHandle;
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
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BindContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OneWayTripSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RoundTripSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTimeWarpCompleted(MessageCenterMessage msg) => throw null;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

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
      public Property<string> LocalizedDestination;
      public Property<double> DeltaVTotalCost;
      public Property<double> DeltaVCost;
      public Property<double> InclinationCost;
      public Property<bool> AerobrakePossible;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TripEdgeDataContext(
        string localizedDestination,
        double deltaVTotalCost,
        double deltaVCost,
        double inclinationCost,
        bool aerobrakePossible)
      {
        throw null;
      }
    }
  }
}
