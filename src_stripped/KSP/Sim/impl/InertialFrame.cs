// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.InertialFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class InertialFrame : IPositionDriver, IRotationDriver, ILinearMotionDriver
  {
    private IMotionFrame _bodyMotionFrame;
    private double _universalTime;
    private Vector3d positionAtReferenceTimeInBodyFrame;
    private QuaternionD rotationAtReferenceTimeInBodyFrame;
    private Vector3d relativeVelocityInBodyFrame;
    private double referenceTime;
    private bool isSnapHappeningNow;
    private bool _hasPhysicsSpaceProvider;
    private IPhysicsSpaceProvider _physicsSpaceProvider;
    private static List<Action> onFrameSnapComplete;

    public IMotionFrame bodyMotionFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double universalTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IMotionFrame inertialMotionFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITransformFrame inertialReferenceFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ITransformModel inertialReferenceTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ICoordinateSystem coordinateSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3d localPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public QuaternionD localRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IMotion relativeToMotion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector relativeVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool CanAcceptPositionUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePosition(Position newPosition) => throw null;

    public event Action<Position> PositionUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public Rotation Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool CanAcceptRotationUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRotation(Rotation newRotation) => throw null;

    public event Action<Rotation> RotationUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public Velocity Velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVelocity(Velocity newVelocity) => throw null;

    public event Action<Velocity> VelocityUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<List<Action>> onFrameSnapStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<UpdateSpacePosition, List<Action>> onFrameSnapPositions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<UpdatePhysicsVelocities, List<Action>> onFrameSnapVelocitiesPhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action<Vector3d, List<Action>> onFrameSnapPositionOffsetPhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action onFrameSnapEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InertialFrame(IMotionFrame inertialMotionFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SnapTo(
      IMotionFrame newParent,
      Position snapToPosition,
      Rotation snapToRotation,
      bool snapVelocity,
      Velocity snapToVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateNewPositionAndRotation(
      Position oldPosition,
      out Position newPosition,
      Rotation oldRotation,
      out Rotation newRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateNewVelocities(
      Vector3 oldVelocity,
      out Velocity newVelocity,
      Vector3 oldAngularVelocity,
      out AngularVelocity newAngularVelocity,
      Vector3 observerPosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalPosition(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalVector(Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD ToLocalRotation(Rotation rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalPosition(ICoordinateSystem coordinateSystem, Vector3d localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalVector(ICoordinateSystem coordinateSystem, Vector3d localTranslation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD ToLocalRotation(
      ICoordinateSystem coordinateSystem,
      QuaternionD localRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position FromLocalPosition(Vector3d localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector FromLocalVector(Vector3d localVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rotation FromLocalRotation(QuaternionD localRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d LocalInertialAcceleration(Position position, Velocity frameVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalVelocity(Velocity observedVelocity, Position observedPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d ToLocalAngularVelocity(AngularVelocity angularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Velocity FromLocalVelocity(Vector3d localVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AngularVelocity FromLocalAngularVelocity(Vector3d localAngularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static InertialFrame() => throw null;
  }
}
