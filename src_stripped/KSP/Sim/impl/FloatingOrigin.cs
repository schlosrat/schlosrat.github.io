// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.FloatingOrigin
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class FloatingOrigin : 
    KerbalMonoBehaviour,
    IFloatingOrigin,
    IFixedUpdate,
    IUpdate,
    IPriorityOverride
  {
    [Range(10f, 3000f)]
    public double PositionThresholdMeters;
    [Range(10f, 3000f)]
    public double VelocityThresholdMeters;
    [SerializeField]
    [Header("Debug")]
    private FloatingOrigin.VelocitySnapTarget _velocitySnapMode;
    public bool IsPendingForceSnap;
    private bool _fixedUpdateTickedThisFrame;
    internal double distanceFromOrigin;

    public InertialFrame PhysXOrigin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ResolveFloatingOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryInertialReferenceFrameSnap(
      IUniverseObserver observer,
      IMotionFrame newParent,
      Position desiredPosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SnapInertialReferenceFrame(
      IUniverseObserver observer,
      IMotionFrame newParent,
      Position desiredPosition,
      bool isSnapVelocity,
      Velocity desiredVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsWithinInertialReferenceFrameRange(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsChildOfInertialReferenceFrame(ITransformModel transformModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateInertialReferenceFrameChildren() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CanRunPhysX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FloatingOrigin() => throw null;

    private enum VelocitySnapTarget
    {
      None,
      Observer,
      ObserverSOI,
    }
  }
}
