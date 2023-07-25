﻿// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ResourceIntake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.ResourceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_ResourceIntake : ModuleData
  {
    [LocalizedField("PartModules/ResourceIntake/IntakeEnabled")]
    [PAMDisplayControl(SortIndex = 2)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public ModuleProperty<bool> toggleResourceIntake;
    [LocalizedField("PartModules/ResourceIntake/Flow")]
    [PAMDisplayControl(SortIndex = 3)]
    [KSPState]
    [HideInInspector]
    public ModuleProperty<float> flowRate;
    [HideInInspector]
    [KSPState]
    [PAMDisplayControl(SortIndex = 1)]
    [LocalizedField("PartModules/ResourceIntake/Status")]
    public ModuleProperty<string> statusTxt;
    [KSPDefinition]
    public string resourceName;
    [KSPDefinition]
    public double acceptanceThreshold;
    [KSPDefinition]
    public bool checkForOxygen;
    [KSPDefinition]
    public float area;
    [KSPDefinition]
    public double intakeSpeed;
    [KSPDefinition]
    public string intakeTransformName;
    [KSPDefinition]
    public FloatCurve machCurve;
    [KSPDefinition]
    public string occludeNode;
    [KSPDefinition]
    public double unitScalar;
    [KSPDefinition]
    public double kPaThreshold;
    [KSPDefinition]
    public bool underwaterOnly;
    [KSPDefinition]
    public bool disableUnderwater;
    [JsonIgnore]
    public ResourceDefinitionID IntakeResourceID;
    [JsonIgnore]
    public ResourceDefinitionData ResourceDefinitionData;
    [JsonIgnore]
    public ResourceFlowRequestCommandConfig RequestConfig;
    [JsonIgnore]
    public double ResourceUnits;
    [JsonIgnore]
    public bool ModuleEnabled;

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
    private string GetResourceString(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetEfficiencyStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private OABPartData.PartInfoModuleSubEntry GetMachEntry(int mach) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetAreaString(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ResourceIntake() => throw null;
  }
}
