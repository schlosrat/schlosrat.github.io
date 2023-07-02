// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.RigidbodyComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Sim.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class RigidbodyComponent : 
    ObjectComponent,
    IRigidbodyDriver,
    IPositionDriver,
    IRotationDriver,
    ILinearMotionDriver,
    IAngularMotionDriver
  {
    private Vector3d _startingLocalPosition;
    private QuaternionD _startingLocalRotation;
    private readonly List<IForce> _forces;
    private readonly List<IForce> _singleFrameForces;
    private readonly List<ITorque> _torques;
    private readonly List<RigidbodyComponent.Impulse> _pendingImpulses;
    private IRigidbodyDriver physXBodyDriver;
    public bool trackPhysXPositionDriver;
    private PartPhysicsModes _physicsMode;

    [TypeConverterIgnore]
    public override System.Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type ViewObjectComponentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IPhysicsOwner physicsOwner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3d StartingLocalPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public QuaternionD StartingLocalRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<IForce> Forces
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<IForce> SingleFrameForces
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<ITorque> Torques
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<RigidbodyComponent.Impulse> PendingImpulses
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
    }

    public QuaternionD localRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IMotion relativeToMotion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector relativeVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector relativeAngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IRigidbodyDriver PhysXBodyDriver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void KillVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void KillAngularVelocity() => throw null;

    public event Action<Velocity> VelocityUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public Velocity Velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVelocity(Velocity newVelocity) => throw null;

    public AngularVelocity AngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAngularVelocity(AngularVelocity newAngularVelocity) => throw null;

    public event Action<AngularVelocity> AngularVelocityUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PhysXBodyDriver_onPositionUpdated(Position newPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PhysXBodyDriver_onVelocityUpdated(Velocity newVelocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PhysXBodyDriver_onRotationUpdated(Rotation newRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PhysXBodyDriver_onAngularVelocityUpdated(AngularVelocity angularVelocity) => throw null;

    public bool TrackPhysXPositionDriver
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
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
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
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

    public float mass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector inertiaTensor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Position centerOfMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Rotation inertiaTensorRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double drag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public double angularDrag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartPhysicsModes PhysicsMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RigidbodyComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RigidbodyComponent(UniverseModel universeModel, PartPhysicsModes physicsMode = PartPhysicsModes.Full) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecordStartingLocalPositionAndRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddForce(IForce force) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddSingleFrameForce(IForce singleFrameForce) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveForce(IForce force) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveSingleFrameForce(IForce singleFrameForce) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearSingleFrameForces() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTorque(ITorque torque) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTorque(ITorque torque) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyImpulse(
      ForceType forceType,
      Vector3d relativeImpulse,
      Vector3d relativePosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearPendingImpulses() => throw null;

    public struct Impulse
    {
      public ForceType ForceMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeImpulse
      {
        [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativePosition
      {
        [MethodImpl(MethodImplOptions.NoInlining)] readonly get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }
    }
  }
}
