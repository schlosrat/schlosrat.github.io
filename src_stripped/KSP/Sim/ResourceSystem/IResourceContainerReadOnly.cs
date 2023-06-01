// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IResourceContainerReadOnly
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;

namespace KSP.Sim.ResourceSystem
{
  public interface IResourceContainerReadOnly : 
    IReadOnlyCollection<ResourceDefinitionID>,
    IEnumerable<ResourceDefinitionID>,
    IEnumerable
  {
    bool IsResourceContained(ResourceDefinitionID resourceID);

    int GetResourcesContainedCount();

    ContainedResourceData GetResourceContainedData(ResourceDefinitionID resourceID);

    double GetResourceStoredUnits(ResourceDefinitionID resourceID);

    double GetResourcePreProcessedUnits(ResourceDefinitionID resourceID);

    double GetResourceCapacityUnits(ResourceDefinitionID resourceID);

    double GetResourceEmptyUnits(ResourceDefinitionID resourceId);

    double GetResourceFillRatio(ResourceDefinitionID resourceID);
  }
}
