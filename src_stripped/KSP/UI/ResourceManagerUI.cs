// Decompiled with JetBrains decompiler
// Type: KSP.UI.ResourceManagerUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.Messages;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using KSP.UI.Binding;
using KSP.Utilities;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  public class ResourceManagerUI : KerbalMonoBehaviour
  {
    [Header("Self")]
    [SerializeField]
    private CanvasGroup _canvasGroup;
    [SerializeField]
    private RectTransform _window;
    [Header("Default window position")]
    [SerializeField]
    private float _defaultXWindowOffset;
    [SerializeField]
    private float _defaultYWindowOffset;
    [SerializeField]
    [Header("Prefabs")]
    private ContextBindRoot _familyEntryPrefab;
    [SerializeField]
    private ContextBindRoot _partEntryPrefab;
    [SerializeField]
    private ContextBindRoot _containerEntryPrefab;
    [SerializeField]
    [Header("BindRoots")]
    private ContextBindRoot _managerBindRoot;
    [SerializeField]
    private ContextBindRoot _partSectionBindRoot;
    [SerializeField]
    private ContextBindRoot _transferSectionBindRoot;
    [SerializeField]
    [Header("Parts Section")]
    private RectTransform _partFamiliesTransform;
    private VesselComponent _curVessel;
    private bool _isInitialized;
    private bool _isDirty;
    private GameObjectPool<ContextBindRoot> _familyEntryPrefabPool;
    private GameObjectPool<ContextBindRoot> _partEntryPrefabPool;
    private GameObjectPool<ContextBindRoot> _containerEntryPrefabPool;
    private ContextListProperty<ResourceManagerFamilyEntry> _partFamiliesList;
    private Dictionary<string, ResourceManagerFamilyEntry> _partFamilyMap;
    private ContextListProperty<ResourceManagerPartEntry> _transferPartsList;
    private PropertyReadonly<string> _transferStatusText;
    private PropertyReadonly<bool> _displayStatusText;
    private PropertyReadonly<bool> _isTransferActive;
    private const string SUBCONTEXT_PREFABS_KEY = "Prefabs";
    private const string ACTION_CLOSE_WINDOW_KEY = "CloseWindow";
    private const string ACTION_PART_HIGHLIGHT_KEY = "SetPartHighlight";
    private const string ACTION_MOVE_TO_TRANSFER_LIST_KEY = "MoveToTransferList";
    private const string ACTION_MOVE_TO_PARTS_LIST_KEY = "MoveToPartsList";
    private const string ACTION_START_TRANSFER_KEY = "StartResourceTransfer";
    private const string ACTION_STOP_TRANSFER_KEY = "StopResourceTransfer";
    private const string ACTION_CLEAR_FLOW_STATES_KEY = "ClearFlowStates";
    private const string PROPERTY_IS_TRANSFER_ACTIVE_KEY = "IsTransferActive";
    private const string PROPERTY_TRANSFER_STATUS_KEY = "TransferStatusText";
    private const string PROPERTY_DISPLAY_STATUS_KEY = "DisplayStatusText";
    private const string PROPERTY_FAMILY_ENTRY_PREFAB_KEY = "FamilyEntryPrefab";
    private const string PROPERTY_PART_ENTRY_PREFAB_KEY = "PartEntryPrefab";
    private const string PROPERTY_CONTAINER_ENTRY_PREFAB_KEY = "ContainerEntryPrefab";
    private const string LIST_PROPERTY_PART_FAMILIES_KEY = "PartFamiliesList";
    private const string LIST_PROPERTY_TRANSFER_PARTS_KEY = "TransferPartsList";
    private const string PROPERTY_FAMILY_ENTRY_POOL_KEY = "FamilyEntryPool";
    private const string PROPERTY_PART_ENTRY_POOL_KEY = "PartEntryPool";
    private const string PROPERTY_CONTAINER_ENTRY_POOL_KEY = "ContainerEntryPool";
    private const string TRANSFER_STATUS_COMPLETED = "Flight/ResourceManager/TransferCompleted";
    private const string TRANSFERSTATUS_INVALID = "Flight/ResourceManager/TransferInvalid";
    private DictionaryValueList<ResourceDefinitionID, ResourceManagerUI.ResourceContainersPerFlowState> _resourceFlowStateMapping;

    public bool IsVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CloseWindow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanShowResourceManager(GameState currState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCurrentVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SubscribeToVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnsubscribeFromVessel(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SubscribeToMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnsubscribeFromMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnActiveVesselStageActivation(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartsChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RebuildLists(VesselComponent vessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearFamiliesList(VesselComponent activeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearTransferPartsList(VesselComponent activeVessel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddResourceContainer(ResourceManagerContainerEntry containerEntry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveResourceContainer(
      ResourceManagerContainerEntry containerEntry,
      FlowState flowState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsResourceValidForFlowRequest(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFlowState(ResourceManagerContainerEntry containerEntry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetOtherResourceContainersToFlowState(
      ResourceDefinitionID resourceID,
      FlowState newFlowState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetPartHighlight(IGGuid partGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveToTransferList(IGGuid partGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveToPartsList(IGGuid partGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartResourceTransfer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StopResourceTransfer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearAllFlowStates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceManagerUI() => throw null;

    private class ResourceContainersPerFlowState
    {
      private List<ResourceManagerContainerEntry> _inContainers;
      private List<ResourceManagerContainerEntry> _outContainers;
      private List<ResourceManagerContainerEntry> _balanceContainers;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int GetFlowStateCount(FlowState flowState) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void AddResourceContainer(ResourceManagerContainerEntry containerEntry) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void RemoveResourceContainer(
        ResourceManagerContainerEntry containerEntry,
        FlowState flowState)
      {
        throw null;
      }

      public List<ResourceManagerContainerEntry> InContainers
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public List<ResourceManagerContainerEntry> OutContainers
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public List<ResourceManagerContainerEntry> BalanceContainers
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ResourceContainersPerFlowState(ResourceManagerContainerEntry containerEntry) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public double GetTotalInUnits() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public double GetTotalOutUnits() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public double GetTotalBalanceUnits() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SortInContainers() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SortOutContainers() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private int CompareInContainers(
        ResourceManagerContainerEntry lhs,
        ResourceManagerContainerEntry rhs)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private int CompareOutContainers(
        ResourceManagerContainerEntry lhs,
        ResourceManagerContainerEntry rhs)
      {
        throw null;
      }
    }
  }
}
