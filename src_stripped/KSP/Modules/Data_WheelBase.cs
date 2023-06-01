// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_WheelBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Inspector;
using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_WheelBase : ModuleData
  {
    [ReadOnly]
    [KSPState]
    public bool IsGrounded;
    [LocalizedField("PartModules/Wheels/FrictionControl")]
    [PAMDisplayControl(SortIndex = 12)]
    [KSPState(CopyToSymmetrySet = true)]
    public ModuleProperty<bool> AutoFriction;
    [KSPState(CopyToSymmetrySet = true)]
    [PAMDisplayControl(SortIndex = 13)]
    [LocalizedField("PartModules/Wheels/Friction")]
    [SteppedRange(0.0f, 10f, 0.1f)]
    public ModuleProperty<float> FrictionMultiplier;
    [KSPDefinition]
    [Tooltip("The Wheel type. Free = free spinning wheel. Motorized - Motorized wheel (rover wheel). Leg = Landing Leg.")]
    public WheelType WheelType;
    [KSPDefinition]
    [Tooltip("If true the collider mesh for the wheel will be resized to fit the visual mesh of the wheel")]
    public bool FitWheelColliderToMesh;
    [KSPDefinition]
    [Tooltip("The radius of the wheel")]
    public float Radius;
    [KSPDefinition]
    [Tooltip("The center offset of the wheel")]
    public Vector3 Center;
    [KSPDefinition]
    [Tooltip("The mass of the wheel in Tons.")]
    public float Mass;
    [KSPDefinition]
    [Tooltip("The friction sharpness")]
    public float FrictionSharpness;
    [KSPDefinition]
    [Tooltip("The damping applied to the wheel")]
    public float WheelDamping;
    [KSPDefinition]
    [Tooltip("Max speed the wheel can do")]
    public float WheelMaxSpeed;
    [KSPDefinition]
    [Tooltip("Allow each wheel module to specify one object that clips.\nIf specified this object (and all it's children) will have it's layer changed between physics ignore and default depending on the deployment state.")]
    public string ClipObject;
    [Tooltip("This is the tire friction curve adherent start position. For Landing Legs this will be the peak x value.\nRefer to https://vehiclephysics.com/blocks/tires/")]
    [KSPDefinition]
    public float AdherentStart;
    [KSPDefinition]
    [Tooltip("This is the tire friction curve adherent value at the start position. For Landing Legs this will be the peak y value.\nRefer to https://vehiclephysics.com/blocks/tires/")]
    public float FrictionAdherent;
    [KSPDefinition]
    [Tooltip("This is the tire friction curve adherent peak start position.\nRefer to https://vehiclephysics.com/blocks/tires/")]
    public float PeakStart;
    [KSPDefinition]
    [Tooltip("This is the tire friction curve adherent peak value.\nRefer to https://vehiclephysics.com/blocks/tires/")]
    public float FrictionPeak;
    [KSPDefinition]
    [Tooltip("This is the tire friction curve adherent lowest point start position.\nRefer to https://vehiclephysics.com/blocks/tires/")]
    public float LimitStart;
    [KSPDefinition]
    [Tooltip("This is the tire friction curve adherent limit value.\nRefer to https://vehiclephysics.com/blocks/tires/")]
    public float FrictionLimit;
    [KSPDefinition]
    [Tooltip("Percent increase in friction at 0g. If geeBias = 1, then frictionMultiplier = 2.0 at 0g")]
    public float GeeBias;
    [Tooltip("The ground height to allow when launching with the wheels deployed.")]
    [KSPDefinition]
    public float GroundHeightOffset;
    [KSPDefinition]
    [Tooltip("The number of PhysX substeps when inactive")]
    public int InctiveSubsteps;
    [KSPDefinition]
    [Tooltip("The number of PhysX substeps when active.")]
    public int ActiveSubsteps;
    [KSPDefinition]
    [Tooltip("How sharply tire forces are applied.")]
    public float TireForceSharpness;
    [KSPDefinition]
    [Tooltip("How sharply suspension forces are applied.")]
    public float SuspensionForceSharpness;
    [KSPDefinition]
    [Tooltip("This must be the wheel collider transform name from the model.")]
    public string WheelColliderTransformName;
    [KSPDefinition]
    [Tooltip("This must be the wheel transform (the bit that spins) name from the model.\nThis must be the deployment target transform (for Landing Legs) name from the model")]
    public string WheelTransformName;
    [Tooltip("The rate as which the spring targetPosition is slerped in VPWheelCollider.")]
    [KSPDefinition]
    public float SpringSlerpRate;
    [KSPDefinition]
    [Tooltip("This is the minimum downforce to apply to the wheel.")]
    public float MinimumDownforce;
    [KSPDefinition]
    [Tooltip("If set to true will use the new friction model.")]
    public bool UseNewFrictionModel;
    [Tooltip("If set to true will align the wheel visual and collider.\nOnly applies to wheels that are deployable.\nLanding legs should set this to false and wheels set this to true.")]
    [KSPDefinition]
    public bool AlignVisualAndCollider;
    [Tooltip("Set this to a normalized value 0-1 where 0 is fully retracted and 1 is fully deployed.\nOnly applies to wheels that are deployable.\nAt this normalized time the subsystems will be turned on (suspension, wheel collider, etc) when deploying.")]
    [KSPDefinition]
    public float DeploymentSubsystemNormalized;
    [Tooltip("Set this to a normalized value 0-1 where 0 is fully deployed and 1 is fully retracted.\nOnly applies to wheels that are deployable.\nAt this normalized time the subsystems will be turned off (suspension, wheel collider, etc) when retracting.")]
    [KSPDefinition]
    public float RetractionSubsystemNormalized;
    [KSPDefinition]
    [Tooltip("Whether to use a stand in collider or not when deploying/retracting.\nThis is usually only used for larger deployable wheels that need a stand-in collider before the wheel collider is created.")]
    public bool UseStandinCollider;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetAutoFrictionString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetAutoFrictionTweakableString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal override List<OABPartData.PartInfoModuleEntry> GetPartInfoEntries(
      System.Type partBehaviourModuleType,
      List<OABPartData.PartInfoModuleEntry> delegateList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_WheelBase() => throw null;
  }
}
