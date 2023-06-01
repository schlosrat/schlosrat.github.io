// Decompiled with JetBrains decompiler
// Type: KSP.OAB.AssemblyPartsPicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.UI;
using KSP.UI.Binding;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace KSP.OAB
{
  public class AssemblyPartsPicker : KerbalMonoBehaviour
  {
    private List<AssemblyPartsButton> buttonsPreloading;
    private List<IObjectAssemblyAvailablePart> partsPreloading;
    private List<IObjectAssemblyAvailablePart> partsInNeedOfButtons;
    private readonly Queue<AssemblyPartsButton> _buttonsToLoad;
    private List<AssemblyPartsButton> buttonsLoading;
    private readonly Dictionary<string, Sprite> _loadedPartIcons;
    private const float INTERVAL_DELAY_TIME_SECONDS = 0.049999997f;
    protected ObjectAssemblyUIEvents _events;
    protected ObjectAssemblyBuilderEvents _builderEvents;
    protected OABSessionInformation _stats;
    [Header("General")]
    public RectTransform partsPickerView;
    public Transform buttonHoldingPen;
    public Toggle expandCollapseToggle;
    [Space]
    public RectTransform partContentRT;
    public RectTransform partsPickerBGPanelRT;
    public RectTransform manipulateShipToolbarRT;
    public RectTransform partsCategoriesToolbarRT;
    public RectTransform SearchFilterSortRT;
    public RectTransform viewCubeRT;
    [Space]
    public UITrashCanWidget trashCanWidget;
    public UIPartDropPreview partDropPreview;
    public ScrollRect partsPickerScrollRect;
    public RectTransform cursorMovableArea;
    [Header("General Buttons")]
    public AssemblyPartsButton partButtonSimplePrefab;
    [Header("Info Modal")]
    public RectTransform modalParent;
    public ObjectAssemblyFlexibleModal modalPrefab;
    private ObjectAssemblyFlexibleModal _modalInstance;
    [Header("Categories, Filters, Search, Favorites")]
    public PartCategories currentCategory;
    public AssemblyPartFilterType currentFilter;
    public List<ObjectAssemblyCategoryButton> categoryButtons;
    [Space]
    public AssemblyFilterContainer filterContainerSimplePrefab;
    public PartSizeColorBlock filterColors;
    public PartSizeColorBlock filterHighlightColors;
    [Space]
    public DropdownExtended sortingDropdown;
    public Toggle togglePartsFiltersButton;
    public List<PartCategorySortingType> partCategorySortingTypes;
    [Space]
    public TMP_InputField searchText;
    public Toggle toggleSearchButton;
    public Button clearSearchButton;
    [Space]
    public RectTransform emptyParts;
    private readonly OABPartSearchQueryRunner _partSearchQueryRunner;
    private readonly AssemblyPartsPicker.PartToButtonDictionary _partButtonMap;
    private readonly List<AssemblyFilterContainer> _partFilterContainers;
    private RectTransform _partsPickerRT;
    private List<IObjectAssemblyAvailablePart> _filteredPartsList;
    private List<string> _filterList;
    private AssemblyAlphanumericFilterType[] _alphaFilterEnums;
    private List<Coroutine> _updateButtonsOnFiltersCoroutines;
    private bool _waitingForVABReady;
    private Camera _curCamera;
    private Camera _uiCamera;
    private float _intervalDelayTimeRemaining;
    private ObjectAssemblyPartsPickerConfig _partsPickerConfig;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _oabPartsPickerContext;
    private Property<string> _emptyPartsText;
    private Property<bool> _isSortOrderAscending;
    private Property<bool> _isPartsPickerExtended;
    private ObjectAssemblySortingDropdownOptions _sortingDropdownData;
    private List<AssemblyPartsTechLevelFilter> _techLevelFilters;
    private List<AssemblyPartsCostFilter> _resourceCostFilters;
    private List<AssemblyPartsFuelTypeFilter> _fuelTypeFilters;
    private List<AssemblyPartTypeFilter> _vesselTypeFilters;
    private bool _pointerInPartPicker;

    [HideInInspector]
    public bool IsHoveredByCursor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnConfigDataLoaded(TextAsset data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Initialize(
      ObjectAssemblyUIEvents eventsToUse,
      ObjectAssemblyBuilderEvents builderEvents,
      OABSessionInformation statsToUse)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QueuePartsInNeedOfButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInterval() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnloadAllAssets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ReloadPartIcons(IObjectAssemblyAvailablePart availablePart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrioritizeButtonsToLoad(List<AssemblyPartsButton> buttonsToLoad) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartIconLoaded(AssemblyPartsButton dynbtn, Sprite sprite) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static IEnumerator FixVerticalLayoutGroup(VerticalLayoutGroup help) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AttemptToggleFavorite() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private T GetFirstRaycastResult<T>(List<RaycastResult> raycastResults) where T : Component => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TogglePartFavoriteByName(string nameOfPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUICamera(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCameraSet(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SignalVABReady() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private AssemblyPartsButton GetOrCreateButtonForPart(
      IObjectAssemblyAvailablePart part,
      bool createNewOneIfNotFound = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyPartsButton GetButtonForPart(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyPartsButton AddButtonForPartDuplicate(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion? GetSuggestedRotation(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplySuggestedRotation(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanSuggestRotation(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartPrefabLoaded(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAssemblyLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnRequestPartDeleteFX(IObjectAssemblyPart part, Vector3 loc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCategoryVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCategoryButtonClicked(PartCategories category) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCategory(PartCategories categoryToUse) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExpandCollapsePartsWindow(bool isExpanded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyCategoryButton GetCategoryButton(PartCategories partCategory) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshPartsPicker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSortOrderChanged(bool _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetVisiblePartButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateButtonsOnFilters(List<IObjectAssemblyAvailablePart> matchingParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator AddButtonsToFilter(
      List<IObjectAssemblyAvailablePart> subparts,
      AssemblyFilterContainer filter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<IObjectAssemblyAvailablePart> ApplyPartsFilter(
      List<IObjectAssemblyAvailablePart> inParts)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetVisiblePartButtonsSearch(string searchQuery) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool partSearchPredicate(IObjectAssemblyAvailablePart part, string searchQuery) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PartSearchComplete(List<IObjectAssemblyAvailablePart> matchingParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFilterButtons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetVisiblePartFilters(List<IObjectAssemblyAvailablePart> parts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CompareFilters(string lhs, string rhs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<string> GetFamiliesForPartsList(List<IObjectAssemblyAvailablePart> partsList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceRefreshUIGroups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPointerEnterPicker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPointerExitPicker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDropdownValueChanged(int newIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleSearch(bool toggled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TogglePartsFilterSearch(bool toggled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSearch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearSearchOutsidePicker() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearSearchBar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResizeFilterCount(int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<IObjectAssemblyAvailablePart> SortPartListByCategory(
      List<IObjectAssemblyAvailablePart> parts,
      PartCategories category)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<string> GetFuelTypeOrder(List<string> keys) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetSortingFuelType(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int PartComparison(
      IObjectAssemblyAvailablePart left,
      IObjectAssemblyAvailablePart right)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color GetFilterColorFromFilterEnum(int filterSubType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color GetFilterHighlightColorFromFilterEnum(int filterSubType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetAlphaIndexForPart(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PartBelongsInFilter(
      IObjectAssemblyAvailablePart part,
      AssemblyFilterContainer filter)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFilter(AssemblyPartFilterType filterToUse, bool reverseFilter = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNextFilter(bool reverseFilter = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTechLevelFilterUpdated(List<AssemblyPartsTechLevelFilter> filter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResourceCostsFilterUpdated(List<AssemblyPartsCostFilter> filter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFuelTypeFilterUpdated(List<AssemblyPartsFuelTypeFilter> filter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselTypeFilterUpdated(List<AssemblyPartTypeFilter> filter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetAssemblyFilterHeaderName(ref AssemblyFilterContainer filter, string label) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AssemblyPartsPicker() => throw null;

    public delegate Color GetFilterColorDelegate(int filter);

    private class PartToButtonDictionary : 
      BiDirectionalDictionary<IObjectAssemblyAvailablePart, AssemblyPartsButton>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public PartToButtonDictionary() => throw null;
    }

    private static class FilterUtils
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public static string GetSizeFullName(AssemblySizeFilterType filterSubType) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static string PartCategoryToLocKey(PartCategories category) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static string GetSizeAbbreviation(AssemblySizeFilterType filterSubType) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static AssemblyMassFilterType GetMassFilterType(float mass) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static string GetMassFilterTypeName(int index) => throw null;
    }
  }
}
