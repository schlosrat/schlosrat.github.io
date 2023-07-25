// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.KerbalBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Animation;
using KSP.Game;
using KSP.Messages;
using KSP.Modules;
using KSP.Sim.Definitions;
using KSP.Utilities;
using KSP.VFX;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace KSP.Sim.impl
{
  public class KerbalBehavior : 
    ViewObjectComponent<KerbalComponent>,
    IFixedUpdate,
    IUpdate,
    ILateUpdate,
    IPriorityOverride
  {
    public static readonly LayerMask PhysicsCastLayerMask;
    private const float GRAVITY_EPSILON = 0.001f;
    private const float JETPACK_TOGGLE_BLOCKED_TIMER_DURATION = 2f;
    public KerbalCharacterState CharacterState;
    public EVAKerbalAnimationState EVAAnimationState;
    [HideInInspector]
    public Vector3 HorizonUp;
    [HideInInspector]
    public Vector3 CharacterCapsuleBottomPos;
    [HideInInspector]
    public Vector3 GroundPresentContactNormalSmoothed;
    [HideInInspector]
    public Vector3 GroundFutureContactNormal;
    [HideInInspector]
    public Vector3 GroundPresentFutureContactNormalAverage;
    [HideInInspector]
    public Vector3 LastMoveOnGroundWorldSpace;
    [HideInInspector]
    public Vector3 LastMoveBestUpSurfaceWorldSpace;
    [HideInInspector]
    public Vector3 RotateUprightAngularVelocity;
    [HideInInspector]
    public Vector3 RotateForwardAngularVelocity;
    [HideInInspector]
    public Vector3 RotateJetpackAngularVelocity;
    [HideInInspector]
    public float GravityMultiplier;
    [HideInInspector]
    public float DefaultCapsuleColliderRadius;
    [HideInInspector]
    public float DefaultCapsuleColliderHeight;
    [HideInInspector]
    public bool ForceUpdateFallingRequested;
    [HideInInspector]
    public bool ForceUpdateUnderwaterRequested;
    private List<KerbalCharacterStateHandler> _locomotionHandlers;
    private List<KerbalCharacterStateHandler> _permanentHandlers;
    private StandKerbalCharacterStateHandler _standCharacterStateHandler;
    private MoveKerbalCharacterStateHandler _moveCharacterStateHandler;
    private JetpackKerbalCharacterStateHandler _jetpackCharacterStateHandler;
    private JumpKerbalCharacterStateHandler _jumpCharacterStateHandler;
    private ClimbKerbalCharacterStateHandler _climbCharacterStateHandler;
    private SwimKerbalCharacterStateHandler _swimCharacterStateHandler;
    private PlayAnimationKerbalCharacterStateHandler _playAnimationCharacterStateHandler;
    private GroundDetectKerbalCharacterStateHandler _groundDetectCharacterStateHandler;
    private StepDetectKerbalCharacterStateHandler _stepDetectCharacterStateHandler;
    private WaterDetectKerbalCharacterStateHandler _waterDetectCharacterStateHandler;
    private KerbalCharacterStateHandler _currentLocomotionHandler;
    private List<KerbalCharacterMessage> _queuedCharacterMessages;
    private List<AsyncOperationHandle<InteractPreset>> _loadedInteractPresetAsyncHandles;
    private Module_Kerbal _kerbalModule;
    private AnimationManager_EVA _evaAnimationManager;
    private JetpackVFXManager _evaJetpackVFXManager;
    private CapsuleCollider _capsuleCollider;
    private PartBehavior _mainPart;
    private KerbalCharacterStateHandlerType _characterCurrentLocomotionHandlerType;
    private Kerbal3DModel _kerbal3DModel;
    private SimpleTimer _jetpackToggleBlockedTimer;
    private float _rotateDesiredDirectionDotProductThreshold;
    private bool _isInitialized;
    private bool _isInteractPresetsLoadCompleted;
    private bool _toggleJetpackTriggered;
    private bool _isStrafeMode;
    private bool _isInputMovingStrafeOnly;
    private bool _isInputAllowed;
    private bool _isStaticFrictionActive;
    private bool _isPlantFlagAllowed;
    public Action<bool> OnPlantFlagAllowedChanged;

    public KerbalComponent Model
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AnimationManager_EVA EVAAnimationManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public JetpackVFXManager EVAJetpackVFXManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CollisionResult GroundPresentCollisionResult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CollisionResult GroundFutureCollisionResult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CollisionResult WaterCollisionResult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CapsuleCollider CharacterCapsuleCollider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartBehavior MainPart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public KerbalCharacterStateHandlerType CharacterCurrentLocomotionHandlerType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsStrafeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsInputMovingStrafeOnly
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsStaticFrictionActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RigidbodyBehavior KerbalRigidbodyBehavior
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Rigidbody KerbalRigidbody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Module_Kerbal KerbalModule
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private VesselComponent KerbalVesselComponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    int IPriorityOverride.ExecutionPriorityOverride
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SyncTo(KerbalComponent simObjectComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IFixedUpdate.OnFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ILateUpdate.OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TryPlantFlag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlantFlag(FlagComponentDefinition definition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsPlantFlagAllowed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryClimbLadderPartId(IGGuid ladderPartId, bool tweenTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGravityDisabled(bool disabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLadderUpPosOffsetSigned(float ladderUpPosOffsetSigned) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsTogglingJetpack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsToggleJetpackAllowed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnToggleJetpack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsInputAllowed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsOnGround() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsFallingAboveHighAltitude() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetBestUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessRotateForward(
      Vector3 desiredForward,
      float rotateAngularSpeed,
      float rotateChangeAngularSpeed,
      float deltaTime)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetRotateForward() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMovingInGroundPlane() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetWaterDetectPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetContactObjectRelativeVelocity(Vector3 velocity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ProcessCharacterStateFalling() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ProcessCharacterStateUnderwater() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateLocomotionHandlers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreatePermanentHandlers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool TryInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Initialize(PartBehavior mainKerbalPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializePartActionManagerProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeSubscribeMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeinitializeUnsubscribeMessages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeLocomotionHandlers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeinitializeLocomotionHandlers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializePermanentHandlers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeinitializePermanentHandlers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeRotateDesiredDotProduct() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeCapsuleColliderValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActivateLocomotionHandler(KerbalCharacterStateHandler handler) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool FindInteractFromLadderPartId(
      IGGuid ladderPartId,
      out InteractBehavior interactBehavior,
      out InteractInstance interactInstance,
      out InteractPreset interactPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ForceUpdateFallingAndUnderwater() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActivateBestLocomotionHandler() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessActivateNextLocomotionHandler() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateHorizonUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateCharacterCapsuleBottomPos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessInteractPresetsAsyncStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessGravity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessToggleJetpack(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessPlantFlagAllowed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessFixedUpdatePermanentHandlers(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessFixedUpdateLocomotionHandler(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessRotateUpright(bool shouldApplyUpright, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessStaticFriction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendMessage(KerbalCharacterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendMessageImmediate(KerbalCharacterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AcceptMessageStateHandlers(
      KerbalCharacterMessage message,
      List<KerbalCharacterStateHandler> handlers)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessQueuedMessagesStateHandlers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessUpdatePermanentHandlers(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessUpdateLocomotionHandler(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessLateUpdatePermanentHandlers(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessLateUpdateLocomotionHandler(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessAnimationState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrepareKerbal3DModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnsureJetpackInUseLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnKerbal3DModelCharacterCompletelyGenerated(string fullName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterInteractCallback(
      InteractPresetAssetReference interactPresetAssetReference,
      Action<InteractBehavior, InteractInstance, InteractPreset> interactOnUsedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadInteractPresetAsync(
      InteractPresetAssetReference interactPresetAssetReference)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadInteractPresetsAsync() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ReleaseLoadedInteractPresets() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInteractPresetsLoadCompleted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterInteractCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterInteractCallback(
      InteractPresetAssetReference interactPresetAssetReference,
      Action<InteractBehavior, InteractInstance, InteractPreset> interactOnUsedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterInteractCallbacks() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnsureLadderClimbCleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAirlockUsed(
      InteractBehavior interactBehavior,
      InteractInstance interactInstance,
      InteractPreset interactPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLadderStartClimbUsed(
      InteractBehavior interactBehavior,
      InteractInstance interactInstance,
      InteractPreset interactPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLadderStartClimbUsed(
      InteractBehavior interactBehavior,
      InteractInstance interactInstance,
      InteractPreset interactPreset,
      bool tweenTo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLadderStopClimbUsed(
      InteractBehavior interactBehavior,
      InteractInstance interactInstance,
      InteractPreset interactPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLadderTopClamberUsed(
      InteractBehavior interactBehavior,
      InteractInstance interactInstance,
      InteractPreset interactPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStepClamberUsed(
      InteractBehavior interactBehavior,
      InteractInstance interactInstance,
      InteractPreset interactPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlagRemovalUsed(
      InteractBehavior interactBehavior,
      InteractInstance interactInstance,
      InteractPreset interactPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFlightViewEntered(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool ProcessRotateUsingAngularVelocity(
      Vector3 currentDir,
      Vector3 desiredDir,
      Vector3 fallbackAngularVelocityDir,
      float currentAngularSpeed,
      float desiredAngularSpeed,
      float desiredAngularSpeedChange,
      float equalDotProductThreshold,
      float deltaTime,
      out Vector3 outAngularVelocity)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KerbalBehavior() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static KerbalBehavior() => throw null;
  }
}
