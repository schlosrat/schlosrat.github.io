// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceContainerGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim.impl;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class ResourceContainerGroup : 
    IResourceContainer,
    IResourceContainerReadOnly,
    IReadOnlyCollection<ResourceDefinitionID>,
    IEnumerable<ResourceDefinitionID>,
    IEnumerable
  {
    private List<ResourceContainer> _containers;

    public IReadOnlyCollection<ResourceContainer> Containers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ContainerCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerGroup(IEnumerable<ResourceContainer> containers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerGroup(params ResourceContainer[] containers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerGroup(ResourceContainerGroup containerGroup, bool deepCopy) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetContainers(IEnumerable<ResourceContainer> containers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetContainers(params ResourceContainer[] containers) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddContainer(ResourceContainer container) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClearContainers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasContainer(ResourceContainer container) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsResourceContained(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsResourceContained(PartComponent part, ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsResourceContained(IObjectAssemblyPart part, ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetResourcesContainedCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNonStageableResourcesContainedCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetAllResourcesContained(
      ref ICollection<ResourceDefinitionID> containedResources,
      bool clear = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetAllResourcesContained(
      ref ICollection<ResourceDefinitionID> containedResources,
      PartComponent part,
      bool clear = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceStoredMass(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStoredResourcesTotalMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStoredResourceThermalMass(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStoredResourcesTotalThermalMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourcePreProcessedUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceStoredUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceStoredUnits(PartComponent part, ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceStoredUnits(IObjectAssemblyPart part, ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNonStageableResourceStoredUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceCapacityUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceCapacityUnits(PartComponent part, ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceCapacityUnits(
      IObjectAssemblyPart part,
      ResourceDefinitionID resourceID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNonStageableResourceCapacityUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceEmptyUnits(ResourceDefinitionID resourceId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceEmptyUnits(ResourceDefinitionID resourceId, bool includePreProcessed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetResourceStoredAndCapacity(
      ResourceDefinitionID resourceID,
      out double unitsStored,
      out double unitsCapacity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetResourceContainedData(
      ResourceDefinitionID resourceID,
      out ContainedResourceData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetResourceContainedData(
      PartComponent part,
      ResourceDefinitionID resourceID,
      out ContainedResourceData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetResourceContainedData(
      IObjectAssemblyPart part,
      ResourceDefinitionID resourceID,
      out ContainedResourceData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetNonStageableResourceContainedData(
      ResourceDefinitionID resourceID,
      out ContainedResourceData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<ContainedResourceData> GetAllResourcesContainedData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<ContainedResourceData> GetAllResourcesContainedData(PartComponent part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceFillRatio(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContainedResourceData GetResourceContainedData(ResourceDefinitionID resourceID) => throw null;

    public bool AreDefinitionsFrozen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverrideContainedCapacity(
      ResourceDefinitionID resourceID,
      double capacityUnits,
      bool nonStageable,
      bool fillToCapacity = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverrideContainedData(
      ResourceDefinitionID resourceID,
      double capacityUnits,
      double storedUnits,
      bool nonStageable)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverrideContainedData(ContainedResourceData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double FillPreProcessedResourceToCapacity(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double FillResourceToCapacity(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FillAllResourcesToCapacity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double DumpPreProcessedResource(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double DumpResource(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DumpAllResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double SetResourceStoredUnits(ResourceDefinitionID resourceID, double unitsToSet) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double SetResourceFillRatio(ResourceDefinitionID resourceID, double percentOfCapacity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPreProcessedResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double ConsumePreProcessedResourceUnits(
      ResourceDefinitionID resourceID,
      double totalUnitsToConsume)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double AddResourceUnits(ResourceDefinitionID resourceID, double totalUnitsToAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double AddResourceUnits(
      ResourceDefinitionID resourceID,
      double unitsToAddPerSecond,
      double timeInSeconds)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double StorePreProcessedResourceUnits(
      ResourceDefinitionID resourceID,
      double totalUnitsToStore)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RemoveResourceUnits(ResourceDefinitionID resourceID, double totalUnitsToRemove) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RemoveResourceUnits(
      ResourceDefinitionID resourceID,
      double unitsToRemovePerSecond,
      double timeInSeconds)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator<ResourceDefinitionID> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
