// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelMotor
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
  public sealed class Data_WheelMotor : ModuleData
  {
    [KSPDefinition]
    [Tooltip("This is the wheel drive response. How fast the motor applies torque.")]
    public float driveResponse;
    [KSPDefinition]
    [Tooltip("The amount of EC consumed when the motor is at idle. Total drain is rate * (inputApplied + idleDrain).\nRate is the rate defined in the requiredResource construct.")]
    public double idleDrain;
    [KSPDefinition]
    [Tooltip("Maximum speed the wheel can do.")]
    public float wheelSpeedMax;
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 6)]
    [LocalizedField("PartModules/Wheels/TractionControlMode")]
    public ModuleProperty<bool> autoTorque;
    [LocalizedField("PartModules/Wheels/MotorState")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 4)]
    public ModuleProperty<string> motorStateString;
    [LocalizedField("PartModules/Wheels/MotorEnabled")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 3)]
    public ModuleProperty<bool> motorEnabled;
    [LocalizedField("PartModules/Wheels/MotorInverted")]
    [PAMDisplayControl(SortIndex = 5)]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    public ModuleProperty<bool> motorInverted;
    [LocalizedField("PartModules/Wheels/MotorLimiter")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 8)]
    [SteppedRange(0.0f, 100f, 1f)]
    public ModuleProperty<float> driveLimiter;
    [SteppedRange(0.0f, 5f, 0.1f)]
    [LocalizedField("PartModules/Wheels/TractionControl")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 7)]
    public ModuleProperty<float> tractionControlScale;
    [LocalizedField("PartModules/Wheels/DriveOutput")]
    [KSPState]
    [PAMDisplayControl(ExcludeFromContext = true)]
    [SteppedRange(0.0f, 100f, 1f)]
    public ModuleProperty<float> driveOutput;
    [KSPDefinition]
    [Tooltip("The motor torque curve.\nThe X axis is the curent velocity, the Y axis is how much torque the motor will generate at the X velocity.")]
    public FloatCurve torqueCurve;
    [Tooltip("Whether the motor consumes resources.")]
    [KSPDefinition]
    public bool useResources;
    [Tooltip("Resource required to operate this module if the above property is true. ")]
    [KSPDefinition]
    public PartModuleResourceSetting requiredResource;
    [KSPState]
    public float MaxTorque;
    [HideInInspector]
    [KSPState]
    public bool MotorPhysXActive;
    [HideInInspector]
    [KSPState]
    public float DriveInput;
    [KSPState]
    [HideInInspector]
    public double ResourceFractionOutput;
    [KSPState]
    [HideInInspector]
    public Data_WheelMotor.MotorState MotorDriveState;
    [KSPState]
    [HideInInspector]
    public bool MotorOperative;
    [HideInInspector]
    [KSPState]
    public float MaxDriveTorque;
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
    public static string GetEnabledString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetAutoTorqueString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetInvertedString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDriveLimiterString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetTractionControlString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDriveOutputString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetSpeedStrings(OABPartData.OABSituationStats oabSituationStats) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<OABPartData.PartInfoModuleSubEntry> GetResourceStrings(
      OABPartData.OABSituationStats oabSituationStats)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelMotor() => throw null;

    public enum MotorState : byte
    {
      Inoperable,
      NotEnoughResources,
      Disabled,
      Idle,
      Running,
    }
  }
}
