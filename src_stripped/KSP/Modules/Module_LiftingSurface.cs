// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_LiftingSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_LiftingSurface : PartBehaviourModule, ILiftProvider
  {
    [FormerlySerializedAs("data")]
    [SerializeField]
    protected Data_LiftingSurface dataLiftingSurface;
    [HideInInspector]
    public Transform baseTransform;
    protected CorePartData CorePartData;
    private Data_LiftingSurface.DragForce _dragForce;
    private Data_LiftingSurface.LiftForce _liftForce;
    private AttachNodeData _attachNode;
    public bool debugThis;
    protected static bool _showPAMDebug;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Data_LiftingSurface DataLiftingSurface
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Data_LiftingSurface.LiftForce LiftForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool ShowPAMDebug
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static event Action OnPAMDebugChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAwake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetLiftingCurves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CalculateLiftDragForces(
      ref ModuleProperty<float> liftScalar,
      ref ModuleProperty<float> dragScalar,
      Data_LiftingSurface.TransformDir transformDir,
      float transformSign,
      Transform referenceTransform,
      ref Data_LiftingSurface.LiftForce liftForce,
      ref Data_LiftingSurface.DragForce dragForce,
      float deflectionLiftCoeff,
      Vector3 coPressureOffset,
      ref ModuleProperty<float> aoaProperty,
      out Vector3 normalizedVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupCoefficients(
      Transform baseTransform,
      Data_LiftingSurface.TransformDir transformDir,
      float transformSign,
      Vector3 velocity,
      out Vector3 normalizedVelocity,
      out Vector3 liftVector,
      out float liftDot,
      out float absDot)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetLiftVector(
      ref ModuleProperty<float> liftScalar,
      Vector3 liftVector,
      float liftDot,
      float absDot,
      double Q,
      float mach,
      float deflectionLiftCoeff,
      Vector3 normalizedVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetDragVector(
      ref ModuleProperty<float> dragScalar,
      Vector3 nVel,
      float absDot,
      double Q,
      float deflectionLiftCoeff)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetDragVector(
      ref ModuleProperty<float> dragScalar,
      Vector3 nVel,
      float absDot,
      double Q,
      float mach,
      float deflectionLiftCoeff)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnCenterOfLiftQuery(ObjectAssemblyCOPressureQuery qry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void COPQuery(
      ref ObjectAssemblyCOPressureQuery qry,
      Transform baseTransform,
      Data_LiftingSurface.TransformDir transformDir,
      float transformSign,
      float deflectionLiftCoeff,
      Vector3 coPressureOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool GetDisableAerodynamics() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdatePAMControlVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_LiftingSurface() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Module_LiftingSurface() => throw null;
  }
}
