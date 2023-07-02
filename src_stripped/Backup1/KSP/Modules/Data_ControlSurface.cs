// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ControlSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_ControlSurface : ModuleData
  {
    [LocalizedField("PartModules/LiftingSurface/LiftDragRatio")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 1)]
    [HideInInspector]
    public ModuleProperty<float> LiftDragRatioParent;
    [PAMDisplayControl(SortIndex = 2)]
    [FormerlySerializedAs("deploy")]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/ControlSurface/Deploy")]
    [Tooltip("Is the control surface in a deployed state")]
    public ModuleProperty<bool> Deploy;
    [Tooltip("Angle to which the control surface will deflect when deployed (acts as base angle for control deflection). In units of degrees.")]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/ControlSurface/DeployAngle")]
    [PAMDisplayControl(SortIndex = 3)]
    [FormerlySerializedAs("deployAngle")]
    [SteppedRange(-15f, 15f, 0.5f)]
    public ModuleProperty<float> DeployAngle;
    [PAMDisplayControl(SortIndex = 3)]
    [LocalizedField("PartModules/ControlSurface/Invert")]
    [KSPState(CopyToSymmetrySet = true)]
    [Tooltip("Angle to which the control surface will deflect when deployed (acts as base angle for control deflection). In units of degrees.")]
    public ModuleProperty<bool> InvertControl;
    [HideInInspector]
    [LocalizedField("PartModules/ControlSurface/AdvancedSettings")]
    [PAMDisplayControl(SortIndex = 5)]
    public ModuleProperty<bool> IsAdvancedSettingsShown;
    [LocalizedField("PartModules/ControlSurface/PitchEnabled")]
    [Header("Control Surface Behaviour")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 6)]
    [HideInInspector]
    [FormerlySerializedAs("enablePitch")]
    public ModuleProperty<bool> EnablePitch;
    [HideInInspector]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 7)]
    [LocalizedField("PartModules/ControlSurface/YawEnabled")]
    [FormerlySerializedAs("enableYaw")]
    public ModuleProperty<bool> EnableYaw;
    [LocalizedField("PartModules/ControlSurface/RollEnabled")]
    [FormerlySerializedAs("enableRoll")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 8)]
    [HideInInspector]
    public ModuleProperty<bool> EnableRoll;
    [SteppedRange(0.0f, 15f, 0.5f)]
    [FormerlySerializedAs("authorityLimiter")]
    [PAMDisplayControl(SortIndex = 9)]
    [KSPState(CopyToSymmetrySet = true)]
    [Tooltip("Adjusts how much the control surface will be allowed to deflect to respond to control inputs.  Limits set by the config.  In units of degrees.")]
    [LocalizedField("PartModules/ControlSurface/AuthorityLimiter")]
    public ModuleProperty<float> AuthorityLimiter;
    [LocalizedField("PartModules/LiftingSurface/Lift")]
    [PAMDisplayControl(SortIndex = 10)]
    [KSPState]
    [HideInInspector]
    public ModuleProperty<float> LiftScalarParent;
    [LocalizedField("PartModules/LiftingSurface/Drag")]
    [PAMDisplayControl(SortIndex = 11)]
    [KSPState]
    [HideInInspector]
    public ModuleProperty<float> DragScalarParent;
    [LocalizedField("PartModules/LiftingSurface/AOA")]
    [PAMDisplayControl(SortIndex = 12)]
    [HideInInspector]
    [KSPState]
    public ModuleProperty<float> AoAParent;
    [HideInInspector]
    [KSPState]
    [PAMDisplayControl(SortIndex = 13)]
    [LocalizedField("PartModules/ControlSurface/Lift")]
    public ModuleProperty<float> LiftScalar;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 14)]
    [LocalizedField("PartModules/ControlSurface/Drag")]
    [KSPState]
    public ModuleProperty<float> DragScalar;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 15)]
    [KSPState]
    [LocalizedField("PartModules/ControlSurface/AOA")]
    public ModuleProperty<float> AoA;
    [HideInInspector]
    [Header("Control Surface Setup")]
    [KSPState]
    public bool IsCtrlSurfaceActive;
    [KSPState]
    public bool AllowControl;
    [HideInInspector]
    [KSPState]
    public float LiftingCtrlSurfaceArea;
    [KSPState]
    [HideInInspector]
    public Vector3 CoPressureCtrlSurfaceOffset;
    [KSPState]
    [HideInInspector]
    public Vector3 CtrlSurfacePivotOffset;
    [KSPDefinition]
    [Tooltip("The Transform Direction that lift is provided in.\nThis is relative to the CtrlSurfacePivotTransformName Transform.")]
    public Data_LiftingSurface.TransformDir CtrlTransformDir;
    [KSPDefinition]
    [Tooltip("The Transform Axis that the control surface rotates around.\nThis is relative to the CtrlSurfacePivotTransformName Transform.")]
    public Data_LiftingSurface.TransformDir CtrlTransformRotAxis;
    [Tooltip("1 = Positive transformDir, -1 = Negative transformDir")]
    [KSPDefinition]
    public float CtrlTransformSign;
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [KSPDefinition]
    [Tooltip("The transform that will be adjusted to show the visual impact of the control surface motion.")]
    public string CtrlSurfacePivotTransformName;
    [KSPDefinition]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [Tooltip("Controls what axis the Lock functionality appears on.")]
    public string CtrlSurfacePivotDeployAxis;
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [Tooltip("Range (in degrees) the control surface can deflect.")]
    [KSPDefinition]
    public float CtrlSurfaceRange;
    [Tooltip("Minimum angle of ‘deployment’ that the control surface must be at to actuate. If the part is only deployed to this or less, it won’t tilt in response to control inputs.")]
    [KSPDefinition]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    public float CtrlSurfaceMinimumLockAngleForControl;
    [Tooltip("Area of the Control Surface that will move and generate force - wing area.\nIf this is a Procedural Wing then leave this blank as it will be dynamically generated.")]
    [KSPState]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    public float CtrlSurfaceArea;
    [KSPDefinition]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [Tooltip("Movement type for the ctrlsurface. false == use MoveTowards, true == use Lerp ")]
    public bool UseExponentialSpeed;
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [KSPDefinition]
    [Tooltip("How fast the control surface actuator will try to respond in Degrees/sec ")]
    public float ActuatorSpeedNormalScale;
    [Tooltip("Allow to have a minimum deploy angle instead of -CtrlSurfaceRange.")]
    [KSPState]
    public bool AllowMinimumDeplyAngle;
    [KSPDefinition]
    [Tooltip("If AllowMinimumDeplyAngle is true use this to set the minimum deploy angle.")]
    public float MinimumDeployAngle;
    [KSPState]
    [HideInInspector]
    public bool MirrorDeploy;
    [Tooltip("Multiple of Area of Mesh to get lift value.")]
    [KSPDefinition]
    public float MeshAreaLiftMultiplier;
    [KSPDefinition]
    public bool DisableLiftingSurfaceForce;
    [KSPDefinition]
    public bool ApplyLiftSurfaceForceAtBase;
    [KSPDefinition]
    public bool ApplyLiftSurfaceForceAtPivotMidpoint;
    [KSPDefinition]
    public KSPActionGroup DefaultActionGroup;
    internal bool IsPartInMirrorSymmetry;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetLiftKNValueString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDragKNValueString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetAngleString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetStaticAngleString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetLiftDragString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override void OnPartBehaviourModuleInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ControlSurface() => throw null;
  }
}
