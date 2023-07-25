// Decompiled with JetBrains decompiler
// Type: PA.ParticleField.Samples.PlayerMovement
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace PA.ParticleField.Samples
{
  public class PlayerMovement : MonoBehaviour
  {
    public bool canControl;
    public bool useFixedUpdate;
    [NonSerialized]
    public Vector3 inputMoveDirection;
    [NonSerialized]
    public bool inputJump;
    [SerializeField]
    private PlayerMovement.CharacterMotorMovement movement;
    [SerializeField]
    private PlayerMovement.CharacterMotorJumping jumping;
    [SerializeField]
    private PlayerMovement.CharacterMotorMovingPlatform movingPlatform;
    [SerializeField]
    private PlayerMovement.CharacterMotorSliding sliding;
    [NonSerialized]
    private bool grounded;
    [NonSerialized]
    private Vector3 groundNormal;
    private Vector3 lastGroundNormal;
    private Transform tr;
    private CharacterController controller;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateFunction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 ApplyInputVelocityChange(Vector3 velocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 ApplyGravityAndJumping(Vector3 velocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnControllerColliderHit(ControllerColliderHit hit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator SubtractNewPlatformVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool MoveWithPlatform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetDesiredHorizontalVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 AdjustGroundVelocityToNormal(Vector3 hVelocity, Vector3 groundNormal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsGroundedTest() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetMaxAcceleration(bool grounded) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateJumpVerticalSpeed(float targetJumpHeight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsJumping() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsSliding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsTouchingCeiling() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsGrounded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TooSteep() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetDirection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetControllable(bool controllable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float MaxSpeedInDirection(Vector3 desiredMovementDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetVelocity(Vector3 velocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlayerMovement() => throw null;

    [Serializable]
    private class CharacterMotorMovement
    {
      public float maxForwardSpeed;
      public float maxSidewaysSpeed;
      public float maxBackwardsSpeed;
      public AnimationCurve slopeSpeedMultiplier;
      public float maxGroundAcceleration;
      public float maxAirAcceleration;
      public float gravity;
      public float maxFallSpeed;
      [NonSerialized]
      public CollisionFlags collisionFlags;
      [NonSerialized]
      public Vector3 velocity;
      [NonSerialized]
      public Vector3 frameVelocity;
      [NonSerialized]
      public Vector3 hitPoint;
      [NonSerialized]
      public Vector3 lastHitPoint;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CharacterMotorMovement() => throw null;
    }

    private enum MovementTransferOnJump
    {
      None,
      InitTransfer,
      PermaTransfer,
      PermaLocked,
    }

    [Serializable]
    private class CharacterMotorJumping
    {
      public bool enabled;
      public float baseHeight;
      public float extraHeight;
      public float perpAmount;
      public float steepPerpAmount;
      [NonSerialized]
      public bool jumping;
      [NonSerialized]
      public bool holdingJumpButton;
      [NonSerialized]
      public float lastStartTime;
      [NonSerialized]
      public float lastButtonDownTime;
      [NonSerialized]
      public Vector3 jumpDir;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CharacterMotorJumping() => throw null;
    }

    [Serializable]
    private class CharacterMotorMovingPlatform
    {
      public bool enabled;
      public PlayerMovement.MovementTransferOnJump movementTransfer;
      [NonSerialized]
      public Transform hitPlatform;
      [NonSerialized]
      public Transform activePlatform;
      [NonSerialized]
      public Vector3 activeLocalPoint;
      [NonSerialized]
      public Vector3 activeGlobalPoint;
      [NonSerialized]
      public Quaternion activeLocalRotation;
      [NonSerialized]
      public Quaternion activeGlobalRotation;
      [NonSerialized]
      public Matrix4x4 lastMatrix;
      [NonSerialized]
      public Vector3 platformVelocity;
      [NonSerialized]
      public bool newPlatform;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CharacterMotorMovingPlatform() => throw null;
    }

    [Serializable]
    private class CharacterMotorSliding
    {
      public bool enabled;
      public float slidingSpeed;
      public float sidewaysControl;
      public float speedControl;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CharacterMotorSliding() => throw null;
    }
  }
}
