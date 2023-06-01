// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_SolarPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_SolarPanel : ModuleData
  {
    [LocalizedField("PartModules/SolarPanel/StellarExposure")]
    [PAMDisplayControl(SortIndex = 5)]
    [KSPState]
    public ModuleProperty<string> StellarExposure;
    [LocalizedField("PartModules/SolarPanel/EnergyFlow")]
    [PAMDisplayControl(SortIndex = 6)]
    [KSPState]
    public ModuleProperty<float> EnergyFlow;
    public string SimBlockingBody;
    public double SimStarEnergyScale;
    [KSPDefinition]
    public float RaycastOffset;
    [KSPDefinition]
    public bool UseRaycastForTrackingDot;
    [KSPDefinition]
    public string RaycastTransformName;
    [KSPDefinition]
    public Vector3 PanelIncidenceDirection;
    [KSPDefinition]
    public PartModuleResourceSetting ResourceSettings;
    [KSPDefinition]
    public float EfficiencyMultiplier;
    public ResourceFlowRequestCommandConfig RequestConfig;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetEnergyFlowString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetResourceGeneratedStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetupResourceRequest(
      ResourceFlowRequestBroker resourceFlowRequestBroker)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_SolarPanel() => throw null;
  }
}
