// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
