// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceFlowRequestManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.ResourceSystem
{
  public class ResourceFlowRequestManager
  {
    private static uint s_nextHandleID;
    private readonly ResourceDefinitionDatabase _database;
    private FlowGraph _flowGraph;
    private bool _infiniteFuelCheatEnabled;
    private bool _infiniteECCheatEnabled;
    private DictionaryValueList<ResourceFlowRequestManager.RequestContainerGroupKey, ResourceContainerGroupSequence> _RequestContainersGroups;
    private DictionaryValueList<ResourceFlowRequestHandle, ResourceFlowRequestManager.ManagedRequestWrapper> _requestWrappers;
    private readonly HashSet<ResourceFlowRequestHandle> _activeRequests;
    private readonly HashSet<ResourceFlowRequestHandle> _inactiveRequests;
    private readonly DictionaryValueList<IFlowNode, ResourceFlowPriorityQuerySolver> _solvers;
    private readonly List<ResourceFlowRequestManager.ManagedRequestWrapper> _orderedRequests;
    private static readonly Comparison<ResourceFlowRequestManager.ManagedRequestWrapper> s_requestWrapperComparison;
    private Coroutine _updateOABRoutine;
    private List<ResourceDefinitionID> _requestedResources;
    private List<ResourceDefinitionID> _failedResources;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(ResourceFlowRequestManager destination, IFlowNode node = null) => throw null;

    public event Action RequestsUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowRequestManager(
      ResourceDefinitionDatabase resourceDefinitionDatabase,
      FlowGraph flowGraph)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasRequest(ResourceFlowRequestHandle request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetRequest(
      ResourceFlowRequestHandle request,
      out ResourceFlowRequestManager.ManagedRequestWrapper wrapper)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRequestActive(ResourceFlowRequestHandle request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRequestInactive(ResourceFlowRequestHandle request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetRequestActive(ResourceFlowRequestHandle request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetRequestInactive(ResourceFlowRequestHandle request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceRemoveRequest(ResourceFlowRequestHandle request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RequestHasCommands(ResourceFlowRequestHandle request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetCommands(
      ResourceFlowRequestHandle request,
      double normalizedFlowMinimum,
      double flowPriorityOffset = 0.0,
      params ResourceFlowRequestCommandConfig[] commands)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetCommands(
      ResourceFlowRequestHandle request,
      IEnumerable<ResourceFlowRequestCommandConfig> commands,
      double normalizedFlowMinimum,
      double flowPriorityOffset = 0.0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UpdateCommands(
      ResourceFlowRequestHandle request,
      double universalTime,
      double deltaTime)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RequestHasInstructions(ResourceFlowRequestHandle request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetInstructions(
      ResourceFlowRequestHandle request,
      params FlowInstructionConfig[] instructions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetInstructions(
      ResourceFlowRequestHandle request,
      IEnumerable<FlowInstructionConfig> instructions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool UpdateInstructions(
      ResourceFlowRequestHandle request,
      double universalTime,
      double deltaTime)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkAllResourceSolversDirty(PartOwnerComponent partOwner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkAllResourceSolversDirty(ObjectAssembly assembly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator UpdateFlowRequestsOAB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFlowRequests(double tickUniversalTime, double tickDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ResourceFlowPriorityQuerySolver GetSetSolver(FlowInstructionConfig instruction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetInfinitePropellant() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetInfiniteElectricity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessActiveRequests(
      List<ResourceFlowRequestManager.ManagedRequestWrapper> orderedRequests,
      double tickUniversalTime,
      double tickDeltaTime)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateRequestContainerGroup(FlowInstructionConfig instruction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowRequestManager.ManagedRequestWrapper AllocateOrGetRequestWrapper(
      IFlowNode node,
      string uniqueIdentifier)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CompareRequestPriority(
      ResourceFlowRequestManager.ManagedRequestWrapper x,
      ResourceFlowRequestManager.ManagedRequestWrapper y)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ResourceFlowRequestManager.ManagedRequestWrapper AllocateRequest(
      ResourceFlowRequestHandle handle,
      IFlowNode node,
      string uniqueIdentifier)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetRequestWrapperInternal(
      ResourceFlowRequestHandle handle,
      out ResourceFlowRequestManager.ManagedRequestWrapper wrapper)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ResourceFlowRequestHandle CreateNextRequestHandle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlowRequestResolutionState GetRequestState(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetRequestRequiredResourcesAvailable(
      ResourceFlowRequestHandle handle,
      ref List<ContainedResourceData> resourceList,
      FlowDirection flowDirection = FlowDirection.FLOW_OUTBOUND)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DictionaryValueList<ResourceFlowRequestManager.RequestPriorityContainerGroupKey, ResourceContainerGroup> GetRequestResourceContainerParts(
      ResourceFlowRequestHandle handle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetRequestsByResource(
      string resourceName,
      FlowDirection direction,
      out List<ResourceFlowRequestManager.ManagedRequestWrapper> requests)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ResourceFlowRequestManager() => throw null;

    private readonly struct RequestContainerGroupKey
    {
      public readonly IFlowNode FlowTarget;
      public readonly ResourceDefinitionID FlowResource;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public RequestContainerGroupKey(IFlowNode flowTarget, ResourceDefinitionID flowResource) => throw null;
    }

    public readonly struct RequestPriorityContainerGroupKey
    {
      public readonly IFlowNode Node;
      public readonly double Priority;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public RequestPriorityContainerGroupKey(IFlowNode node, double priority) => throw null;
    }

    public class ManagedRequestWrapper
    {
      public ResourceFlowRequestHandle requestHandle;
      public IFlowNode requestTarget;
      public string uniqueIdentifier;
      public double flowPriorityOffset;
      public readonly List<ResourceFlowRequestCommandConfig> commands;
      public readonly List<FlowInstructionConfig> instructions;
      public FlowRequestResolutionState RequestResolutionState;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ManagedRequestWrapper(
        ResourceFlowRequestHandle requestHandle,
        IFlowNode requestTarget,
        string uniqueIdentifier = "")
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void UpdateStateDeliveryRejected(
        double tickUniversalTime,
        double tickDeltaTime,
        List<ResourceDefinitionID> failedResources)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void UpdateStateDeliveryAccepted(
        double tickUniversalTime,
        double tickDeltaTime,
        double normalizedDelivery)
      {
        throw null;
      }
    }
  }
}
