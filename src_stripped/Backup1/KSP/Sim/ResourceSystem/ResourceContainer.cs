// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Logging;
using KSP.Messages;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class ResourceContainer : 
    IResourceContainer,
    IResourceContainerReadOnly,
    IReadOnlyCollection<ResourceDefinitionID>,
    IEnumerable<ResourceDefinitionID>,
    IEnumerable,
    IEquatable<ResourceContainer>
  {
    private const LogFilter LOG_FILTER = LogFilter.Simulation;
    private readonly List<ResourceDefinitionID> _resourceIDMap;
    private readonly List<double> _capacityUnitsLookup;
    private readonly List<double> _storedUnitsLookup;
    private readonly List<double> _preprocessedUnitsLookup;
    private readonly List<bool> _nonStageableLookup;
    private bool _resourceDefsFrozen;
    private MessageCenter _messageCenter;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string LOG_PREFIX([CallerMemberName] string memberName = "") => throw null;

    public bool AreDefinitionsFrozen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainer(ResourceContainer container) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainer(ResourceContainer container, bool freezeDefinitions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainer(
      IEnumerable<ContainedResourceData> containedResource)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainer(params ContainedResourceData[] containedResource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainer(
      ResourceDefinitionDatabase database,
      IEnumerable<ContainedResourceDefinition> containedResources)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainer(
      ResourceDefinitionDatabase database,
      params ContainedResourceDefinition[] containedResources)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceContainer(
      ResourceDefinitionDatabase database,
      bool freezeDefinitions,
      params ContainedResourceDefinition[] containedResources)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FreezeDefinitions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetContainedDefinition(
      ResourceDefinitionDatabase definitionDatabase,
      params ContainedResourceDefinition[] definition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetContainedDefinition(
      ResourceDefinitionDatabase definitionDatabase,
      IEnumerable<ContainedResourceDefinition> definitions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetContainedData(params ContainedResourceData[] fillData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetContainedData(IEnumerable<ContainedResourceData> fillData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearContainedDefinition() => throw null;

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
    public void GetAllNonStageableResourcesContained(
      ref ICollection<ResourceDefinitionID> containedResources,
      bool clear = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<ContainedResourceData> GetAllResourcesContainedData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<ContainedResourceData> GetAllNonStageableResourcesContainedData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContainedResourceData GetResourceContainedData(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContainedResourceData GetNonStageableResourceContainedData(
      ResourceDefinitionID resourceID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNonStageableResourceStoredUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourcePreProcessedUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceStoredUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetNonstageableResourceCapacityUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceCapacityUnits(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceEmptyUnits(ResourceDefinitionID resourceId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceEmptyUnits(ResourceDefinitionID resourceId, bool includePreProcessed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceFillRatio(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double FillResourceToCapacity(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double FillPreProcessedResourceToCapacity(ResourceDefinitionID resourceID) => throw null;

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
    public double StorePreProcessedResourceUnits(
      ResourceDefinitionID resourceID,
      double totalUnitsToStore)
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
    public double ConsumePreProcessedResourceUnits(
      ResourceDefinitionID resourceID,
      double totalUnitsToConsume)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RemoveResourceUnits(ResourceDefinitionID resourceID, double totalUnitsToRemove) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetPreProcessedResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RemoveResourceUnits(
      ResourceDefinitionID resourceID,
      double unitsToRemovePerSecond,
      double timeInSeconds)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceStoredMass(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceStoredMass(
      ResourceDefinitionDatabase database,
      ResourceDefinitionID resourceID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStoredResourceThermalMass(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetResourceUnitThermalMass(
      ResourceDefinitionDatabase database,
      ResourceDefinitionID resourceID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStoredResourcesTotalMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStoredResourcesTotalMass(ResourceDefinitionDatabase database) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStoredResourcesTotalThermalMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetStoredResourcesTotalThermalMass(ResourceDefinitionDatabase database) => throw null;

    int IReadOnlyCollection<ResourceDefinitionID>.Count
    {
      [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    public IEnumerator<ResourceDefinitionID> GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    IEnumerator IEnumerable.GetEnumerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private bool IsValidDataIndex(int dataIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private int GetDataIndexFromID(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void InternalEnsureDataIndexAllocations(int resourceDataIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private bool InternalValidateResourceID(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private bool InternalValidateAndModifyWithData(
      ResourceDefinitionID resourceID,
      double capacityUnits,
      bool modifyStored,
      bool nonStageable,
      double storedUnits = 0.0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private bool InternalValidateAndModifyWithData(
      IEnumerable<ContainedResourceData> fillData,
      bool clear = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalModifyData(
      ResourceDefinitionID resourceID,
      double capacityUnits,
      bool modifyStored,
      bool nonStageable,
      double storedUnits = 0.0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void InternalWriteCapacityAt(int dataIndex, double capacityUnits, bool nonStageable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void InternalWriteDataClampedAt(
      int dataIndex,
      double capacityUnits,
      double storedUnits,
      bool nonStageable)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void InternalWriteAtUnclamped(
      int dataIndex,
      double capacityUnits,
      double storedUnits,
      bool nonStageable)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private void InternalRemoveDataAt(int dataIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InternalPublishContainerChangedMessage(ResourceDefinitionID resourceID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int CreateFillDataFromDefinition(
      ContainedResourceDefinition definition,
      ResourceDefinitionDatabase database,
      ref List<ContainedResourceData> containerData,
      bool clearList = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<ContainedResourceData> CreateFillDataFromDefinition(
      ContainedResourceDefinition definition,
      ResourceDefinitionDatabase database)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<ContainedResourceData> CreateFillDataFromDefinition(
      IEnumerable<ContainedResourceDefinition> fillDefinitions,
      ResourceDefinitionDatabase database)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetHashCode(ResourceContainer obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Equals(ResourceContainer other) => throw null;
  }
}
