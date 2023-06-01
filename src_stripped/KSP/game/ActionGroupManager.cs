// Decompiled with JetBrains decompiler
// Type: KSP.Game.ActionGroupManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Messages;
using KSP.OAB;
using KSP.Sim;
using KSP.Sim.impl;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class ActionGroupManager : KerbalMonoBehaviour
  {
    [Header("Self")]
    [SerializeField]
    private CanvasGroup _canvasGroup;
    [SerializeField]
    private RectTransform _window;
    [Header("Default window positions")]
    [SerializeField]
    private float _defaultXWindowOffsetFlight;
    [SerializeField]
    private float _defaultYWindowOffsetFlight;
    [SerializeField]
    private float _defaultXWindowOffsetVab;
    [SerializeField]
    private float _defaultYWindowOffsetVab;
    [SerializeField]
    [Header("Prefabs")]
    private ContextBindRoot _partListCategoryGroupPrefab;
    [SerializeField]
    private ContextBindRoot _partListPartGroupPrefab;
    [SerializeField]
    private ContextBindRoot _partListActionPrefab;
    [SerializeField]
    private ContextBindRoot _actionGroupPrefab;
    [SerializeField]
    private ContextBindRoot _selectedListCategoryGroupPrefab;
    [SerializeField]
    private ContextBindRoot _selectedListPartGroupPrefab;
    [SerializeField]
    private ContextBindRoot _selectedListActionPrefab;
    [Header("BindRoots")]
    [SerializeField]
    private ContextBindRoot _managerBindRoot;
    [SerializeField]
    private ContextBindRoot _parts;
    [SerializeField]
    private ContextBindRoot _actionGroups;
    [SerializeField]
    private ContextBindRoot _actionGroupDetails;
    private bool _isInitialized;
    private ContextListProperty<ActionGroupElement> _reservedActionGroupsList;
    private ContextListProperty<ActionGroupElement> _customActionGroupsList;
    private ContextListProperty<PartCategoryElement> _partCategoryList;
    private ContextListProperty<PartCategoryElement> _selectedGroupParts;
    private bool _isInOAB;
    private KSPActionGroup[] _actionGroupValues;
    private PropertyReadonly<bool> _isGroupDetailsShowing;
    private PropertyReadonly<KSPActionGroup> _selectedActionGroup;
    private PropertyReadonly<string> _selectedActionGroupName;
    private DictionaryValueList<PartCategories, PartCategoryElement> _partCategoryMapping;
    private HashSet<PartCategories> _usedCategories;
    private HashSet<IGGuid> _usedParts;
    private DictionaryValueList<KSPActionGroup, ActionGroupElement> _reservedMapping;
    private DictionaryValueList<KSPActionGroup, ActionGroupElement> _customMapping;
    private HashSet<KSPActionGroup> _usedReservedGroups;
    private HashSet<KSPActionGroup> _usedCustomGroups;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateLeft(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABLoaded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABUnloaded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselBehaviorInitialized(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselActionGroupsChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildFlightLists(VesselComponent vessel, bool skipActiveVesselCheck = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnOABRebuildEvent(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAssemblyActionGroupsChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildOABLists(IObjectAssembly assembly, bool skipActiveAssemblyCheck = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildAssemblyPartsLists() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildVesselPartsList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildPartsList(IEnumerable<object> partsList) => throw null;

    [ContextMenu("Rebind ActionGroups List")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildActionGroupLists() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ShowGroupDetails(string groupName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSelectedGroup(KSPActionGroup group) => throw null;

    [ContextMenu("Hide Group Details")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HideGroupDetails() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetPartHighlight(IGGuid partGuid) => throw null;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActionGroupManager() => throw null;
  }
}
