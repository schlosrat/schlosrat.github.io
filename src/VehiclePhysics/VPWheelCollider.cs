// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPWheelCollider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using EdyCommonTools;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [AddComponentMenu("Vehicle Physics/Wheel Collider", -20)]
  [DisallowMultipleComponent]
  public class VPWheelCollider : VehicleBehaviour
  {
    public float mass;
    public float radius;
    public Vector3 center;
    [Range(0.01f, 2f)]
    public float suspensionDistance;
    [Range(0.0f, 1f)]
    public float suspensionAnchor;
    public float springRate;
    public float damperRate;
    public Transform suspensionTransform;
    public Transform caliperTransform;
    public Transform wheelTransform;
    [Range(0.0f, 0.2f)]
    public float groundPenetration;
    public bool disableSuspensionMovement;
    public bool hideWheelOnDisable;
    public MathUtility.Axis localSteeringAxis;
    public MathUtility.Axis localSpinAxis;
    public static float minSuspensionDistance;
    public static float scaleFactor;
    private Transform m_transform;
    private Rigidbody m_rigidbody;
    private Transform m_rigidbodyTransform;
    private RaycastHit m_visualHit;
    private ColliderUtility.LayerCollisionMatrix m_collisionMatrix;
    private WheelCollider m_wheelCollider;
    private bool m_sprungMassFix;
    private JointSpring m_suspension;
    private float m_steerAngle;
    private float m_angularPosition;
    private float m_contactDistance;
    private Vector3 m_suspensionPosition;
    private InterpolatedAngle m_visualSteerAngle;
    private bool m_isCaliperChildOfSuspension;
    private bool m_isWheelChildOfSuspension;
    private bool m_isWheelChildOfCaliper;
    private Transform m_originalCaliper;
    private Transform m_originalWheel;
    private Quaternion m_originalWheelRotation;
    private Quaternion m_originalCaliperRotation;
    private Vector3 m_localSteeringAxis;
    private Vector3 m_localSpinAxis;
    private float m_2PI;
    public int layerMask;
    internal bool debugForces;
    internal float springSlerpRate;
    public bool updateSuspension;
    public bool updateCaliper;
    public bool updateWheel;
    public float suspensionOffset;

    public bool hidden
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnValidate() => throw null;

    public Transform cachedTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Transform rigidbodyTransform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool visualGrounded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RaycastHit visualHit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float steerAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float angularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float angularPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool canSleep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float effectiveSpringRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float runtimeSpringRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float runtimeDamperRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float lastRuntimeSpringRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float lastRuntimeDamperRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float runtimeExtraSuspensionForce
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [Obsolete("runtimeSuspensionTravel has been deprecated, has no effect and will be removed. Use suspensionDistance instead. Note that changes to VPWheelCollider.suspensionDistance are permanent! Making temporary modifications requires storing the original value.")]
    public float runtimeSuspensionTravel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [Obsolete("lastRuntimeSuspensionTravel has been deprecated and will be removed. Please use suspensionDistance instead.")]
    public float lastRuntimeSuspensionTravel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetUpdateOrder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVisualWheel(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSuspensionForceOffset(float offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetGroundHit(out WheelHit hit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetContactDepth(Vector3 contactPoint) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetContactLimit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetTangentVelocity(
      Vector3 contactPoint,
      Vector3 surfaceNormal,
      Rigidbody surfaceRigidbody)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyForce(Vector3 force, Vector3 position, Rigidbody otherRb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WheelCollider GetWheelCollider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WheelCollider ResetWheelCollider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private WheelCollider SetupWheelCollider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void UpdateWheelCollider(WheelCollider wheelCol) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float FixSteerAngle(float inputSteerAngle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Transform GetRigidbodyTransform() => throw null;

    [ContextMenu("Adjust position and radius to the Wheel mesh")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AdjustToWheelMesh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds GetScaledBounds(MeshFilter meshFilter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmosSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPWheelCollider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VPWheelCollider() => throw null;
  }
}
