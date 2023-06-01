// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceFlowRequestBroker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class ResourceFlowRequestBroker
  {
    private IFlowNode node;
    private ResourceFlowRequestManager _resourceFlowRequestManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowRequestBroker(ResourceFlowRequestManager requestManager, IFlowNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetNewResourceFlowRequestManager(
      ResourceFlowRequestManager resourceFlowRequestManager,
      IFlowNode node = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowRequestHandle AllocateOrGetRequest(
      string optionalUniqueIdentifier = null,
      ResourceFlowRequestHandle optionalrequestHandle = default (ResourceFlowRequestHandle))
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public static string SanitizeNameString(string resourceName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasRequest(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRequestActive(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRequestInactive(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetRequestActive(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetRequestInactive(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceRemoveRequest(ResourceFlowRequestHandle request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RequestHasCommands(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetCommands(
      ResourceFlowRequestHandle handle,
      double normalizedFlowMinimum,
      params ResourceFlowRequestCommandConfig[] commands)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetCommands(
      ResourceFlowRequestHandle handle,
      IEnumerable<ResourceFlowRequestCommandConfig> commands,
      double normalizedFlowMinimum)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetCommands(
      ResourceFlowRequestHandle handle,
      IEnumerable<ResourceFlowRequestCommandConfig> commands,
      double normalizedFlowMinimum,
      double flowPriorityOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UpdateCommands(
      ResourceFlowRequestHandle handle,
      double universalTime,
      double deltaTime)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RequestHasInstructions(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FlowRequestResolutionState GetRequestState(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCurrentResourceSnapshot(ResourceFlowRequestHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetRequestRequiredResourcesAvailable(
      ResourceFlowRequestHandle handle,
      ref List<ContainedResourceData> resourceList,
      FlowDirection flowDirection = FlowDirection.FLOW_OUTBOUND)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DictionaryValueList<ResourceFlowRequestManager.RequestPriorityContainerGroupKey, ResourceContainerGroup> TryGetRequestResourceContainerParts(
      ResourceFlowRequestHandle handle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetCurrentRequest(
      ResourceFlowRequestHandle handle,
      out ResourceFlowRequestManager.ManagedRequestWrapper wrapper)
    {
      throw null;
    }
  }
}
