// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelMotor
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
  public sealed class Data_WheelMotor : ModuleData
  {
    [KSPDefinition]
    [Tooltip("This is the wheel drive response. How fast the motor applies torque.")]
    public float driveResponse;
    [KSPDefinition]
    [Tooltip("The amount of EC consumed when the motor is at idle. Total drain is rate * (inputApplied + idleDrain).\nRate is the rate defined in the requiredResource construct.")]
    public double idleDrain;
    [Tooltip("Maximum speed the wheel can do.")]
    [KSPDefinition]
    public float wheelSpeedMax;
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Wheels/TractionControlMode")]
    [PAMDisplayControl(SortIndex = 6)]
    public ModuleProperty<bool> autoTorque;
    [LocalizedField("PartModules/Wheels/MotorState")]
    [PAMDisplayControl(SortIndex = 4)]
    [KSPState]
    public ModuleProperty<string> motorStateString;
    [PAMDisplayControl(SortIndex = 3)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Wheels/MotorEnabled")]
    public ModuleProperty<bool> motorEnabled;
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Wheels/MotorInverted")]
    [PAMDisplayControl(SortIndex = 5)]
    public ModuleProperty<bool> motorInverted;
    [SteppedRange(0.0f, 100f, 1f)]
    [PAMDisplayControl(SortIndex = 8)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/Wheels/MotorLimiter")]
    public ModuleProperty<float> driveLimiter;
    [PAMDisplayControl(SortIndex = 7)]
    [LocalizedField("PartModules/Wheels/TractionControl")]
    [SteppedRange(0.0f, 5f, 0.1f)]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<float> tractionControlScale;
    [LocalizedField("PartModules/Wheels/DriveOutput")]
    [SteppedRange(0.0f, 100f, 1f)]
    [PAMDisplayControl(ExcludeFromContext = true)]
    [KSPState]
    public ModuleProperty<float> driveOutput;
    [Tooltip("The motor torque curve.\nThe X axis is the curent velocity, the Y axis is how much torque the motor will generate at the X velocity.")]
    [KSPDefinition]
    public FloatCurve torqueCurve;
    [KSPDefinition]
    [Tooltip("Whether the motor consumes resources.")]
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
    [HideInInspector]
    [KSPState]
    public double ResourceFractionOutput;
    [HideInInspector]
    [KSPState]
    public Data_WheelMotor.MotorState MotorDriveState;
    [HideInInspector]
    [KSPState]
    public bool MotorOperative;
    [KSPState]
    [HideInInspector]
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
