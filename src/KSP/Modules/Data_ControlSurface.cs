// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ControlSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    [HideInInspector]
    [KSPState]
    [PAMDisplayControl(SortIndex = 1)]
    public ModuleProperty<float> LiftDragRatioParent;
    [LocalizedField("PartModules/ControlSurface/Deploy")]
    [KSPState(CopyToSymmetrySet = true)]
    [Tooltip("Is the control surface in a deployed state")]
    [PAMDisplayControl(SortIndex = 2)]
    [FormerlySerializedAs("deploy")]
    public ModuleProperty<bool> Deploy;
    [FormerlySerializedAs("deployAngle")]
    [Tooltip("Angle to which the control surface will deflect when deployed (acts as base angle for control deflection). In units of degrees.")]
    [SteppedRange(-15f, 15f, 0.5f)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/ControlSurface/DeployAngle")]
    [PAMDisplayControl(SortIndex = 3)]
    public ModuleProperty<float> DeployAngle;
    [Tooltip("Angle to which the control surface will deflect when deployed (acts as base angle for control deflection). In units of degrees.")]
    [LocalizedField("PartModules/ControlSurface/Invert")]
    [PAMDisplayControl(SortIndex = 3)]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> InvertControl;
    [LocalizedField("PartModules/ControlSurface/AdvancedSettings")]
    [PAMDisplayControl(SortIndex = 5)]
    [HideInInspector]
    public ModuleProperty<bool> IsAdvancedSettingsShown;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 6)]
    [KSPState(CopyToSymmetrySet = true)]
    [FormerlySerializedAs("enablePitch")]
    [LocalizedField("PartModules/ControlSurface/PitchEnabled")]
    [Header("Control Surface Behaviour")]
    public ModuleProperty<bool> EnablePitch;
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 7)]
    [KSPState(CopyToSymmetrySet = true)]
    [LocalizedField("PartModules/ControlSurface/YawEnabled")]
    [FormerlySerializedAs("enableYaw")]
    public ModuleProperty<bool> EnableYaw;
    [LocalizedField("PartModules/ControlSurface/RollEnabled")]
    [FormerlySerializedAs("enableRoll")]
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 8)]
    [HideInInspector]
    public ModuleProperty<bool> EnableRoll;
    [FormerlySerializedAs("authorityLimiter")]
    [PAMDisplayControl(SortIndex = 9)]
    [SteppedRange(0.0f, 15f, 0.5f)]
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
    [KSPState]
    [HideInInspector]
    public ModuleProperty<float> AoAParent;
    [LocalizedField("PartModules/ControlSurface/Lift")]
    [KSPState]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 13)]
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
    [HideInInspector]
    [KSPState]
    public float LiftingCtrlSurfaceArea;
    [KSPState]
    [HideInInspector]
    public Vector3 CoPressureCtrlSurfaceOffset;
    [KSPState]
    [HideInInspector]
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
    [KSPDefinition]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [Tooltip("The transform that will be adjusted to show the visual impact of the control surface motion.")]
    public string CtrlSurfacePivotTransformName;
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [Tooltip("Range (in degrees) the control surface can deflect.")]
    [KSPDefinition]
    public float CtrlSurfaceRange;
    [Tooltip("Area of the Control Surface that will move and generate force - wing area.\nIf this is a Procedural Wing then leave this blank as it will be dynamically generated.")]
    [KSPState]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    public float CtrlSurfaceArea;
    [Tooltip("Movement type for the ctrlsurface. false == use MoveTowards, true == use Lerp ")]
    [KSPDefinition]
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    public bool UseExponentialSpeed;
    [FormerlySerializedAs("actuatorSpeedNormalScale")]
    [Tooltip("How fast the control surface actuator will try to respond in Degrees/sec ")]
    [KSPDefinition]
    public float ActuatorSpeedNormalScale;
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
