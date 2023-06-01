// Decompiled with JetBrains decompiler
// Type: KSP.UI.KerbalManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.OAB;
using KSP.Sim.impl;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class KerbalManager : KerbalMonoBehaviour
  {
    private const string VAB_PARTS_PICKER_LOC_PATH = "VAB/PartsPicker/";
    private const string KSC_ABBREVIATED_LOC_KEY = "Menu/KSC/KSC";
    private const string KSC_LOC_KEY = "Menu/KSC/Kerbal Space Center";
    private ContextBindRoot _contextBindRoot;
    private DataContext _context;
    private CanvasGroup _canvasGroup;
    private KerbalRosterManager _kerbalRosterManager;
    [Header("Behavior")]
    [SerializeField]
    private bool _populateLocationsOnOpen;
    [Header("Prefabs")]
    [SerializeField]
    private RectTransform _twoTierPanel;
    [SerializeField]
    private RectTransform _oneTierPanel;
    [SerializeField]
    private RectTransform _kerbalSlot;
    [Header("UI Elements")]
    [SerializeField]
    private RectTransform _window;
    [SerializeField]
    private ButtonExtended _closeButton;
    [SerializeField]
    private RectTransform _locationAPanelParent;
    [SerializeField]
    private RectTransform _locationBPanelParent;
    [SerializeField]
    private RectTransform _nullTextA;
    [SerializeField]
    private RectTransform _nullTextB;
    [SerializeField]
    private DropdownExtended _dropdownA;
    [SerializeField]
    private DropdownExtended _dropdownB;
    [SerializeField]
    private string _dropdownDefaultTextLoc;
    [SerializeField]
    private string _kerbalSlotPrefabKey;
    [SerializeField]
    [Header("Default window positions")]
    private float _defaultXWindowOffsetFlight;
    [SerializeField]
    private float _defaultYWindowOffsetFlight;
    [SerializeField]
    private float _defaultXWindowOffsetVab;
    [SerializeField]
    private float _defaultYWindowOffsetVab;
    [SerializeField]
    [Header("Drag/Drop")]
    private KerbalManagerHighlightDragDrop _highlightDragDrop;
    [SerializeField]
    private string _highlightDragDropKey;
    [SerializeField]
    private bool _useHighlightDragDrop;
    [SerializeField]
    private string _useHighlightDragDropKey;
    [SerializeField]
    private GameObject _dragDropDummyObject;
    [SerializeField]
    private string _dragDropDummyObjectKey;
    [SerializeField]
    private string _moveElementToListActionKey;
    private GameState _currentGameState;
    private List<KerbalManagerLocationInfo> _locationOptions;
    private int _locationAIndex;
    private int _locationBIndex;
    private Dictionary<IGGuid, KerbalManagerPanel> _locationAPanels;
    private Dictionary<IGGuid, KerbalManagerPanel> _locationBPanels;
    private KerbalManagerLocationInfo _locationA;
    private KerbalManagerLocationInfo _locationB;
    private GameObjectPool<RectTransform> _oneTierPanelPool;
    private GameObjectPool<RectTransform> _twoTierPanelPool;
    private GameObjectPool<RectTransform> _kerbalSlotPool;
    private Property<bool> _hasBothSides;
    private bool _isPerfomingMassTransfer;
    private KerbalManagerPanel _massTransferOrigin;
    private KerbalManagerPanel _massTransferTarget;
    private IGGuid? _currentSimObjectId;
    private VesselComponent _cachedVessel;
    private Dictionary<IGGuid, IObjectAssembly> _cachedAssemblies;
    private string dropdownLocalizationString;
    private TMP_Dropdown.OptionData _nullOption;
    private bool _isDirty;
    private bool _isLocationListDirty;
    private bool _isVisible;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShowWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnHideWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateLocations(bool populatingOnOpen = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<KerbalManagerLocationInfo> FindAllValidLocations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<TMP_Dropdown.OptionData> BuildDropdownOptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AutoPopulateLocationSelections(bool populatingOnOpen) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetLocationIndex(IGGuid lookupGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetLocationIndex(KerbalManagerLocationInfo lookupLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDropdownASelection(int optionIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDropdownBSelection(int optionIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearPreviousSelection(
      KerbalManagerLocationInfo previousLocation,
      Dictionary<IGGuid, KerbalManagerPanel> panelList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PopulateUIFromLocation(
      RectTransform panelParentRect,
      KerbalManagerLocationInfo location,
      Dictionary<IGGuid, KerbalManagerPanel> panelList,
      bool isRightSide = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private RectTransform GenerateKerbalPanel(
      RectTransform parentRect,
      GameObjectPool<RectTransform> panelPool,
      IGGuid simObjectId,
      List<KerbalInfo> kerbals,
      int kerbalCapacity = -1,
      string panelName = "",
      string panelType = "",
      bool isRightSide = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReloadLocations() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CompareKerbalPositions(KerbalInfo kerbalA, KerbalInfo kerbalB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillKerbals(IGGuid panelId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EmptyKerbals(IGGuid panelId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TransferKerbal(int index, IGGuid panelID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveKerbalToIndex(
      string fromPanelId,
      int fromIndex,
      string toPanelId,
      int toIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<IGGuid, KerbalManagerPanel> GetLocationContainingPanel(
      IGGuid panelID,
      out KerbalManagerPanel foundPanel,
      out Dictionary<IGGuid, KerbalManagerPanel> otherLocation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveAllPanelKerbals(
      List<KerbalManagerPanel> fromPanels,
      List<KerbalManagerPanel> toPanels)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryTransferKerbal(
      KerbalInfo kerbal,
      KerbalManagerPanel fromPanel,
      KerbalManagerPanel toPanel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryAssignKerbal(KerbalInfo kerbal, KerbalManagerPanel panel, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDirtyingEvent(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocationListDirtyingEvent(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDeleteAssembly(IObjectAssembly deletedAssembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbalLocationChanged(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalManager() => throw null;
  }
}
