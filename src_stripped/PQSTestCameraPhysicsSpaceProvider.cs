// Decompiled with JetBrains decompiler
// Type: PQSTestCameraPhysicsSpaceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PQSTestCameraPhysicsSpaceProvider : IPhysicsSpaceProvider
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public PQSTestCameraPhysicsSpaceProvider(ITransformFrame frame) => throw null;

  public FloatingOrigin FloatingOrigin
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public IUniverseView UniverseView
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public Transform transform
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public ITransformFrame ReferenceFrame
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public InertialFrame InertialFrame
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d AngularVelocityToPhysics(AngularVelocity angularVelocity) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AngularVelocity PhysicsToAngularVelocity(Vector3d physicsSpaceAngularVelocity) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Position PhysicsToPosition(Vector3d physicsSpacePosition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d PhysicsToPosition(Vector3d physicsSpacePosition, ICoordinateSystem outputFrame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Rotation PhysicsToRotation(QuaternionD physicsSpaceRotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD PhysicsToRotation(
    QuaternionD physicsSpaceRotation,
    ICoordinateSystem outputFrame)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector PhysicsToVector(Vector3d physicsSpaceVector) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d PhysicsToVector(Vector3d physicsSpaceVector, ICoordinateSystem outputFrame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Velocity PhysicsToVelocity(Vector3d physicsSpaceVelociy) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d PositionToPhysics(Position position) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d PositionToPhysics(ICoordinateSystem referenceFrame, Vector3d localPosition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD RotationToPhysics(Rotation rotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public QuaternionD RotationToPhysics(ICoordinateSystem referenceFrame, QuaternionD localRotation) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetReferenceFrame(ITransformFrame referenceFrame) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d VectorToPhysics(Vector vector) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d VectorToPhysics(ICoordinateSystem referenceFrame, Vector3d localPosition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d VelocityToPhysics(Velocity velocity, Position whereIsIt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Vector3d GetGravityForceAtPosition(Position pos) => throw null;
}
