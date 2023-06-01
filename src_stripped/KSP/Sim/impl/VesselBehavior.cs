// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.VesselBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Inspector;
using KSP.Messages;
using KSP.Networking.MP;
using KSP.Sim.Data;
using KSP.Sim.State;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class VesselBehavior : 
    ViewObjectComponent<VesselComponent>,
    IPhysicsDebuggable,
    IUpdate,
    IFixedUpdate,
    IPriorityOverride
  {
    private PartOwnerBehavior _partOwner;
    protected PartBehavior partWithGroundContact;
    [Header("Runtime State")]
    [SerializeField]
    [ReadOnly]
    private VesselBehavior.PackState _packState;
    [SerializeField]
    [ReadOnly]
    private VesselBehavior.PhysicsState _physicsState;
    [ReadOnly]
    [SerializeField]
    private bool _isInitialized;
    [Header("Debug Fields")]
    [SerializeField]
    private bool _disableAutoPack;
    public bool ShowCenterOfMass;
    private RigidbodyBehavior _rigidBody;
    private bool _isBoundsDirty;
    private BoundingSphere _boundingSphere;
    private Bounds _boundingBox;
    [SerializeField]
    private AtmosphericFxSystem _atmosphericFXSystem;
    private readonly List<Collider> _tempAllPartColliders;
    private VesselAudio _vesselAudio;
    public Transform ControlTransform;

    public VesselComponent Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IEnumerable<PartBehavior> parts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartOwnerBehavior PartOwner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartBehavior PartWithGroundContact
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public System.Type ModelType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public FlightCtrlState flightCtrlState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselAutopilot Autopilot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public SuspensionLoadBalancer SuspensionBalancer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public CollisionManager CollisionManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public AtmosphericFxSystem AtmosphericFxSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public BoundingSphere BoundingSphere
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Bounds BoundingBox
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event FlightInputCallback OnPreAutopilotUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event FlightInputCallback OnAutopilotUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event FlightInputCallback OnPostAutopilotUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event FlightInputCallback OnFlyByWire
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(VesselComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CollectAllPartColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateBoundingShapesIfDirty(bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUniverseTimeScaleChanged(TimeScaleValues timeScaleValues) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsVesselAtRest() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsWithinUnpackRange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsUnpacked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsChildOfPhysicsReferenceTransform(Transform transformToCheck) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTransformParentChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFrameSnapEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselPrelaunchData GetVesselPrelaunchData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void OnUpdate_AutoPilotMethods(ref FlightCtrlState ctrlState, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FlightControlStateInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnModelPhysicsChanged(PhysicsMode newPhysicsMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RenameVessel() => throw null;

    [ContextMenu("Reset SAS")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetSAS() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Debug_SetPhysicsMode(
      PhysicsMode vesselPhysics,
      bool isPhysXEnabled,
      bool isUnpacked)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetPhysicsMode(PhysicsMode vesselPhysics, bool isPhysXEnabled, bool isUnpacked) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckSetLanded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LandedSituationChanged(bool from, bool to) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePartWithGroundContact() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSasPIDs(Vector4d Pitch, Vector4d Roll, Vector4d Yaw) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckIfVesselIsBraking() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCollisionEnter(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCollisionExit(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCollisionStay(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void HandleCollisionEnter(CollisionDetails collisionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionEnter(Collision c) => throw null;

    private bool IsNoCrashDamageEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void HandleCollisionExit(CollisionDetails collisionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionExit(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void HandleCollisionStay(CollisionDetails collisionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionStay(Collision c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionEnterInternal(Vector3 relativeVelocity, bool isSurvivable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionExitInternal(int collisionLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleCollisionStayInternal(int collisionLayer, bool isOceanImpact) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private CollisionDetails BuildCollisionDetails(
      CollisionDetails.CollisionEventType collisionEventType,
      Collider impactedCollider,
      Vector3 relativeVelocity,
      Vector3 contactPoint,
      Vector3 contactNormal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsOceanImpact(Collider collider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsSurvivableCrash(Collider otherCollider, Vector3 relativeVelocity) => throw null;

    private float AverageCrashToleranace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleExplosionEffect(Collider collider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ValidateCreateControlTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLocalControlTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnControlPointChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselControlOwnerChangedMessage(MessageCenterMessage msg) => throw null;

    [ContextMenu("PhysX - Packed")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugForcePackVessel() => throw null;

    [ContextMenu("PhysX - Unpacked")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugForceUnpackVessel() => throw null;

    [ContextMenu("Model Stop Physics")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugForceStopVesselPhysX() => throw null;

    [ContextMenu("Model Orbital")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugForceOrbital() => throw null;

    [ContextMenu("Model At Rest")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugForceAtRest() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselBehavior() => throw null;

    [Serializable]
    private struct PhysicsState
    {
      public bool IsTimeWarpEnabled;
      public PhysicsMode PreTimeWarpPhysicsMode;
    }

    private enum PackState
    {
      Stopped,
      Packed,
      Unpacked,
    }
  }
}
