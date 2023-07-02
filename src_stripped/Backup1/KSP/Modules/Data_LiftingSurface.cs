// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_LiftingSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    [PAMDisplayControl(SortIndex = 15)]
    [HideInInspector]
    [KSPState]
    [LocalizedField("PartModules/LiftingSurface/LiftDragRatio")]
    public ModuleProperty<float> LiftDragRatio;
    [HideInInspector]
    [KSPState]
    [LocalizedField("PartModules/LiftingSurface/Lift")]
    public ModuleProperty<float> LiftScalar;
    [LocalizedField("PartModules/LiftingSurface/Drag")]
    [HideInInspector]
    [KSPState]
    public ModuleProperty<float> DragScalar;
    [KSPState]
    [LocalizedField("PartModules/LiftingSurface/AOA")]
    [HideInInspector]
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
    [Tooltip("This curve is evaluated to obtain coefficient of drag for a given angle of attack in degrees.")]
    [KSPDefinition]
    public FloatCurve dragCurve;
    [KSPDefinition]
    [Tooltip("This curve is evaluated to obtain coefficient of drag multiplier based on the current mach speed of the vessel.")]
    public FloatCurve dragMachCurve;
    [Tooltip("The name of the lifting surface curve that will be used from PhysicsGlobals.")]
    [KSPDefinition]
    public string liftingSurfaceCurve;
    [KSPDefinition]
    [Tooltip("The Transform Direction that lift is provded in.")]
    public Data_LiftingSurface.TransformDir transformDir;
    [KSPDefinition]
    [Tooltip("1 = Positive transformDir, -1 = Negative transformDir")]
    public float transformSign;
    [KSPDefinition]
    [Tooltip("The Transform that provides the lift. If left blank will use the part transform.")]
    public string transformName;
    [KSPDefinition]
    [Tooltip("If True the attachNodeNode must be attached to provide lift and drag forces.")]
    public bool nodeEnabled;
    [KSPDefinition]
    [Tooltip("The attachNodeNode that must be attached if nodeEnabled is true.")]
    public string attachNodeName;
    [Tooltip("Lift coefficient that scales the lift provided. - wing area. If Procedural leave this blank as it will be dynamically calculated.")]
    [KSPState]
    public float deflectionLiftCoeff;
    [KSPDefinition]
    [Tooltip("If true the lift is projected on plane that is the normal of the velocity direction.")]
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
