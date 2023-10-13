// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ControlSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
    [FormerlySerializedAs("deploy")]
    [Tooltip("Is the control surface in a deployed state")]
    [LocalizedField("PartModules/ControlSurface/Deploy")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 2)]
    public ModuleProperty<bool> Deploy;
    [PAMDisplayControl(SortIndex = 3)]
    [FormerlySerializedAs("deployAngle")]
    [SteppedRange(-15f, 15f, 0.5f)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/ControlSurface/DeployAngle")]
    [Tooltip("Angle to which the control surface will deflect when deployed (acts as base angle for control deflection). In units of degrees.")]
    public ModuleProperty<float> DeployAngle;
    [Tooltip("Angle to which the control surface will deflect when deployed (acts as base angle for control deflection). In units of degrees.")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 3)]
    [LocalizedField("PartModules/ControlSurface/Invert")]
    public ModuleProperty<bool> InvertControl;
    [HideInInspector]
    [LocalizedField("PartModules/ControlSurface/AdvancedSettings")]
    [PAMDisplayControl(SortIndex = 5)]
    public ModuleProperty<bool> IsAdvancedSettingsShown;
    [Header("Control Surface Behaviour")]
    [LocalizedField("PartModules/ControlSurface/PitchEnabled")]
    [FormerlySerializedAs("enablePitch")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 6)]
    [HideInInspector]
    public ModuleProperty<bool> EnablePitch;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 7)]
    [LocalizedField("PartModules/ControlSurface/YawEnabled")]
    [FormerlySerializedAs("enableYaw")]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> EnableYaw;
    [LocalizedField("PartModules/ControlSurface/RollEnabled")]
    [FormerlySerializedAs("enableRoll")]
    [KSPState(CopyToSymmetrySet = true)]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 8)]
    public ModuleProperty<bool> EnableRoll;
    [Tooltip("Adjusts how much the control surface will be allowed to deflect to respond to control inputs.  Limits set by the config.  In units of degrees.")]
    [SteppedRange(0.0f, 15f, 0.5f)]
    [FormerlySerializedAs("authorityLimiter")]
    [LocalizedField("PartModules/ControlSurface/AuthorityLimiter")]
    [PAMDisplayControl(SortIndex = 9)]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<float> AuthorityLimiter;
    [KSPState]
    [HideInInspector]
    [LocalizedField("PartModules/LiftingSurface/Lift")]
    [PAMDisplayControl(SortIndex = 10)]
    public ModuleProperty<float> LiftScalarParent;
    [LocalizedField("PartModules/LiftingSurface/Drag")]
    [PAMDisplayControl(SortIndex = 11)]
    [KSPState]
    [HideInInspector]
    public ModuleProperty<float> DragScalarParent;
    [LocalizedField("PartModules/LiftingSurface/AOA")]
    [PAMDisplayControl(SortIndex = 12)]
    [KSPState]
    [HideInInspector]
    public ModuleProperty<float> AoAParent;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 13)]
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
    [PAMDisplayControl(SortIndex = 15)]
    [HideInInspector]
    public ModuleProperty<float> AoA;
    [Header("Control Surface Setup")]
    [KSPState]
    [HideInInspector]
    public bool IsCtrlSurfaceActive;
    [KSPState]
    public bool AllowControl;
    [HideInInspector]
    [KSPState]
    public float LiftingCtrlSurfaceArea;
    [KSPState]
    [HideInInspector]
    public Vector3 CoPressureCtrlSurfaceOffset;
    [HideInInspector]
    [KSPState]
    public Vector3 CtrlSurfacePivotOffset;
    [Tooltip("The Transform Direction that lift is provided in.\nThis is relative to the CtrlSurfacePivotTransformName Transform.")]
    [KSPDefinition]
    public Data_LiftingSurface.TransformDir CtrlTransformDir;
    [Tooltip("The Transform Axis that the control surface rotates around.\nThis is relative to the CtrlSurfacePivotTransformName Transform.")]
    [KSPDefinition]
    public Data_LiftingSurface.TransformDir CtrlTransformRotAxis;
    [Tooltip("1 = Positive transformDir, -1 = Negative transformDir")]
    [KSPDefinition]
    public float CtrlTransformSign;
    [Tooltip("The transform that will be adjusted to show the visual impact of the control surface motion.")]
    [KSPDefinition]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    public string CtrlSurfacePivotTransformName;
    [Tooltip("Controls what axis the Lock functionality appears on.")]
    [KSPDefinition]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    public string CtrlSurfacePivotDeployAxis;
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [Tooltip("Range (in degrees) the control surface can deflect.")]
    [KSPDefinition]
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
    [Tooltip("How fast the control surface actuator will try to respond in Degrees/sec ")]
    [KSPDefinition]
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
    [KSPDefinition]
    [Tooltip("Multiple of Area of Mesh to get lift value.")]
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
