// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

namespace KSP.Sim.ResourceSystem
{
  public interface IResourceContainer : 
    IResourceContainerReadOnly,
    IReadOnlyCollection<ResourceDefinitionID>,
    IEnumerable<ResourceDefinitionID>,
    IEnumerable
  {
    bool AreDefinitionsFrozen { get; }

    bool OverrideContainedCapacity(
      ResourceDefinitionID resourceID,
      double capacityUnits,
      bool nonStageable,
      bool fillToCapacity = false);

    bool OverrideContainedData(
      ResourceDefinitionID resourceID,
      double capacityUnits,
      double storedUnits,
      bool nonStageable);

    bool OverrideContainedData(ContainedResourceData data);

    double FillResourceToCapacity(ResourceDefinitionID resourceID);

    void FillAllResourcesToCapacity();

    double DumpResource(ResourceDefinitionID resourceID);

    void DumpAllResources();

    double SetResourceStoredUnits(ResourceDefinitionID resourceID, double unitsToSet);

    double SetResourceFillRatio(ResourceDefinitionID resourceID, double percentOfCapacity);

    double AddResourceUnits(ResourceDefinitionID resourceID, double totalUnitsToAdd);

    double AddResourceUnits(
      ResourceDefinitionID resourceID,
      double unitsToAddPerSecond,
      double timeInSeconds);

    double RemoveResourceUnits(ResourceDefinitionID resourceID, double totalUnitsToRemove);

    double RemoveResourceUnits(
      ResourceDefinitionID resourceID,
      double unitsToRemovePerSecond,
      double timeInSeconds);

    double GetResourceStoredMass(ResourceDefinitionID resourceID);

    double GetStoredResourcesTotalMass();

    double GetStoredResourceThermalMass(ResourceDefinitionID resourceID);

    double GetStoredResourcesTotalThermalMass();
  }
}
