// Decompiled with JetBrains decompiler
// Type: KSP.Map.MapUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using KSP.UI.Binding;
using KSP.Utilities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Map
{
  public class MapUI : KerbalMonoBehaviour
  {
    private const string MAIN_MISSION_PREFIX = "Main_";
    private const string SECONDARY_MISSION_PREFIX = "Secondary_";
    private const string SYNOPSIS_PREFIX = "Menu/TrackingStation/Synopsis/";
    private const string INITIAL_VALUE_UNKNOWN = "Unknown";
    public static Dictionary<IGGuid, MapUISelectableEntry> FavoritedMapUIItems;
    public static Dictionary<MapItemType, List<MapUISelectableEntry>> MapUIItemsByObjectType;
    public static Dictionary<IGGuid, MapUISelectableEntry> EntryLookup;
    [SerializeField]
    private RectTransform _nestedListRoot;
    [SerializeField]
    private RectTransform _celestialBodyContent;
    [SerializeField]
    private GameObject _scrollViewCelestialBody;
    [SerializeField]
    private RectTransform _objectTypeContent;
    [SerializeField]
    private GameObject _scrollViewObjectType;
    [SerializeField]
    private MapUISelectableEntry _mapUIParentTemplate;
    [SerializeField]
    private MapUISelectableEntry _mapUIStarSystemTemplate;
    [SerializeField]
    private List<MapUI.ObjectEntryMapItemType> _objectTypeEntryParents;
    [SerializeField]
    private ContextBindRoot _infoPanelBindRoot;
    [SerializeField]
    private ContextBindRoot _objectPickerBindRoot;
    [SerializeField]
    private ContextBindRoot _mapUIBaseBindRoot;
    [SerializeField]
    private GameObject _objectEntryName;
    [SerializeField]
    private GameObject _objectEntryInputName;
    [SerializeField]
    private CanvasGroup _infoPanelCanvasGroup;
    [SerializeField]
    private Image _noTargetCrosshair;
    [SerializeField]
    [Header("Search")]
    private InputFieldExtended _searchText;
    [SerializeField]
    [Header("Filter")]
    private TrackingStationSearchFilter _trackingStationSearchFilter;
    [SerializeField]
    private GameObject _celestialBodyObjectPickerViewport;
    [SerializeField]
    private GameObject _celestialBodyNoFavoritesSelectedObject;
    [SerializeField]
    private GameObject _objectTypeViewport;
    [SerializeField]
    private GameObject _objectTypeNoFavoritesSelectedObject;
    [SerializeField]
    [Header("Crew Section")]
    private InfoPanelCrewMember _crewMemberPrefab;
    [SerializeField]
    private RectTransform _crewMemberParentTrasform;
    [Header("Alerts Section")]
    [SerializeField]
    private NotificationUIAlert _alertPrefab;
    [SerializeField]
    private RectTransform _alertParentTrasform;
    private Dictionary<IGGuid, Transform> _parentTransforms;
    private Dictionary<IGGuid, MapUISelectableEntry> _cbParentToBeInstantiated;
    private Dictionary<IGGuid, MapUISelectableEntry> _vesselSelectableEntries;
    private Dictionary<MapUISelectableEntry, IGGuid> _vesselParentToBeInstantiated;
    private Dictionary<MapUISelectableEntry, IGGuid> _colonyParentToBeInstantiated;
    private MapUISelectableEntry _previous;
    private MapUISelectableEntry _focusedEntry;
    private List<MapUISelectableEntry> _mapUIItems;
    private List<MapUISelectableEntry> _objectEntriesToDisplay;
    private GameObject _filterOptionsModal;
    private SubscriptionHandle _handleSelectedChanged;
    private SubscriptionHandle _handleMapModeChanged;
    private SubscriptionHandle _handleSOIEnteredUpdate;
    private SubscriptionHandle _handleCameraOrbitTargetChange;
    private bool _initialized;
    private ObjectPickerSortType _objectPickerSortType;
    private Color _noTargetCrosshairColor;
    private CanvasGroup _noTargetCrosshairCanvasGroup;
    private bool _hasFavorites;
    public Action<List<TrackingStationObjectTypeFilter>> OnObjectTypeFilterUpdated;
    private GameObjectPool<InfoPanelCrewMember> _crewMemberPool;
    private List<InfoPanelCrewMember> _crewMembers;
    private List<InfoPanelCrewMember> _crewMembersExpired;
    private GameObjectPool<NotificationUIAlert> _alertsPool;
    private List<NotificationUIAlert> _alerts;
    private List<NotificationUIAlert> _alertsExpired;
    private DataContext uiData;
    private Property<MapItemType> _type;
    private Property<string> _name;
    private Property<string> _description;
    private Property<MapItem> _selected;
    private Property<bool> _isSelectionActive;
    private Property<bool> _isFavorited;
    private Property<bool> _isEditingObjectName;
    private Property<bool> _isResourceOverlayActive;
    private Property<bool> _isBiomeOverlayActive;
    private Property<bool> _isActionsAvailable;
    private Property<bool> _isOrbitalCharacteristicsAvailable;
    private Property<bool> _isCrewAvailable;
    private Property<bool> _isAlertAvailable;
    private Property<bool> _isSynopsisAvailable;
    private Property<bool> _isRecoveryAvailable;
    private Property<bool> _isDestroyAvailable;
    private Property<bool> _isFlightSituationAvailable;
    private PropertyExternal<string> _trajectoryTypeProp;
    private PropertyExternal<double> _velocityProp;
    private PropertyExternal<double> _altitudeProp;
    private PropertyExternal<double> _deltaVRemainingProp;
    private Property<double> _powerStored;
    private Property<double> _semiMajorAxis;
    private Property<double> _orbitalVelocity;
    private Property<double> _eccentricity;
    private Property<double> _siderealPeriod;
    private Property<double> _inclination;
    private Property<double> _axialTilt;
    private Property<double> _circumference;
    private Property<double> _radius;
    private Property<double> _rotationVelocity;
    private Property<double> _mass;
    private Property<double> _solarDay;
    private Property<double> _density;
    private Property<double> _maxSolarIntermittency;
    private Property<double> _gravity;
    private Property<double> _atmosphere;
    private Property<double> _solarIntensity;
    private Property<bool> _isOxygenPresent;
    private Property<double> _sphereOfInfluence;
    private Property<double> _temperatureRange;
    private Property<bool> _isWaterPresent;
    private Property<string> _geoThermalActivity;
    private Property<CharacteristicLevel> _windPotential;
    private Property<string> _synopsis;
    private Property<string> _location;
    private Property<double> _distFromKerbin;
    private Property<int> _populationMin;
    private Property<int> _populationMax;
    private Property<bool> _isIsru;
    private Property<bool> _isColonialVAB;
    private Property<int> _modulesActive;
    private Property<int> _modulesTotal;
    private Property<List<NotificationData>> _listOfAlerts;
    private Queue<MapItem> _mapItemLoadQueue;
    private bool _processingMapItems;
    private MapItem _initialFocus;

    public MapItem SelectedItem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MapUISelectableEntry CurrentSelectableEntry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MapUISelectableEntry CurrentFocusedEntry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public List<MapUISelectableEntry> MapItems
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Dictionary<IGGuid, MapUISelectableEntry> VesselItems
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsFavorited
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsSelectionActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ObjectPickerSortType ObjectPickerSortType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsProcessingMapItems
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Configure(List<MapItem> mapItem, MapItem focused) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetAltitude() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double GetDeltaVRemaining() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetTrajectoryType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ShouldInfoPanelRefreshData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshFavoritedMapUIItems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnObjectEntryTypeFilterUpdated(List<TrackingStationObjectTypeFilter> filters) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshObjectPicker(
      List<TrackingStationObjectTypeFilter> filters,
      bool isConfigureSelection)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshSortByObjectTypeWithFilters(List<TrackingStationObjectTypeFilter> filters) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshSortByCelestialBodiesWithFilters(
      List<TrackingStationObjectTypeFilter> filters)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<MapUISelectableEntry> ApplyObjectTypeFilter(
      List<TrackingStationObjectTypeFilter> filters)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetObjectEntriesVisibility(List<MapUISelectableEntry> objectEntriesToDisplay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSearch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SearchObjectEntries(string searchQuery) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ObjectEntrySearchPredicate(MapUISelectableEntry objectEntry, string searchQuery) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ObjectEntrySearchComplete(List<MapUISelectableEntry> matchingObjectEntries) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateObjectTypeParentsVisibilty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeGameObjectPools() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FocusOnSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVAB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGoToKSC() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Favorite() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroyTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRecoverTarget() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManageColony() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EditingObjectEntryName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisplayResourceOverlay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisplayBiomeOverlay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseInfoPanel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowNotImplementedYetDialogBox(string featureName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortByCelestialBodies() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortByObjectType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortByFavorites() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetObjectTypeViewVisible() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetActiveObjectTypesAndParentAssociatedMapUIEntries() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisplayFilterOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessMapItems(List<MapItem> mapItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMapItems(List<MapItem> mapItems) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveMapItem(MapItem mapItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessSingleMapItem(MapItem item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleColonyObjectEntryConfigurations(MapItem item, MapUISelectableEntry obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleVesselObjectEntryConfigurations(MapItem item, MapUISelectableEntry obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleDebrisObjectEntryConfigurations(MapItem item, MapUISelectableEntry obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCBObjectEntryConfiguration(MapItem item, MapUISelectableEntry obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AttachEarlySpawnedChildrenToParents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckForChildren() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeCrosshairAciveState(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapShutdown(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRequestSelectionChange(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMapModeChanged(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSOIEntered(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSelected(MapItem item, bool isConfigureSelection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCrosshairVisibility(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExpandAllParents(MapUISelectableEntry entry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureUIData(MapItem item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureColonyUIData(
      MapItem item,
      int NUM_DEFAULT,
      bool BOOL_DEFAULT,
      string STRING_DEFAULT)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureVesselUIData(MapItem item, int NUM_DEFAULT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsVesseOrbitalSubOrbitalOrEscaping(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsVesselLandedSplashedOrFlying(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureDebrisUIData(MapItem item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureCelestialBodyUIData(
      MapItem item,
      int NUM_DEFAULT,
      CharacteristicLevel CHARACTERISTIC_DEFAULT)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAlertSection(List<NotificationData> alerts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateAlert(NotificationData alertData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateCrewSectionInfoPanel(VesselComponent vessel = null, MapItem mapItem = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<NotificationData> DebugPopulateAlertSectionInfoPanel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearAllFilters() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static MapUI() => throw null;

    [Serializable]
    public struct ObjectEntryMapItemType
    {
      public MapItemType mapItemType;
      public GameObject objectEntry;
      public Transform accordionContentParent;
    }
  }
}
