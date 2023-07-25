// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ControlSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 1)]
    [KSPState]
    [LocalizedField("PartModules/LiftingSurface/LiftDragRatio")]
    public ModuleProperty<float> LiftDragRatioParent;
    [LocalizedField("PartModules/ControlSurface/Deploy")]
    [KSPState(CopyToSymmetrySet = true)]
    [Tooltip("Is the control surface in a deployed state")]
    [PAMDisplayControl(SortIndex = 2)]
    [FormerlySerializedAs("deploy")]
    public ModuleProperty<bool> Deploy;
    [LocalizedField("PartModules/ControlSurface/DeployAngle")]
    [FormerlySerializedAs("deployAngle")]
    [SteppedRange(-15f, 15f, 0.5f)]
    [KSPState(CopyToSymmetrySet = true)]
    [Tooltip("Angle to which the control surface will deflect when deployed (acts as base angle for control deflection). In units of degrees.")]
    [PAMDisplayControl(SortIndex = 3)]
    public ModuleProperty<float> DeployAngle;
    [PAMDisplayControl(SortIndex = 3)]
    [LocalizedField("PartModules/ControlSurface/Invert")]
    [Tooltip("Angle to which the control surface will deflect when deployed (acts as base angle for control deflection). In units of degrees.")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> InvertControl;
    [PAMDisplayControl(SortIndex = 5)]
    [HideInInspector]
    [LocalizedField("PartModules/ControlSurface/AdvancedSettings")]
    public ModuleProperty<bool> IsAdvancedSettingsShown;
    [Header("Control Surface Behaviour")]
    [LocalizedField("PartModules/ControlSurface/PitchEnabled")]
    [FormerlySerializedAs("enablePitch")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 6)]
    [HideInInspector]
    public ModuleProperty<bool> EnablePitch;
    [FormerlySerializedAs("enableYaw")]
    [LocalizedField("PartModules/ControlSurface/YawEnabled")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 7)]
    [HideInInspector]
    public ModuleProperty<bool> EnableYaw;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 8)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/ControlSurface/RollEnabled")]
    [FormerlySerializedAs("enableRoll")]
    public ModuleProperty<bool> EnableRoll;
    [SteppedRange(0.0f, 15f, 0.5f)]
    [Tooltip("Adjusts how much the control surface will be allowed to deflect to respond to control inputs.  Limits set by the config.  In units of degrees.")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 9)]
    [FormerlySerializedAs("authorityLimiter")]
    [LocalizedField("PartModules/ControlSurface/AuthorityLimiter")]
    public ModuleProperty<float> AuthorityLimiter;
    [LocalizedField("PartModules/LiftingSurface/Lift")]
    [PAMDisplayControl(SortIndex = 10)]
    [HideInInspector]
    [KSPState]
    public ModuleProperty<float> LiftScalarParent;
    [HideInInspector]
    [KSPState]
    [PAMDisplayControl(SortIndex = 11)]
    [LocalizedField("PartModules/LiftingSurface/Drag")]
    public ModuleProperty<float> DragScalarParent;
    [PAMDisplayControl(SortIndex = 12)]
    [LocalizedField("PartModules/LiftingSurface/AOA")]
    [HideInInspector]
    [KSPState]
    public ModuleProperty<float> AoAParent;
    [PAMDisplayControl(SortIndex = 13)]
    [HideInInspector]
    [LocalizedField("PartModules/ControlSurface/Lift")]
    [KSPState]
    public ModuleProperty<float> LiftScalar;
    [LocalizedField("PartModules/ControlSurface/Drag")]
    [PAMDisplayControl(SortIndex = 14)]
    [KSPState]
    [HideInInspector]
    public ModuleProperty<float> DragScalar;
    [LocalizedField("PartModules/ControlSurface/AOA")]
    [KSPState]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 15)]
    public ModuleProperty<float> AoA;
    [Header("Control Surface Setup")]
    [KSPState]
    [HideInInspector]
    public bool IsCtrlSurfaceActive;
    [KSPState]
    public bool AllowControl;
    [KSPState]
    [HideInInspector]
    public float LiftingCtrlSurfaceArea;
    [HideInInspector]
    [KSPState]
    public Vector3 CoPressureCtrlSurfaceOffset;
    [KSPState]
    [HideInInspector]
    public Vector3 CtrlSurfacePivotOffset;
    [Tooltip("The Transform Direction that lift is provided in.\nThis is relative to the CtrlSurfacePivotTransformName Transform.")]
    [KSPDefinition]
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
    [Tooltip("Controls what axis the Lock functionality appears on.")]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    public string CtrlSurfacePivotDeployAxis;
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [KSPDefinition]
    [Tooltip("Range (in degrees) the control surface can deflect.")]
    public float CtrlSurfaceRange;
    [KSPDefinition]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [Tooltip("Minimum angle of ‘deployment’ that the control surface must be at to actuate. If the part is only deployed to this or less, it won’t tilt in response to control inputs.")]
    public float CtrlSurfaceMinimumLockAngleForControl;
    [Tooltip("Area of the Control Surface that will move and generate force - wing area.\nIf this is a Procedural Wing then leave this blank as it will be dynamically generated.")]
    [KSPState]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    public float CtrlSurfaceArea;
    [Tooltip("Movement type for the ctrlsurface. false == use MoveTowards, true == use Lerp ")]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [KSPDefinition]
    public bool UseExponentialSpeed;
    [KSPDefinition]
    [Tooltip("How fast the control surface actuator will try to respond in Degrees/sec ")]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    public float ActuatorSpeedNormalScale;
    [Tooltip("Allow to have a minimum deploy angle instead of -CtrlSurfaceRange.")]
    [KSPState]
    public bool AllowMinimumDeplyAngle;
    [Tooltip("If AllowMinimumDeplyAngle is true use this to set the minimum deploy angle.")]
    [KSPDefinition]
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
