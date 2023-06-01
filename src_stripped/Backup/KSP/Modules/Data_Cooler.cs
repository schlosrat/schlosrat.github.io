// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Cooler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Cooler : ModuleData
  {
    [KSPState]
    [HideInInspector]
    public CoolerStates currentCoolerState;
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [LocalizedField("PartModules/Cooler/Enabled")]
    public ModuleProperty<bool> coolerEnabled;
    [LocalizedField("PartModules/Cooler/Status")]
    [KSPState]
    [HideInInspector]
    public ModuleProperty<string> coolerStatusText;
    [HideInInspector]
    [KSPState]
    public bool isTransformInContact;
    [HideInInspector]
    [KSPState]
    public bool hasEnoughResources;
    [HideInInspector]
    [KSPState]
    public string[] resourceDiplayNames;
    [KSPDefinition]
    public double fluxRemoved;
    [KSPDefinition]
    public float emissiveLerpRateUp;
    [KSPDefinition]
    public float emissiveLerpRateDown;
    [KSPDefinition]
    public List<string> emissiveMaterialNames;
    [KSPDefinition]
    public string fxGroupName;
    [KSPDefinition]
    public string fxPrefab;
    [KSPDefinition]
    public List<PartModuleResourceSetting> requiredResources;
    public List<ResourceDefinitionID> InputResourcesIDs;
    public List<ResourceFlowRequestCommandConfig> RequestConfigs;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupResourceRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetHeatRemovedString(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetResourceStrings(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Cooler() => throw null;
  }
}
