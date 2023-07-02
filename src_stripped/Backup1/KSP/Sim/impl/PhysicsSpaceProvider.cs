// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PhysicsSpaceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class PhysicsSpaceProvider : 
    KerbalMonoBehaviour,
    IFixedUpdate,
    IPriorityOverride,
    IPhysicsSpaceProvider
  {
    public const double TRANSFORM_FRAME_ALTITUDE_OFFSET = 20000.0;
    private InertialFrame _inertialReferenceFrame;
    private ITransformFrame _inertialReferenceTransformFrame;

    public ITransformFrame ReferenceFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReferenceFrame(ITransformFrame referenceFrame) => throw null;

    public FloatingOrigin FloatingOrigin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SyncTo(FloatingOrigin floatingOrigin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position PhysicsToPosition(Vector3d scenePoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d PhysicsToPosition(Vector3d scenePoint, ICoordinateSystem outputFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d PositionToPhysics(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d PositionToPhysics(ICoordinateSystem referenceFrame, Vector3d localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rotation PhysicsToRotation(QuaternionD sceneRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD PhysicsToRotation(QuaternionD sceneRotation, ICoordinateSystem outputFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD RotationToPhysics(Rotation rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuaternionD RotationToPhysics(
      ICoordinateSystem referenceFrame,
      QuaternionD localRotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector PhysicsToVector(Vector3d sceneVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d PhysicsToVector(Vector3d sceneVector, ICoordinateSystem referenceFrame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d VectorToPhysics(Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d VectorToPhysics(ICoordinateSystem referenceFrame, Vector3d localVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d VelocityToPhysics(Velocity velocity, Position whereIsIt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Velocity PhysicsToVelocity(Vector3d physicsSpaceVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d AngularVelocityToPhysics(AngularVelocity angularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AngularVelocity PhysicsToAngularVelocity(Vector3d physicsSpaceAngularVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetGravityForceAtPosition(Position pos) => throw null;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IFixedUpdate.OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PhysicsSpaceProvider() => throw null;

    [SpecialName]
    [MethodImpl(MethodImplOptions.NoInlining)]
    Transform IPhysicsSpaceProvider.get_transform() => throw null;
  }
}
