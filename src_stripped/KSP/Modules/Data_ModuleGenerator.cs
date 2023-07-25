// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ModuleGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
  public sealed class Data_ModuleGenerator : ModuleData
  {
    [LocalizedField("PartModules/Generator/AlternatorOutput")]
    [PAMDisplayControl(SortIndex = 2)]
    [KSPState]
    public ModuleProperty<double> GeneratorOutput;
    [KSPState]
    [LocalizedField("PartModules/Generator/GeneratorHeat")]
    [PAMDisplayControl(SortIndex = 3)]
    public ModuleProperty<double> HeatGenerated;
    [LocalizedField("PartModules/ResourceConverter/Status")]
    [PAMDisplayControl(SortIndex = 1)]
    [KSPState]
    public ModuleProperty<string> DisplayStatus;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Generator/ToggleGenerator")]
    [PAMDisplayControl(SortIndex = 3)]
    public ModuleProperty<bool> GeneratorEnabled;
    [KSPState]
    [LocalizedField("PartModules/Generator/Lifetime")]
    [PAMDisplayControl(SortIndex = 4)]
    public ModuleProperty<string> DisplayLifetime;
    [Header("General Parameters")]
    [KSPState]
    public bool GeneratorIsActive;
    [KSPDefinition]
    [Tooltip("This should not be enabled at the same time as AutoShutdown")]
    public bool IsAlwaysActive;
    [KSPDefinition]
    public GeneratorStatus Status;
    [KSPDefinition]
    public PartModuleResourceSetting ResourceSetting;
    [Tooltip("Whether the output should be reduced with time")]
    [Header("Decay Controls")]
    [KSPDefinition]
    public bool UseDecay;
    [KSPDefinition]
    [Tooltip("How long the generator takes to decay completely, in seconds")]
    public double DecayTime;
    [KSPDefinition]
    [Tooltip("Curve that maps fractional lifetime to fractional output")]
    public FloatCurve DecayCurve;
    [KSPDefinition]
    [Tooltip("If true, the decay timer starts as soon as the part is spawned. If false, the decay timer starts when MET starts")]
    public bool StartDecayImmediately;
    [HideInInspector]
    [KSPState]
    public bool IsDecaying;
    [KSPState]
    [HideInInspector]
    public double CurrentDecayTime;
    [Header("Thermal Controls")]
    [KSPDefinition]
    [Tooltip("This should be 0 if IsAlwaysActive is enabled")]
    public double FluxGenerated;
    [KSPDefinition]
    [Tooltip("This should not be enabled at the same time as IsAlwaysActive")]
    public bool AutoShutdown;
    [KSPDefinition]
    public double AutoShutdownTemperature;
    [KSPDefinition]
    public double SafeOperationTemperature;
    [KSPDefinition]
    [Header("Emissive Controls")]
    public bool UseEmissive;
    [KSPDefinition]
    public bool UseEmissiveTemperature;
    [KSPDefinition]
    public List<string> EmissiveMaterialNames;
    [KSPDefinition]
    public FloatCurve EmissiveTemperatureCurve;
    [KSPDefinition]
    public float EmissiveLerpRateUp;
    [KSPDefinition]
    public float EmissiveLerpRateDown;
    public ResourceFlowRequestCommandConfig RequestConfig;

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
    private static string GetAlternatorOutputString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetHeatOutputString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetResourceString(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetLifetimeStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetHeatString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ModuleGenerator() => throw null;
  }
}
