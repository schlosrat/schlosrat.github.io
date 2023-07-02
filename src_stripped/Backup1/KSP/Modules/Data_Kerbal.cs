// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_Kerbal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public sealed class Data_Kerbal : ModuleData
  {
    [Header("Jetpack")]
    [KSPDefinition]
    public bool IsJetpackEquipped;
    [KSPDefinition]
    [Tooltip("How much Move force in kN the Jetpack produces at 100% throttle at atmospheric pressure of 0.")]
    public float JetpackMoveForce;
    [Tooltip("How much Rotate torque in kN.m the Jetpack produces at 100% throttle at atmospheric pressure of 0.")]
    [KSPDefinition]
    public float JetpackRotateTorque;
    [Tooltip("Max Speed in degrees per second at which Jetpack Rotate Torque can accelerate the angular velocity to, when Rotate input is being applied.")]
    [KSPDefinition]
    public float JetpackRotateMaxAngularSpeed;
    [KSPDefinition]
    [Tooltip("Whether Jetpack Rotate Reset is enabled. If enabled, the Jetpack will automatically try to stop rotation, gradually, when no rotate input is pressed.")]
    public bool JetpackRotateResetEnabled;
    [KSPDefinition]
    [Tooltip("Speed in degrees per second above which Jetpack Rotate Reset kicks in.")]
    public float JetpackRotateResetAngularSpeedThreshold;
    [KSPDefinition]
    [Tooltip("Speed in degrees per second at which Jetpack Rotate gradually settles to zero angular velocity, when no Rotate input is being applied.")]
    public float JetpackRotateResetAngularSpeed;
    [KSPDefinition]
    [Tooltip("Whether Jetpack Align to Camera is enabled. If enabled Rotate Input is applied to align the Character direction to Camera direction. Uses Jetpack Rotate Torque thrusts for said alignment. Occurs when Jetpack In-Use while falling.")]
    public bool JetpackAlignToCameraEnabled;
    [Tooltip("Angle in degrees about Camera direction to align Character direction to Camera direction, above which the Align to Camera feature kicks in.")]
    [KSPDefinition]
    public float JetpackAlignToCameraMinAngle;
    [KSPDefinition]
    [Tooltip("Angle in degrees about Camera direction to align Character direction to Camera direction, at and above which the Align to Camera feature will provide JetpackAlignToCameraMaxRotateInput input delta. Reduce this angle to make things feel snappier.")]
    public float JetpackAlignToCameraMaxAngle;
    [KSPDefinition]
    [Tooltip("Minimum normalized value [0, 1] to apply as Rotate Input to align Character direction to Camera direction. This will be multiplied by the PAM JetpackThrustForcePercentage to affect the Rotate Torque accordingly.")]
    public float JetpackAlignToCameraMinRotateInput;
    [KSPDefinition]
    [Tooltip("Maximum normalized value [0, 1] to apply as Rotate Input to align Character direction to Camera direction. This will be multiplied by the PAM JetpackThrustForcePercentage to affect the Rotate Torque accordingly.")]
    public float JetpackAlignToCameraMaxRotateInput;
    [Tooltip("The local-space offset, applied to each coordinate axis, at which Move forces are applied. This offset is from the object CoM.")]
    [KSPDefinition]
    public double JetpackMoveForceOffset;
    [Tooltip("The local-space offset, applied to each coordinate axis, at which Rotate torques are applied.")]
    [KSPDefinition]
    public double JetpackRotateTorqueOffset;
    [Tooltip("Rigidbody Drag scalar to apply when the Jetpack is thrusting in a liquid or underwater. Use this to tune ease of thrusting while underwater.")]
    [KSPDefinition]
    public double JetpackThrustLiquidDragScalar;
    [KSPDefinition]
    [Tooltip("Rigidbody Angular Drag scalar to apply when the Jetpack is thrusting in a liquid or underwater. Use this to tune ease of thrusting while underwater.")]
    public double JetpackThrustLiquidAngularDragScalar;
    [Tooltip("Propellant that the Jetpack consumes while running.")]
    [KSPDefinition]
    public PropellantDefinition JetpackPropellantDefinition;
    [JsonIgnore]
    [HideInInspector]
    public PropellantState JetpackForcePropellantState;
    [JsonIgnore]
    [HideInInspector]
    public PropellantState JetpackTorquePropellantState;
    [Tooltip("A curve to determine loss or gain of thrust due to changes in atmosphere vs vacuum values are based on ISP to ATM Pressure.")]
    [KSPDefinition]
    public FloatCurve JetpackAtmosphereCurve;
    [KSPState]
    [HideInInspector]
    public Data_Kerbal.JetpackStatus JetpackStatusType;
    [KSPState]
    [LocalizedField("PartModules/Kerbals/Jetpack/Status")]
    [PAMDisplayControl(SortIndex = 1)]
    [HideInInspector]
    public ModuleProperty<string> JetpackStatusText;
    [LocalizedField("PartModules/Kerbals/Jetpack/ISP")]
    [KSPState]
    [PAMDisplayControl(SortIndex = 2)]
    [HideInInspector]
    public ModuleProperty<float> JetpackISP;
    [LocalizedField("PartModules/Kerbals/Jetpack/ThrustForcePercentage")]
    [HideInInspector]
    [PAMDisplayControl(SortIndex = 3)]
    [KSPState]
    [SteppedRange(0.0f, 100f, 1f)]
    public ModuleProperty<float> JetpackThrustForcePercentage;
    [Header("Walk/Run")]
    [KSPDefinition]
    [Tooltip("Walk Rotate angular speed in degrees per second.")]
    public float WalkRotateAngularSpeed;
    [Tooltip("Walk Rotate change angular speed in degrees per second. I.e., how quickly it approaches the Angular Speed.")]
    [KSPDefinition]
    public float WalkRotateChangeAngularSpeed;
    [KSPDefinition]
    [Tooltip("Walk Move speed in meters per second. This is the gameplay facing speed. Once the other animation speed field is tuned correctly, you can increase or decrease this value freely without foot sliding.")]
    public float WalkMoveSpeed;
    [KSPDefinition]
    [Tooltip("Walk Move Animation speed in meters per second. This animator provided value will be used to avoid foot sliding, when applying the gameplay facing speed. If you do not know what this value should be, and don't mind foot sliding temporarily, keep it at 0.")]
    public float WalkMoveAnimationSpeed;
    [KSPDefinition]
    [Tooltip("Walk Move Strafe speed in meters per second. This is the gameplay facing speed. Once the other animation speed field is tuned correctly, you can increase or decrease this value freely without foot sliding.")]
    public float WalkMoveStrafeSpeed;
    [KSPDefinition]
    [Tooltip("Walk Move Strafe Animation speed in meters per second. This animator provided value will be used to avoid foot sliding, when applying the gameplay facing speed. If you do not know what this value should be, and don't mind foot sliding temporarily, keep it at 0.")]
    public float WalkMoveStrafeAnimationSpeed;
    [Tooltip("Run Move speed in meters per second. This is the gameplay facing speed. Once the other animation speed field is tuned correctly, you can increase or decrease this value freely without foot sliding.")]
    [KSPDefinition]
    public float RunMoveSpeed;
    [Tooltip("Run Move Animation speed in meters per second. This animator provided value will be used to avoid foot sliding, when applying the gameplay facing speed. If you do not know what this value should be, and don't mind foot sliding temporarily, keep it at 0.")]
    [KSPDefinition]
    public float RunMoveAnimationSpeed;
    [Tooltip("Run Rotate angular speed in degrees per second.")]
    [KSPDefinition]
    public float RunRotateAngularSpeed;
    [Tooltip("Run Rotate change angular speed in degrees per second. I.e., how quickly it approaches the Angular Speed.")]
    [KSPDefinition]
    public float RunRotateChangeAngularSpeed;
    [KSPDefinition]
    [Tooltip("Angle in degrees within which the current direction to desired direction angle needs to be for the alignment to be considered complete.")]
    public float RotateDesiredDirectionEqualAngle;
    [Tooltip("Value multiplied by delta time to speed up/slow down the lerp between normal movement and running/sprinting")]
    [KSPDefinition]
    public float NormalToSprintLerpSpeed;
    [Tooltip("Minimum angle in degrees above which we consider the Camera upside down and flip move left and move right directions. This is the angle between the following directions: [GroundContactNormal], [CameraUp].")]
    [KSPDefinition]
    public float MoveCameraUpFlipMinAngle;
    [Tooltip("Equal and opposite angle in degrees under which we rotate the camera-relative move input direction by 90 degrees to improve the player's navigation experience, and also to prevent cross product from approaching zero magnitude, which would have resulted in an invalid move input direction. This is the angle between the following directions: [MoveOnGroundDirection], [GroundContactNormal].")]
    [KSPDefinition]
    public float MoveDirectionRotateFallbackAngle;
    [Tooltip("Swim Slow Move speed in meters per second. This is the gameplay facing speed. Once the other animation speed field is tuned correctly, you can increase or decrease this value freely without sliding.")]
    [KSPDefinition]
    [Header("Swim")]
    public float SwimSlowMoveSpeed;
    [Tooltip("Swim Slow Move Animation speed in meters per second. This animator provided value will be used to avoid sliding, when applying the gameplay facing speed. If you do not know what this value should be, and don't mind sliding temporarily, keep it at 0.")]
    [KSPDefinition]
    public float SwimSlowMoveAnimationSpeed;
    [Tooltip("Magnitude of SwimSlowMove Force in kN. Where, X-axis: GravityMultiplier; Y-axis: ForceMagnitude.")]
    [KSPDefinition]
    public FloatCurve SwimSlowMoveForceCurve;
    [Tooltip("Swim Slow Rotate speed in degrees per second.")]
    public float SwimSlowRotateSpeed;
    [KSPDefinition]
    [Tooltip("The local-space offset, applied to each coordinate axis, at which Swim Move force is applied. This offset is from the object CoM.")]
    public double SwimMoveForceOffset;
    [KSPDefinition]
    [Tooltip("Swim Fast Move speed in meters per second. This is the gameplay facing speed. Once the other animation speed field is tuned correctly, you can increase or decrease this value freely without sliding.")]
    public float SwimFastMoveSpeed;
    [KSPDefinition]
    [Tooltip("Swim Fast Move Animation speed in meters per second. This animator provided value will be used to avoid sliding, when applying the gameplay facing speed. If you do not know what this value should be, and don't mind sliding temporarily, keep it at 0.")]
    public float SwimFastMoveAnimationSpeed;
    [Tooltip("Magnitude multiplier of SwimSlowMove Force that is applied when the Character is swimming and they have the run input pressed.")]
    [KSPDefinition]
    public double SwimFastMoveForceMagnitudeMultiplier;
    [Tooltip("Swim Fast Rotate speed in degrees per second.")]
    [KSPDefinition]
    public float SwimFastRotateSpeed;
    [KSPDefinition]
    [Tooltip("Swim Up offset from the Swim Surface to help determine target position to float to. Use this if the character's origin is at their feet and we want floating position should be offset downwards.")]
    public float SwimFloatSurfaceUpOffset;
    [Tooltip("Minimum depth in meters for the Character to be in the Swim state.")]
    [KSPDefinition]
    public float SwimMinDepth;
    [Tooltip("How high up in meters from character pivot upwards along HorizonUp should the Ground spherecast originate from. This physics spherecast is responsible for ground detection.")]
    [KSPDefinition]
    [Header("Ground")]
    public float GroundSpherecastUpOffset;
    [KSPDefinition]
    [Tooltip("Length in meters of the physics spherecast of the 'In the Present' Ground spherecast. This physics spherecast occurs downwards opposite to HorizonUp, is positioned such that it is not offset by the move input direction.")]
    public float GroundSpherecastPresentLength;
    [Tooltip("Radius in meters of the physics spherecast of the 'In the Present' Ground spherecast. This physics spherecast occurs downwards opposite to HorizonUp, is positioned such that it is not offset by the move input direction.")]
    [KSPDefinition]
    public float GroundSpherecastPresentRadius;
    [KSPDefinition]
    [Tooltip("Length in meters of the physics spherecast of the 'In the Future' Ground spherecast. This physics spherecast occurs downwards opposite to HorizonUp, is positioned such that it is offset by a fixed amount along the move input direction.")]
    public float GroundSpherecastFutureLength;
    [KSPDefinition]
    [Tooltip("Radius in meters of the physics spherecast of the 'In the Future' Ground spherecast. This physics spherecast occurs downwards opposite to HorizonUp, is positioned such that it is offset by a fixed amount along the move input direction.")]
    public float GroundSpherecastFutureRadius;
    [Tooltip("Offset in meters along the character velocity direction during character movement that the 'In the Future' Ground spherecast downwards opposite to HorizonUp is positioned.")]
    [KSPDefinition]
    public float GroundSpherecastFutureMoveOffset;
    [Tooltip("Altitude above both Sea Level and Ground Level the character needs to be to be considered Above High Altitude or In-Orbit.")]
    [KSPDefinition]
    public float GroundAndSeaHighAltitude;
    [Tooltip("Max angle in degrees up to which Move velocity is applied along the Slope incline. This is the max allowed angle between the following directions: [GroundContactNormal], [HorizonUp].")]
    [Header("Slope")]
    [KSPDefinition]
    public float SlopeMoveGroundMaxAngle;
    [KSPDefinition]
    [Tooltip("Angle in degrees under which Move Up Slope is detected. This is the angle between the following directions: [HorizonUp], [MoveOnGroundDirection].")]
    public float SlopeMoveUpDetectAngle;
    [Header("Upright")]
    [KSPDefinition]
    [Tooltip("Upright Rotate correction angular speed in degrees per second.")]
    public float UprightRotateAngularSpeed;
    [Tooltip("Upright Rotate correction change angular speed in degrees per second. I.e., how quickly it approaches the Angular Speed.")]
    [KSPDefinition]
    public float UprightRotateChangeAngularSpeed;
    [Tooltip("Magnitude of Jump Force that is continually applied during the Initial and Extend sub-states of Jump, if sub-state conditions are met. Where, X-axis: GravityMultiplier; Y-axis: ForceMagnitude.")]
    [Header("Jump")]
    [KSPDefinition]
    public FloatCurve JumpForceMagnitudeCurve;
    [Tooltip("Magnitude multiplier of Jump Force that is applied when the Character is running when they press the Jump input.")]
    [KSPDefinition]
    public float JumpRunMoveForceMagnitudeMultiplier;
    [Tooltip("When Jump is triggered during move, the angle in degrees by which to rotate the move input direction upwards in Character local-space. This helps make the Character jump in some angled move direction when moving, as opposed to jumping straight up when stationary.")]
    [KSPDefinition]
    public float JumpMoveAngle;
    [Tooltip("Minimum duration in seconds for which the Jumping CharacterState should be true. The time starts the moment the 'DoJumpImpulse' Animation Event is received.")]
    [KSPDefinition]
    public float JumpMinStateDuration;
    [KSPDefinition]
    [Tooltip("Maximum duration in seconds for which the Jumping CharacterState should be true. The time starts the moment the Jump Handler starts.")]
    public float JumpMaxStateDuration;
    [Tooltip("Duration in seconds over which the Jump force is applied during the Initial sub-state of Jump.")]
    [KSPDefinition]
    public float JumpInitialForceDuration;
    [KSPDefinition]
    [Tooltip("Duration in seconds over which the Jump force is applied during the Extend sub-state of Jump.")]
    public float JumpExtendForceDuration;
    [Tooltip("Jump Rotate angular speed in degrees per second. This is used to align the character's forward direction to the jump direction, when not strafing.")]
    [KSPDefinition]
    public float JumpRotateAngularSpeed;
    [Tooltip("Jump Rotate change angular speed in degrees per second. I.e., how quickly it approaches the Angular Speed. This is used to align the character's forward direction to the jump direction, when not strafing.")]
    [KSPDefinition]
    public float JumpRotateChangeAngularSpeed;
    [Tooltip("Local position offset added when instantiating the flag prefab.")]
    [KSPDefinition]
    [Header("Flag")]
    public Vector3d FlagLocalPositionOffset;
    [Tooltip("Whether EVA and Flight Interact inputs be disabled while the plant flag animation is playing.")]
    [KSPDefinition]
    public bool DisableEVAAndFlightInteractInputs;
    [KSPDefinition]
    [Header("Climb")]
    [Tooltip("Duration in seconds to dock the Kerbal to the Ladder when Climb is started. I.e., the duration of the StartClimbDock sub-state of Climb.")]
    public float ClimbStartDockDuration;
    [Tooltip("Duration in seconds to dock the Kerbal to the Ladder when Climb is stopped. I.e., the duration of the StopClimbUndock sub-state of Climb.")]
    [KSPDefinition]
    public float ClimbStopDockDuration;
    [Tooltip("Radius of the character's Capsule Collider when they are in the Climb CharacterStateHandler.")]
    [KSPDefinition]
    public float ClimbCapsuleRadius;
    [KSPDefinition]
    [Tooltip("Height of the character's Capsule Collider when they are in the Climb CharacterStateHandler.")]
    public float ClimbCapsuleHeight;
    [KSPDefinition]
    [Tooltip("Climb Move speed in meters per second. This is the gameplay facing speed. Once the other animation speed field is tuned correctly, you can increase or decrease this value freely without foot/hand sliding.")]
    public float ClimbMoveSpeed;
    [Tooltip("Climb Move Animation speed in meters per second. This animator provided value will be used to avoid foot sliding, when applying the gameplay facing speed. If you do not know what this value should be, and don't mind foot/hand sliding temporarily, keep it at 0.")]
    [KSPDefinition]
    public float ClimbMoveAnimationSpeed;
    [KSPDefinition]
    [Tooltip("Minimum height of a climbable object. Applies to very small Ladders where the climbable surface is too small compared to the character capsule dimensions. We still want the player to experience climbing height adjustments as they provide input for these small climbable objects.")]
    public float ClimbMinObjectHeight;
    [Header("Step Clamber")]
    [KSPDefinition]
    [Tooltip("Minimum height for Step detection. A detected step must be above this height to be considered a valid Step. Valid Steps will show an Interact which performs a Step Clamber on use.")]
    public float StepMinHeight;
    [Tooltip("Maximum height for Step detection. A detected step must be below this height to be considered a valid Step. Valid Steps will show an Interact which performs a Step Clamber on use.")]
    [KSPDefinition]
    public float StepMaxHeight;
    [Tooltip("Max angle in degrees up to which a contact found by Step 'Top' detection is considered valid. This is the max allowed angle between the following directions: [StepTopContactNormal], [HorizonUp].")]
    [KSPDefinition]
    public float StepTopMaxAngle;
    [KSPDefinition]
    [Tooltip("Distance offset along Character Forward in meters to help determine the Step 'Top' physics raycast position. The physics raycast direction will be downwards opposite to Character Up.")]
    public float StepTopRaycastForwardOffset;
    [KSPDefinition]
    [Tooltip("Distance offset along Character Up in meters to help determine the Step 'Top' physics raycast position. The physics raycast direction will be downwards opposite to Character Up.")]
    public float StepTopRaycastUpOffset;
    [KSPDefinition]
    [Tooltip("Length in meters of the physics raycast of the Step 'Top' physics raycast. The physics raycast direction will be downwards opposite to Character Up.")]
    public float StepTopRaycastLength;
    [KSPDefinition]
    [Tooltip("Distance offset along Character Forward in meters to help determine the Step 'Front' physics raycast position. The physics raycast direction will be the Character Forward.")]
    public float StepFrontRaycastForwardOffset;
    [KSPDefinition]
    [Tooltip("Distance offset along Character Up in meters to help determine the Step 'Front' physics raycast position. The physics raycast direction will be the Character Forward.")]
    public float StepFrontRaycastUpOffset;
    [KSPDefinition]
    [Tooltip("Length in meters of the physics raycast of the Step 'Front' physics raycast. The physics raycast direction will be the Character Forward.")]
    public float StepFrontRaycastLength;
    [Tooltip("Distance offset along Character Forward in meters to help determine the Step 'Unobstructed' physics raycast position. The physics raycast direction will be the Character Forward.")]
    [KSPDefinition]
    public float StepUnobstructedRaycastForwardOffset;
    [KSPDefinition]
    [Tooltip("Distance offset along Character Up in meters to help determine the Step 'Unobstructed' physics raycast position. The physics raycast direction will be the Character Forward.")]
    public float StepUnobstructedRaycastUpOffset;
    [KSPDefinition]
    [Tooltip("Length in meters of the physics raycast of the Step 'Unobstructed' physics raycast. The physics raycast direction will be the Character Forward.")]
    public float StepUnobstructedRaycastLength;
    [KSPDefinition]
    [Tooltip("Percentage as normalized [0, 1] for the interpolation value at which we reach the Step's Height in the Character Up direction only, before proceeding in the Character Forward direction to reach the final valid Step 'Top' position thereafter. E.g., Choose a percentage somewhere in the middle to break apart this up-to-forward motion relatively evenly.")]
    public float StepClamberHeightInterpValue;
    [KSPDefinition]
    [Tooltip("Duration in seconds to dock the Kerbal to the valid Step 'Top' position. I.e., the duration of the ClamberingSubState sub-state of Climb for Step clambering, specifically.")]
    public float StepClamberDuration;
    [Header("Ladder Top Clamber")]
    [KSPDefinition]
    [Tooltip("Maximum height for Ladder 'Top' platform detection, by repurposing the Step detection system with different data. A detected height must be below this height to be considered a valid Ladder Top. Valid Ladder Top will show an Interact which performs a Ladder Top Clamber to the platform on use.")]
    public float LadderTopMaxHeight;
    [KSPDefinition]
    [Tooltip("Max angle in degrees up to which a contact found by Step 'Top' detection is considered valid, for Ladder Top Clamber purposes. This is the max allowed angle between the following directions: [StepTopContactNormal], [CharacterUp].")]
    public float LadderTopMaxAngle;
    [Tooltip("Distance offset along Character Forward in meters to help determine the Step 'Top' physics raycast position, for Ladder Top Clamber purposes. The physics raycast direction will be downwards opposite to Character Up, and originates from Character position before Forward and Up offsets are applied.")]
    [KSPDefinition]
    public float LadderTopRaycastForwardOffset;
    [KSPDefinition]
    [Tooltip("Distance offset along Character Up in meters to help determine the Step 'Top' physics raycast position, for Ladder Top Clamber purposes. The physics raycast direction will be downwards opposite to Character Up, and originates from Character position before Forward and Up offsets are applied.")]
    public float LadderTopRaycastUpOffset;
    [KSPDefinition]
    [Tooltip("Length in meters of the physics raycast of the Step 'Top' physics raycast, for Ladder Top Clamber purposes. The physics raycast direction will be downwards opposite to Character Up, and originates from Character position before Forward and Up offsets are applied.")]
    public float LadderTopRaycastLength;
    [KSPDefinition]
    [Tooltip("Distance offset along Character Forward in meters to help determine the Step 'Unobstructed' physics raycast position, for Ladder Top Clamber purposes. The physics raycast direction will be the Character Forward, and originates from CharacterCapsuleBottomPos position before Forward and Up offsets are applied.")]
    public float LadderUnobstructedRaycastForwardOffset;
    [KSPDefinition]
    [Tooltip("Distance offset along Character Up in meters to help determine the Step 'Unobstructed' physics raycast position, for Ladder Top Clamber purposes. The physics raycast direction will be the Character Forward, and originates from CharacterCapsuleBottomPos position before Forward and Up offsets are applied.")]
    public float LadderUnobstructedRaycastUpOffset;
    [KSPDefinition]
    [Tooltip("Length in meters of the physics raycast of the Step 'Unobstructed' physics raycast, for Ladder Top Clamber purposes. The physics raycast direction will be the Character Forward, and originates from CharacterCapsuleBottomPos position before Forward and Up offsets are applied.")]
    public float LadderUnobstructedRaycastLength;
    [KSPDefinition]
    [Tooltip("Percentage as normalized [0, 1] for the interpolation value at which we reach the Step's Height in the Character Up direction only, for Ladder Top Clamber purposes, before proceeding in the Character Forward direction to reach the final valid Step 'Top' position thereafter. E.g., Choose a percentage somewhere in the middle to break apart this up-to-forward motion relatively evenly.")]
    public float LadderTopClamberHeightInterpValue;
    [Tooltip("Duration in seconds of the delay before the clamber. I.e., the duration of a delay within the ClamberingSubState sub-state of Climb for Ladder Top clambering, specifically. Use this when a custom Climb to Clamber animation transition doesn't exist.")]
    [KSPDefinition]
    public float LadderTopClamberDelayDuration;
    [Tooltip("Duration in seconds to dock the Kerbal to the valid Step 'Top' position. I.e., the duration of the ClamberingSubState sub-state of Climb for Ladder Top clambering, specifically.")]
    [KSPDefinition]
    public float LadderTopClamberDuration;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetWalkMovePlaybackMultiplier() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetWalkMoveStrafePlaybackMultiplier() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRunMovePlaybackMultiplier() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSwimSlowMovePlaybackMultiplier() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSwimFastMovePlaybackMultiplier() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetClimbMovePlaybackMultiplier() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static string GetTimeString(object valueObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_Kerbal() => throw null;

    public enum JetpackStatus : byte
    {
      [Description("PartModules/Kerbals/Jetpack/Status/Off")] Off,
      [Description("PartModules/Kerbals/Jetpack/Status/Thrusting")] Thrusting,
      [Description("PartModules/Kerbals/Jetpack/Status/ResourceDeprived")] ResourceDeprived,
    }
  }
}
