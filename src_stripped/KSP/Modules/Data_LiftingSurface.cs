// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_LiftingSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_LiftingSurface : ModuleData
  {
    [HideInInspector]
    [KSPState]
    [LocalizedField("PartModules/LiftingSurface/LiftDragRatio")]
    [PAMDisplayControl(SortIndex = 15)]
    public ModuleProperty<float> LiftDragRatio;
    [LocalizedField("PartModules/LiftingSurface/Lift")]
    [KSPState]
    [HideInInspector]
    public ModuleProperty<float> LiftScalar;
    [KSPState]
    [HideInInspector]
    [LocalizedField("PartModules/LiftingSurface/Drag")]
    public ModuleProperty<float> DragScalar;
    [HideInInspector]
    [LocalizedField("PartModules/LiftingSurface/AOA")]
    [KSPState]
    public ModuleProperty<float> AoA;
    [KSPDefinition]
    [Tooltip("If true lift is the same whether the surface is upside down or not.")]
    public bool omnidirectional;
    [Tooltip("This curve is evaluated to obtain coefficient of lift for a given angle of attack in degrees.")]
    [KSPDefinition]
    public FloatCurve liftCurve;
    [Tooltip("This curve is evaluated to obtain coefficient of lift multiplier based on the current mach speed of the vessel.")]
    [KSPDefinition]
    public FloatCurve liftMachCurve;
    [KSPDefinition]
    [Tooltip("This curve is evaluated to obtain coefficient of drag for a given angle of attack in degrees.")]
    public FloatCurve dragCurve;
    [KSPDefinition]
    [Tooltip("This curve is evaluated to obtain coefficient of drag multiplier based on the current mach speed of the vessel.")]
    public FloatCurve dragMachCurve;
    [Tooltip("The name of the lifting surface curve that will be used from PhysicsGlobals.")]
    [KSPDefinition]
    public string liftingSurfaceCurve;
    [Tooltip("The Transform Direction that lift is provded in.")]
    [KSPDefinition]
    public Data_LiftingSurface.TransformDir transformDir;
    [Tooltip("1 = Positive transformDir, -1 = Negative transformDir")]
    [KSPDefinition]
    public float transformSign;
    [Tooltip("The Transform that provides the lift. If left blank will use the part transform.")]
    [KSPDefinition]
    public string transformName;
    [KSPDefinition]
    [Tooltip("If True the attachNodeNode must be attached to provide lift and drag forces.")]
    public bool nodeEnabled;
    [Tooltip("The attachNodeNode that must be attached if nodeEnabled is true.")]
    [KSPDefinition]
    public string attachNodeName;
    [Tooltip("Lift coefficient that scales the lift provided. - wing area. If Procedural leave this blank as it will be dynamically calculated.")]
    [KSPState]
    public float deflectionLiftCoeff;
    [Tooltip("If true the lift is projected on plane that is the normal of the velocity direction.")]
    [KSPDefinition]
    public bool perpendicularOnly;
    [Tooltip("Use the drag model in this module to calculate and apply drag forces.")]
    [KSPDefinition]
    public bool useInternalDragModel;
    [KSPState]
    [HideInInspector]
    public Vector3 CoPOffset;
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
    public Data_LiftingSurface() => throw null;

    public enum TransformDir
    {
      X,
      Y,
      Z,
    }

    [Serializable]
    public class DragForce : IForce
    {
      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeForce
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public static Data_LiftingSurface.DragForce Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DragForce() => throw null;
    }

    [Serializable]
    public class LiftForce : IForce
    {
      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeForce
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public static Data_LiftingSurface.LiftForce Default
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public LiftForce() => throw null;
    }
  }
}
