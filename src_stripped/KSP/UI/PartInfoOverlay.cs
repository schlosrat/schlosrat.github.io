// Decompiled with JetBrains decompiler
// Type: KSP.UI.PartInfoOverlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Messages;
using KSP.OAB;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KSP.UI
{
  public class PartInfoOverlay : KerbalMonoBehaviour
  {
    private const string VIEW_LESS_KEY = ":View Less";
    private const string VIEW_MORE_KEY = ":View More";
    private const string SUB_INFO_SEPARATOR_LOC_PATH = "Menu/TrackingStation/Units/:";
    private const string TEXT_SPACER = " ";
    private const string MAX_THRUST_LOC_KEY = "Max Thrust";
    private const string ISP_LOC_KEY = "ISP";
    public float maxHeightPerPage;
    [Header("Pagination")]
    public GameObject pagePrefab;
    public RectTransform pageParent;
    [Header("Core info lines")]
    public RectTransform generalInfoParent;
    public GameObject generalInfoChild;
    [Header("Priority info lines")]
    public RectTransform secondaryInfoParent;
    public GameObject secondaryInfoChild;
    [Header("Module data")]
    public GameObject moduleDataSegmentPrefab;
    public GameObject moduleSubSegmentPrefab;
    public GameObject moduleTextPrefab;
    [Header("Show more")]
    public GameObject showMoreToggleSection;
    public bool showControlIndicatorSection;
    public bool isCollapseOnHide;
    public bool PopulateModules;
    [Space]
    public KeyCode debugKeyShowAssetName;
    private bool _debugShowAssetName;
    [Space]
    public bool isOffset;
    public float xOffset;
    public float yOffset;
    [Space]
    public bool staysVisibleBetweenParts;
    [Space]
    public PartSizeColorData partSizeColorData;
    private bool _initialized;
    private bool _isShowingMoreInfo;
    private float _currentPageHeight;
    private GameObject _currentPageObject;
    private IObjectAssemblyAvailablePart _currentPart;
    private ObjectAssemblyUIEvents _eventsUI;
    private ObjectAssemblyBuilderEvents _eventsBuilder;
    private OABSessionInformation _stats;
    private CanvasGroup _canvasGroup;
    private string _subInfoSeparator;
    private GameObjectPool<Transform> _generalInfoPool;
    private GameObjectPool<Transform> _secondaryInfoPool;
    private GameObjectPool<Transform> _moduleTextPool;
    private GameObjectPool<RectTransform> _moduleSubSegmentPool;
    private readonly List<Transform> _transformBuffer;
    private List<GameObject> _moduleSegments;
    private List<GameObject> _pages;
    private SubscriptionHandle _favoriteAddedHandle;
    private SubscriptionHandle _favoriteRemovedHandle;
    private ContextBindRoot _contextBindRoot;
    private PartInfoContext _overlayContext;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      ObjectAssemblyBuilderEvents eventsBuilder = null,
      ObjectAssemblyUIEvents eventsUI = null,
      OABSessionInformation stats = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContext() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshFavorites(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureFavoriteInfo(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnShowModal(IObjectAssemblyAvailablePart partToShow, RectTransform rectTransform = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnHideModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateFlavorTextFromPart(
      IObjectAssemblyAvailablePart partToShow,
      bool debugShowAssetName = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<KeyValuePair<string, string>> PopulateCoreInfoFromPart(
      IObjectAssemblyAvailablePart IOBAPart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<KeyValuePair<string, string>> PopulatePriorityInfoFromPart(
      IObjectAssemblyAvailablePart IOBAPart,
      string subInfoSeparator = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateResourceInfoFromPart(
      List<KeyValuePair<string, string>> dict,
      IObjectAssemblyResource[] resourceArray,
      string unitName = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateEngineThrustAndISP(
      List<KeyValuePair<string, string>> dictToPopulate,
      IObjectAssemblyAvailablePart IOABPart,
      OABPartData.OABSituationStats oABSituationStats,
      string subInfoSeparator = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillSectionInfo(
      List<KeyValuePair<string, string>> info,
      GameObjectPool<Transform> poolToSpawnFrom,
      RectTransform sectionParent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillLine(
      string key,
      string value,
      GameObjectPool<Transform> poolToSpawnFrom,
      RectTransform sectionParent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillModuleInfo(
      List<OABPartData.PartInfoModuleEntry> moduleEntries,
      RectTransform parentSegment)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillMultiModuleInfo(
      List<OABPartData.PartInfoModuleSubEntry> moduleSubEntries,
      RectTransform parentSegment)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildModuleSegment(
      string title,
      List<OABPartData.PartInfoModuleEntry> delegateEntries)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowAssetName(InputAction.CallbackContext obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideAssetName(InputAction.CallbackContext obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator HideDebugAssetName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalClearItems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ConvertNumberToStringWithMaxDecimalLimit(double number) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject MakeNewPage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetModalPosition(RectTransform baseRect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowModal(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowMoreInfo(bool showInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureSizeInfo(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string LocalizeVABTooltipString(string inputString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnExpand(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartInfoOverlay() => throw null;
  }
}
