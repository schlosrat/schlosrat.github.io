// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyFlexibleModal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

namespace KSP.OAB
{
  public class ObjectAssemblyFlexibleModal : KerbalMonoBehaviour
  {
    private const string MAX_THRUST_LOC_KEY = "Max Thrust";
    private const string ISP_LOC_KEY = "ISP";
    private const string SUB_INFO_SEPARATOR_LOC_PATH = "Menu/TrackingStation/Units/:";
    private const string TEXT_SPACER = " ";
    public float maxHeightPerPage;
    [Header("General Text")]
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI subtitleText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI manufacturerText;
    public TextMeshProUGUI sizeText;
    public TextMeshProUGUI toggleExpandText;
    [Space]
    public GameObject pagePrefab;
    public RectTransform pageParent;
    [Space]
    public RectTransform generalInfoParent;
    public GameObject generalInfoChild;
    [Space]
    public RectTransform secondaryInfoParent;
    public GameObject secondaryInfoChild;
    [Space]
    public GameObject moduleDataSegmentPrefab;
    public GameObject moduleSubSegmentPrefab;
    public GameObject moduleTextPrefab;
    [Space]
    public GameObject showMoreToggleSection;
    public GameObject controlIndicatorSection;
    public bool showControlIndicatorSection;
    public bool isCollapseOnHide;
    [Range(0.0f, 1f)]
    public float showMoreOpacityWhenUnavailable;
    [Space]
    public CanvasGroup _favoriteActive;
    public CanvasGroup _favoriteInactive;
    [Space]
    public KeyCode debugKeyShowAssetName;
    private bool debugShowAssetName;
    [Space]
    public bool isOffset;
    public float xOffset;
    public float yOffset;
    [Space]
    public bool staysVisibleBetweenParts;
    private bool _initialized;
    private bool _isShowingMoreInfo;
    private float _currentPageHeight;
    private GameObject _currentPageObject;
    private int _extraPageCount;
    private IObjectAssemblyAvailablePart _currentPart;
    private ObjectAssemblyUIEvents _eventsUI;
    private ObjectAssemblyBuilderEvents _eventsBuilder;
    private OABSessionInformation _stats;
    private AssemblyPartsPicker.GetFilterColorDelegate _colorFilter;
    private CanvasGroup _canvasGroup;
    private string _subInfoSeparator;
    private List<GameObject> _primaryLines;
    private List<GameObject> _secondaryLines;
    private List<GameObject> _moduleLines;
    private List<GameObject> _moduleSegments;
    private List<GameObject> _moduleSubSegments;
    private List<GameObject> _pages;
    private SubscriptionHandle _favoriteAddedHandle;
    private SubscriptionHandle _favoriteRemovedHandle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(
      ObjectAssemblyBuilderEvents eventsBuilder,
      ObjectAssemblyUIEvents eventsUI,
      OABSessionInformation stats,
      AssemblyPartsPicker.GetFilterColorDelegate filterDelegate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshFavorites(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureFavoriteInfo(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConfigureSizeInfo(IObjectAssemblyAvailablePart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShowModal(IObjectAssemblyAvailablePart partToShow, RectTransform rectTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHideModal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillSectionInfo(
      List<KeyValuePair<string, string>> info,
      GameObject infoChildPrefab,
      RectTransform sectionParent,
      List<GameObject> linesList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillLine(
      string key,
      string value,
      GameObject infoChildPrefab,
      RectTransform sectionParent,
      List<GameObject> linesList)
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
    private void BuildModuleSubSegment() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string TryToLocalizeToolTipString(string inputString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowAssetName(InputAction.CallbackContext obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideAssetName(InputAction.CallbackContext obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator HideDebugAssetName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalClearItems() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleLocalizedText(IObjectAssemblyAvailablePart partToShow) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulatePrimaryInfoText(IObjectAssemblyAvailablePart IOBAPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateOrderedDictionaryFromResources(
      List<KeyValuePair<string, string>> dict,
      IObjectAssemblyResource[] resourceArray,
      string unitName = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateEngineThrustAndISP(
      List<KeyValuePair<string, string>> dict,
      IObjectAssemblyAvailablePart IOABPart,
      OABPartData.OABSituationStats oABSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ConvertNumberToStringWithMaxDecimalLimit(float number) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ConvertNumberToStringWithMaxDecimalLimit(double number) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<KeyValuePair<string, string>> GetPriorityInfoFromPart(
      IObjectAssemblyAvailablePart IOBAPart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<KeyValuePair<string, string>> GetCoreInfoFromPart(
      IObjectAssemblyAvailablePart IOBAPart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<KeyValuePair<string, string>> GetResourceCostInfoFromPart(
      IObjectAssemblyAvailablePart IOBAPart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetTextHeight(TextMeshProUGUI TMProAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject MakeNewPage() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetModalPosition(RectTransform baseRect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShowModal(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowMoreInfo(bool showInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnModifier(bool isPressed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyFlexibleModal() => throw null;
  }
}
