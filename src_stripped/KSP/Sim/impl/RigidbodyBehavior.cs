// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.RigidbodyBehavior
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
  public class RigidbodyBehavior : 
    ViewObjectComponent<RigidbodyComponent>,
    IRigidbodyDriver,
    IPositionDriver,
    IRotationDriver,
    ILinearMotionDriver,
    IAngularMotionDriver,
    IUpdate,
    IFixedUpdate,
    IPriorityOverride
  {
    public bool StartWithRigidbody;
    private PartPhysicsModes _physicsMode;
    protected const double KPA2ATM = 0.0098692326671601278;
    [Header("Debug Flags")]
    public bool showPosition;
    public bool showCenterOfMass;
    public bool showForce;
    public bool showTorques;
    public bool showGravity;
    [SerializeField]
    private bool _canSleep;
    [SerializeField]
    [Header("Tensor Scaling")]
    private RigidbodyBehavior.MassScaleType _massScaleType;
    [SerializeField]
    private RigidbodyBehavior.MassScaleType _dynamicMassScaleType;
    [SerializeField]
    private float _massScaleFactor;
    [SerializeField]
    private float _globalTensorScalingOverride;
    private bool _isUnscaledInertiaTensorInitialized;
    private Vector3 _unscaledInertiaTensor;
    private KSPPartAudio _audioComponent;
    private List<ConfigurableJoint> _tempJointStorage;
    private const float DEFAULT_SLEEP_TIMER_DURATION_SECONDS = 0.25f;
    private float _sleepTimer;
    private bool _isTryingToSleep;
    private int _numGravityEaseUpdates;
    private static Collider[] _terrainOverlapTesthits;
    private int _executionPriorityOverride;
    private PartBehavior originalConnectPart;
    private Transform originalParent;
    public float _mass;
    private Position _centerOfMass;

    public ISimulationObjectView RelativeObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IPhysicsDebuggable PhysicsDebuggable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public RigidbodyComponent Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IRigidbodyDriver PhysXOutput
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

    public Vector relativeAngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector relativeAcceleration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector relativeAngularAcceleration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsPhysXActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Rigidbody activeRigidBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsPhysXPositioned
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartPhysicsModes PhysicsMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsGravityDisabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool CanAcceptPositionUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceRestoreStartingPositionAndRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(RigidbodyComponent simObjectComponent) => throw null;

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
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
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
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVelocity(Velocity newVelocity) => throw null;

    public event Action<Velocity> VelocityUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public AngularVelocity AngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAngularVelocity(AngularVelocity newAngularVelocity) => throw null;

    public event Action<AngularVelocity> AngularVelocityUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FlushPositionUpdates() => throw null;

    [Obsolete("Use DestroyJointsAttachedTo(Rigidbody)")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyJointLink() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DestroyJointsAttachedTo(Rigidbody attachedRigidbody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DestroyJointsAttachedTo(RigidbodyBehavior attachedRigidbodyBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DestroyJointsAttachedTo(RigidbodyComponent attachedRigidbodyComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DestroyJoint(ConfigurableJoint joint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogDestroyJoint(Joint joint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshDriver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFromSimObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateToSimObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3d GetGravityForceAtCurrentPosition() => throw null;

    public int ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPhysicsUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScaleInertiaTensor(Rigidbody rb, float scalar) => throw null;

    [ContextMenu("Set Estimate Iteration Count")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScaledRigidbodySolverIterationCount() => throw null;

    [ContextMenu("Reset Inertia Tensor")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetInertiaTensor() => throw null;

    public List<ConfigurableJointInfo> originalJointInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RigidbodyInfo originalRigidbodyInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float mass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Position centerOfMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StoreOriginalJointInfo(
      PartOwnerBehavior.JointConnection jointConnection,
      PartBehavior connectPart)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartOwnerBehavior.JointConnection RestoreOriginalJointConnection(bool createJoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<ConfigurableJoint> RestoreOriginalJoints(bool createJoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReconnectJoint(List<PartBehavior> conParts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreOriginalRigidbody(bool createRigidBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateRigidbodyInfo(List<PartBehavior> partChilds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRigidBodyFromFather(RigidbodyBehavior father) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectObject(ISimulationObjectView fatherObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void onFrameSnapPositions(UpdateSpacePosition updatePositions, List<Action> actionList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void onFrameSnapVelocitiesPhysicsSpace(
      UpdatePhysicsVelocities updatePhysicsVelocities,
      List<Action> actionList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PromoteToPhysicalPart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rigidbody StartPhysX() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopPhysX(Transform parent, Vector3? localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RedirectPhysX(Rigidbody rigidbody, Transform parent, Vector3 localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float GetMassNormalizedKineticEnergy(Rigidbody r) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetDisableGravity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetDisableAerodynamics() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RigidbodyBehavior() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static RigidbodyBehavior() => throw null;

    [Serializable]
    private enum MassScaleType
    {
      None,
      Explicit,
      InverseMass,
      InverseMassDifferential,
    }
  }
}
