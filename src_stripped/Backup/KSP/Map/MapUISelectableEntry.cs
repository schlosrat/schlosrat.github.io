// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapUISelectableEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using KSP.UI.Binding;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Map
{
  public class MapUISelectableEntry : KerbalMonoBehaviour
  {
    private const string TIME_FORMAT_WITHOUT_YEARS = "{0}: {1}{2} {3}{4} {5}{6} {7}{8}";
    private const string TIME_FORMAT_WITH_YEARS = "{0}: {1}{2} | {3}{4} {5}{6} {7}{8} {9}{10}";
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [Space]
    [SerializeField]
    private ButtonExtended _entryButton;
    [SerializeField]
    private ToggleExtended _toggleExtended;
    [SerializeField]
    private Transform _accordionContentTransform;
    [Header("Configurable Items")]
    [SerializeField]
    private GameObject _favoriteIcon;
    [SerializeField]
    private GameObject _icons;
    [SerializeField]
    private bool _isObjectTypeCategory;
    [Header("Entry Details")]
    [SerializeField]
    private GameObject _details;
    [SerializeField]
    private GameObject _locationText;
    [SerializeField]
    private GameObject _metText;
    [Header("Action Buttons")]
    [SerializeField]
    private GameObject _vesselControl;
    [SerializeField]
    private GameObject _vesselRecover;
    [SerializeField]
    private GameObject _destroy;
    [SerializeField]
    private GameObject _evaKerbalControl;
    [SerializeField]
    private GameObject _evaKerbalRecover;
    [SerializeField]
    private GameObject _manageColony;
    [SerializeField]
    private GameObject _cancelRoute;
    [SerializeField]
    private GameObject _goToKSC;
    [SerializeField]
    private GameObject _focus;
    [SerializeField]
    [Header("Dotween Toggle Animations")]
    private DOTweenAnimation _openToggleAnimation;
    [SerializeField]
    private DOTweenAnimation _closeToggleAnimation;
    [Tooltip("Current selected entry")]
    public Property<bool> EntrySelected;
    [Tooltip("Number of children that are colonies")]
    public Property<int> ColoniesCount;
    [Tooltip("Number of Warnings/Notifications")]
    public Property<int> WarningsCount;
    [Tooltip("Number of children that are vessels")]
    public Property<int> VesselsCount;
    [Tooltip("Number of children that are celestial bodies")]
    public Property<int> CelestialBodiesCount;
    private DataContext _dataContext;
    private MapItem _item;
    private MapUI _mapUI;
    private VesselComponent _vesselComponent;
    private SimulationObjectModel _simObj;
    private MapUISelectableEntry _parentSelectableEntry;
    private float _lastMousePrimaryClickTime;
    private bool _isFavorited;
    private bool _hasChildren;
    private List<GameObject> _actionButtons;
    private string _locKey;
    private bool _isContextBindingInitialized;
    private string _objectSituation;
    private string _toCompleteLocalization;
    private string _metLocalization;
    private string _yearsUnitLocalization;
    private string _daysUnitLocalization;
    private string _hoursUnitLocalization;
    private string _minutesUnitLocalization;
    private string _secondsUnitLocalization;
    private SubscriptionHandle _vesselSituationChangedMessage;
    private Property<string> _itemName;
    private Property<string> _reports;
    private Property<string> _science;
    private Property<string> _location;
    private Property<string> _met;
    private Property<MapItemType> _type;
    private Property<NestingToggleType> _nestingToggleType;
    private Property<bool> _isExpanded;

    public MapItem Item
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<TrackingStationObjectTypeFilter> Filters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsFavorited
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MapItemType Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MapUISelectableEntry ParentSelectableEntry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Transform AccordionContentTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsToggleOn
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsObjectTypeCategory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsExpanded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    private bool IsIconsToggable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool IsLocationRequired
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool IsObjectSituationRequired
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool IsMETRequired
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool IsToCompleteRequired
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ObjectSituation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(
      MapItem item,
      MapUI mapUI,
      string bodyName,
      bool hasChildren,
      int celestialBodiesCount = 0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNestedToggleType(NestingToggleType nestingToggleType = NestingToggleType.None) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalizeEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAccordionVisibility(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupActionButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleRescueBeaconActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleMonumentActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleWaypointActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleManeuverNodeActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDebrisActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleAstronautActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleFlagActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDeliveryRouteActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCelestialBodyActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleColonyActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVesselActionButtonSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Favorite() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PopDestroyConfirmationDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Control() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Focus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PopRecoverConfirmationDialog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Recover() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GoToKSC() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVesselDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDebrisDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveItemReferences() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVesselControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleObserverCannotLeaveActiveVesselMessage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVesselRecovery() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OpenAccordion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseAccordion() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExpandCategoryHeader() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSelectClick() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SelectMapItem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FocusOnMapItem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QuitTutorial(bool reloadPriorState, Action onCompleteCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActionButtonVisibility(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsFilter(TrackingStationObjectTypeFilter filter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ConvertSecondsToMET(double time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckIfLocationAndSituationRequired() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void VesselSituationChangedMessage(MessageCenterMessage vesselSituationChangedMsg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string CheckSituation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LocalizeTimeUnits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapUISelectableEntry() => throw null;
  }
}
