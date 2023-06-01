// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Parachute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Parachute : ModuleData
  {
    public const string ANIM_PACKED_TO_SEMIDEPLOY_SPEED_STRING = "fPartialDeploySpeedMul";
    public const string ANIM_SEMIDEPLOY_TO_DEPLOY_SPEED_STRING = "fPartialToFullDeploySpeedMul";
    public const string ANIM_OSCILLATION_FREQ_STRING = "fTurbulenceSpeedMul";
    [KSPDefinition]
    public float autoCutSpeed;
    [KSPDefinition]
    public float rotationSpeedDPS;
    [KSPDefinition]
    [FormerlySerializedAs("canopyName")]
    public string canopyBoneName;
    [KSPDefinition]
    public string canopyMeshName;
    [KSPDefinition]
    public float deploymentSpeed;
    [KSPDefinition]
    public float semiDeploymentSpeed;
    [KSPDefinition]
    public float defaultDeployAltitude;
    [KSPDefinition]
    public float defaultMinAirPressureToOpen;
    [KSPDefinition]
    public bool invertCanopy;
    [KSPDefinition]
    public double chuteMaxTemp;
    [KSPDefinition]
    public double ChuteThermalMassPerArea;
    [KSPDefinition]
    public double startingTemp;
    [KSPDefinition]
    public double chuteEmissivity;
    [KSPDefinition]
    public double MachHeatBaseMultiplier;
    [KSPDefinition]
    public double MachHeatScalarMultiplier;
    [KSPDefinition]
    public double MachHeatPowExponent;
    [KSPDefinition]
    public double MachHeatDensityFadeoutMultiplier;
    [KSPDefinition]
    public double SecondsForRisky;
    [KSPDefinition]
    public double SafetyMultiplier;
    [FormerlySerializedAs("pressureShakeLayerIndex")]
    [KSPDefinition]
    public int pressureOscillationLayerIndex;
    [KSPDefinition]
    [FormerlySerializedAs("maximumPressureShakeVelocity")]
    public float oscillationAnimationVelocityThreshold;
    [KSPDefinition]
    public float oscillationAnimationFrequencyMultiplier;
    [KSPDefinition]
    public bool shieldedCanDeploy;
    [KSPDefinition]
    public double areaDeployed;
    [PAMDisplayControl(SortIndex = 1)]
    [HideInInspector]
    [KSPState]
    [LocalizedField("PartModules/Parachute/ChuteSafety")]
    public ModuleProperty<Data_Parachute.DeploymentSafeStates> deploymentSafetyState;
    [PAMDisplayControl(SortIndex = 9)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [SteppedRange(0.01f, 0.75f, 0.01f)]
    [LocalizedField("PartModules/Parachute/MinPressure")]
    public ModuleProperty<float> minAirPressureToOpen;
    [PAMDisplayControl(SortIndex = 10)]
    [LocalizedField("PartModules/Parachute/DeployAltitude")]
    [KSPState(CopyToSymmetrySet = true)]
    [SteppedRange(50f, 5000f, 50f)]
    public ModuleProperty<float> deployAltitude;
    [SteppedRange(0.0f, 10f, 1f)]
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 11)]
    [LocalizedField("PartModules/Parachute/SpreadAngle")]
    public ModuleProperty<float> spreadAngle;
    [PAMDisplayControl(SortIndex = 2)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [LocalizedField("PartModules/Parachute/ArmedToggle")]
    public ModuleProperty<bool> armedToggle;
    [KSPState]
    public ModuleProperty<Data_Parachute.DeploymentStates> deployState;
    [LocalizedField("PartModules/Parachute/DeployMode")]
    [PAMDisplayControl(SortIndex = 8)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public ModuleProperty<Data_Parachute.DeployMode> DeploymentMode;
    [LocalizedField("PartModules/Parachute/DeploySettings")]
    [PAMDisplayControl(SortIndex = 7)]
    [HideInInspector]
    public ModuleProperty<bool> IsDeploySettingsShown;
    [KSPState]
    public double chuteTemp;
    [KSPState]
    public float minimumSpeedToDeploy;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetDeployAltitudeString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetSpreadAngleString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetMinPressureString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetDeploymentSafetyString(object value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetDeploymentStateString(object value) => throw null;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Copy(ModuleData sourceModuleData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetSafeVelocity(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double MaxSafeVelocityAtLocalBody(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Parachute() => throw null;

    [Serializable]
    public enum DeploymentSafeStates : byte
    {
      [Description("PartModules/Parachute/DeploymentSafeStates/Safe")] SAFE,
      [Description("PartModules/Parachute/DeploymentSafeStates/Risky")] RISKY,
      [Description("PartModules/Parachute/DeploymentSafeStates/Unsafe")] UNSAFE,
      [Description("PartModules/Parachute/DeploymentSafeStates/None")] NONE,
    }

    [Serializable]
    public enum DeploymentStates : byte
    {
      [Description("PartModules/Parachute/DeploymentStates/Stowed")] STOWED,
      [Description("PartModules/Parachute/DeploymentStates/Armed")] ARMED,
      [Description("PartModules/Parachute/DeploymentStates/Semideployed")] SEMIDEPLOYED,
      [Description("PartModules/Parachute/DeploymentStates/Deployed")] DEPLOYED,
      [Description("PartModules/Parachute/DeploymentStates/Cut")] CUT,
    }

    [Serializable]
    public enum DeployMode : byte
    {
      [Description("PartModules/Parachute/DeployMode/Safe")] SAFE,
      [Description("PartModules/Parachute/DeployMode/Risky")] RISKY,
      [Description("PartModules/Parachute/DeployMode/Immediate")] IMMEDIATE,
    }
  }
}
