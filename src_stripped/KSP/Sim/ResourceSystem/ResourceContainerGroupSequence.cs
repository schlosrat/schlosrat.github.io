// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceContainerGroupSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class ResourceContainerGroupSequence : 
    IResourceContainer,
    IResourceContainerReadOnly,
    IReadOnlyCollection<ResourceDefinitionID>,
    IEnumerable<ResourceDefinitionID>,
    IEnumerable
  {
    private List<ResourceContainerGroup> _groupsInSequence;

    public IReadOnlyList<ResourceContainerGroup> GroupsInSequence
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int GroupCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool AreDefinitionsFrozen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerGroupSequence() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerGroupSequence(
      IEnumerable<ResourceContainerGroup> groupsInSequence)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainerGroupSequence(params ResourceContainerGroup[] groupsInSequence) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGroups(IEnumerable<ResourceContainerGroup> groups) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGroups(params ResourceContainerGroup[] groups) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearGroups() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(ResourceContainerGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPreProcessedResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsResourceContained(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetResourcesContainedCount() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetAllResourcesContained(
      ref ICollection<ResourceDefinitionID> containedResources,
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
    public double GetResourceStoredUnits(ResourceDefinitionID resourceID, bool includePreProcessed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourcePreProcessedUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceStoredUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceCapacityUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceEmptyUnits(ResourceDefinitionID resourceId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetResourceContainedData(
      ResourceDefinitionID resourceID,
      out ContainedResourceData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<ContainedResourceData> GetAllResourcesContainedData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceFillRatio(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContainedResourceData GetResourceContainedData(ResourceDefinitionID resourceID) => throw null;

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
    public double FillResourceToCapacity(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FillAllResourcesToCapacity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double DumpResource(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DumpAllResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double SetResourceStoredUnits(ResourceDefinitionID resourceID, double unitsToSet) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double SetResourceFillRatio(ResourceDefinitionID resourceID, double percentOfCapacity) => throw null;

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
    private bool GetResourceStoredAndCapacity(
      ResourceDefinitionID resourceID,
      out double unitsStored,
      out double unitsCapacity)
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
