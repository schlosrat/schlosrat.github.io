// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_RCS
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using KSP.Sim.ResourceSystem;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_RCS : ModuleData
  {
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 1)]
    [KSPState]
    [LocalizedField("PartModules/RCS/Status")]
    public ModuleProperty<string> ThrustStatus;
    [LocalizedField("PartModules/RCS/IsEnabled")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 2)]
    [HideInInspector]
    public ModuleProperty<bool> isEnabled;
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 3)]
    [LocalizedField("PartModules/RCS/RCSThrust")]
    [SteppedRange(0.0f, 100f, 1f)]
    public ModuleProperty<float> thrustPercentage;
    [LocalizedField("PartModules/RCS/AdvancedSettings")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 4)]
    [HideInInspector]
    public ModuleProperty<bool> IsAdvancedSettingsShown;
    [LocalizedField("PartModules/RCS/Pitch")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 5)]
    [HideInInspector]
    public ModuleProperty<bool> enablePitch;
    [LocalizedField("PartModules/RCS/Yaw")]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 6)]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> enableYaw;
    [LocalizedField("PartModules/RCS/Roll")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 7)]
    [HideInInspector]
    public ModuleProperty<bool> enableRoll;
    [LocalizedField("PartModules/RCS/PortStarboard")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 8)]
    [HideInInspector]
    public ModuleProperty<bool> enableX;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/RCS/DorsalVentral")]
    [PAMDisplayControl(SortIndex = 9)]
    [HideInInspector]
    public ModuleProperty<bool> enableY;
    [LocalizedField("PartModules/RCS/ForeAft")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 10)]
    [HideInInspector]
    public ModuleProperty<bool> enableZ;
    [LocalizedField("PartModules/RCS/ForeByThrottle")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 11)]
    [HideInInspector]
    public ModuleProperty<bool> foreByThrottle;
    [HideInInspector]
    [LocalizedField("PartModules/RCS/AlwaysFullAction")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 12)]
    public ModuleProperty<bool> fullThrust;
    [KSPDefinition]
    public PropellantDefinition Propellant;
    [FormerlySerializedAs("thrusterPower")]
    [Tooltip("Maximum Thrust in kN this engine produces at 100% throttle.")]
    [KSPDefinition]
    public float maxThrust;
    [Tooltip("Can the engine be be activated when shielded from airstream? ie: inside a fairing?")]
    [KSPDefinition]
    public bool shieldedCanActivate;
    [Tooltip("A curve to determine loss or gain of thrust due to changes in atmosphere vs vacuum values are based on ISP to ATM Pressure")]
    [KSPDefinition]
    public FloatCurve atmosphereCurve;
    [KSPDefinition]
    [Tooltip("should we use a thrust curve (based on resource remaining) ?")]
    public bool useThrustCurve;
    [KSPDefinition]
    [Tooltip("The thrust curve to use if useThrustCurve is true.")]
    public FloatCurve thrustCurve;
    [Tooltip("Is this engine disabled when under water?")]
    [KSPDefinition]
    public bool disableUnderwater;
    [KSPDefinition]
    public float fullThrustMin;
    [KSPDefinition]
    public bool useLever;
    [HideInInspector]
    [JsonIgnore]
    public PropellantState PropellantState;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetThrustPercentage(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupMixtures(
      IGGuid guid,
      ResourceFlowRequestBroker resourceFlowRequestBroker,
      IResourceContainer[] resourceContainer)
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
    private List<OABPartData.PartInfoModuleSubEntry> GetMaxThrustStrings(
      OABPartData.OABSituationStats OABSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal List<OABPartData.PartInfoModuleSubEntry> GetIspStrings(
      OABPartData.OABSituationStats OABSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetPropellantStrings(
      OABPartData.OABSituationStats OABSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float OABGetMaxFuelFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float OABGetMinFuelFlow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float OABGetThrust(float oabAtmPressure, float thrustLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_RCS() => throw null;
  }
}
