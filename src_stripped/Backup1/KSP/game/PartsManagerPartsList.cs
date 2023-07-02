// Decompiled with JetBrains decompiler
// Type: KSP.Game.PartsManagerPartsList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Api.CoreTypes;
using KSP.Messages;
using KSP.OAB;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.Game
{
  public class PartsManagerPartsList : KerbalMonoBehaviour
  {
    private const string LOG_FILTER = "[Parts Manager] - ";
    [SerializeField]
    [Header("List References")]
    private RectTransform _categoryEntryParent;
    [SerializeField]
    private ScrollRect _partsListScroll;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    [Header("UI Prefabs")]
    [SerializeField]
    private PartsManagerCategory _partsManagerCategoryPrefab;
    [SerializeField]
    private PartsManagerPart _partsManagerPartPrefab;
    [SerializeField]
    [Space]
    private PartsManagerFloatPropertySlider _sliderFloatUIPrefab;
    [SerializeField]
    private PartsManagerIntPropertySlider _sliderIntUIPrefab;
    [SerializeField]
    private PartsManagerExecuteActionButton _executeActionUIPrefab;
    [SerializeField]
    private PartsManagerBoolPropertyToggle _toggleUIPrefab;
    [SerializeField]
    private PartsManagerPropertyReadOnlyFormatted _floatReadOnlyUIPrefab;
    [SerializeField]
    private PartsManagerEnumPropertyDropdown _dropdownEnumUIPrefab;
    [SerializeField]
    private PartsManagerStringPropertyDropdown _dropdownStringUIPrefab;
    [SerializeField]
    private PartsManagerVector2PropertySlider _sliderVector2UIPrefab;
    [SerializeField]
    private PartsManagerPropertyHeader _headerUIPrefab;
    [SerializeField]
    private PartsManagerPropertyFooter _footerUIPrefab;
    private GameObject _poolHolder;
    private GameObjectPool<PartsManagerCategory> _partsManagerCategoryPrefabPool;
    private GameObjectPool<PartsManagerPart> _partsManagerPartPrefabPool;
    private GameObjectPool<PartsManagerFloatPropertySlider> _sliderFloatUIPrefabPool;
    private GameObjectPool<PartsManagerIntPropertySlider> _sliderIntUIPrefabPool;
    private GameObjectPool<PartsManagerBoolPropertyToggle> _toggleUIPrefabPool;
    private GameObjectPool<PartsManagerPropertyReadOnlyFormatted> _floatReadOnlyPrefabPool;
    private GameObjectPool<PartsManagerExecuteActionButton> _buttonExecuteActionPrefabPool;
    private GameObjectPool<PartsManagerEnumPropertyDropdown> _dropdownEnumUIPrefabPool;
    private GameObjectPool<PartsManagerStringPropertyDropdown> _dropdownStringUIPrefabPool;
    private GameObjectPool<PartsManagerVector2PropertySlider> _sliderVector2UIPrefabPool;
    private GameObjectPool<PartsManagerPropertyHeader> _headerPrefabPool;
    private GameObjectPool<PartsManagerPropertyFooter> _footerPrefabPool;
    private bool _isInitialized;
    private bool _isDirty;
    private PartOwnerComponent _partOwner;
    private ObjectAssemblyBuilderEvents _oabEvents;
    private SubscriptionHandle _gameStateChangedHandle;
    private SubscriptionHandle _vesselChangedHandle;
    private SubscriptionHandle _vesselDestroyedHandle;
    private DataContext _dataContext;
    private Queue<PartComponent> _partLoadQueue;
    private PartsManagerCore _core;
    private bool isFavorite;
    private IGGuid _partOwnerGuid;
    private IObjectAssembly _currentAssembly;
    private readonly Dictionary<IGGuid, PartsManagerPart> _partUIMap;
    private readonly Dictionary<PartCategories, PartsManagerCategory> _allCategories;
    private readonly Dictionary<IGGuid, IInteractivePart> _allParts;
    private PartBehaviourModule _moduleDataSortPartBehaviour;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(PartsManagerCore core) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ConnectEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ModuleContextChanged(IDataContextReadonly moduleContextChanged) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPartOwnerId(IGGuid partOwnerGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAssembly(IObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SyncVisuals() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetInteractiveParts(Dictionary<IGGuid, IInteractivePart> allParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetModulesFromFlight(Dictionary<IGGuid, IInteractivePart> allParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetModulesFromAssemblyBuilder(Dictionary<IGGuid, IInteractivePart> allParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselDestroyed(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSimulationObjectRemoved(SimulationObjectModel simObjectModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreOnPartGrabbed(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABPartAdded(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABPartRemoved(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPostOnPartFinalized(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPartToFavorites(IInteractivePart addedPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddPart(IGGuid guid, IInteractivePart addedPart, bool forceRefresh = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemovePart(IGGuid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterOnChangedForModules(IInteractivePart interactivePart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpkeepModuleCategories() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveFromFavorite(IGGuid guid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddAllUIForPart(IInteractivePart interactivePart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddEntryToPart(
      PartsManagerPart part,
      PartsManagerEntry entry,
      IDataContextReadonly dataContext,
      int moduleSortIndex,
      int moduleDataSortIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterPartOwner(PartOwnerComponent partOwner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterPartOwner() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartComponentsAdded(List<PartComponent> partComps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartComponentsRemoved(List<PartComponent> partComps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterOAB(ObjectAssemblyBuilderEvents oabEvents) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterOAB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool NeedsRefresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Debug_Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearAllUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsValidGameState(GameState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void LogError(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ScrollToPart(IGGuid partGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CompareByModuleSortIndex(IPartModule x, IPartModule y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int CompareByModuleDataSortIndex(ModuleData x, ModuleData y) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ModuleDisplayName(PartBehaviourModule module) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ShowModuleHeader(PartBehaviourModule module) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ShowFooter(PartBehaviourModule module) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryGetModuleVisualsOverride(
      PartBehaviourModule module,
      out PartsManagerCore.SerializedPartModuleDisplayVisuals visuals)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartsManagerPartsList() => throw null;
  }
}
