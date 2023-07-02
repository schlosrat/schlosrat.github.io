// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IPhysicsSpaceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Sim.impl;
using UnityEngine;

namespace KSP.Sim
{
  public interface IPhysicsSpaceProvider
  {
    FloatingOrigin FloatingOrigin { get; }

    Transform transform { get; }

    void SetReferenceFrame(ITransformFrame referenceFrame);

    ITransformFrame ReferenceFrame { get; }

    Position PhysicsToPosition(Vector3d physicsSpacePosition);

    Vector3d PhysicsToPosition(Vector3d physicsSpacePosition, ICoordinateSystem outputFrame);

    Vector3d PositionToPhysics(Position position);

    Vector3d PositionToPhysics(ICoordinateSystem referenceFrame, Vector3d localPosition);

    Rotation PhysicsToRotation(QuaternionD physicsSpaceRotation);

    QuaternionD PhysicsToRotation(QuaternionD physicsSpaceRotation, ICoordinateSystem outputFrame);

    QuaternionD RotationToPhysics(Rotation rotation);

    QuaternionD RotationToPhysics(ICoordinateSystem referenceFrame, QuaternionD localRotation);

    Vector PhysicsToVector(Vector3d physicsSpaceVector);

    Vector3d PhysicsToVector(Vector3d physicsSpaceVector, ICoordinateSystem outputFrame);

    Vector3d VectorToPhysics(Vector vector);

    Vector3d VectorToPhysics(ICoordinateSystem referenceFrame, Vector3d localPosition);

    Vector3d VelocityToPhysics(Velocity velocity, Position whereIsIt);

    Velocity PhysicsToVelocity(Vector3d physicsSpaceVelociy);

    Vector3d AngularVelocityToPhysics(AngularVelocity angularVelocity);

    AngularVelocity PhysicsToAngularVelocity(Vector3d physicsSpaceAngularVelocity);

    Vector3d GetGravityForceAtPosition(Position pos);
  }
}
