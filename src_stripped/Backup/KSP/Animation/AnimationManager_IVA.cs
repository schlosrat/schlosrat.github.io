// Decompiled with JetBrains decompiler
// Type: KSP.Animation.AnimationManager_IVA
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Inspector;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Animation
{
  public class AnimationManager_IVA : AnimationManager
  {
    [Space(10f)]
    [FormerlySerializedAs("constitution")]
    public float AttrConstitution;
    [Space(10f)]
    [SerializeField]
    private string _expressionParamName;
    [SerializeField]
    [FormerlySerializedAs("bodyFidgetTriggerName")]
    private string _bodyFidgetTriggerParamName;
    [FormerlySerializedAs("bodyFidgetRandomIntName")]
    [SerializeField]
    private string _bodyFidgetIndexParamName;
    [SerializeField]
    [FormerlySerializedAs("bodyFidgetDelayMin")]
    private float _minBodyFidgetDelay;
    [SerializeField]
    [FormerlySerializedAs("bodyFidgetDelayMax")]
    private float _maxBodyFidgetDelay;
    [SerializeField]
    [FormerlySerializedAs("headFidgetTriggerName")]
    private string _headFidgetTriggerParamName;
    [FormerlySerializedAs("headFidgetRandomIntName")]
    [SerializeField]
    private string _headFidgetIndexParamName;
    [FormerlySerializedAs("headFidgetDelayMin")]
    [SerializeField]
    private float _minHeadFidgetDelay;
    [SerializeField]
    [FormerlySerializedAs("headFidgetDelayMax")]
    private float _maxHeadFidgetDelay;
    [FormerlySerializedAs("panickedBreathTriggerName")]
    [SerializeField]
    private string _panickedBreathTriggerParamName;
    [FormerlySerializedAs("panickedBreathDelayMin")]
    [SerializeField]
    private float _minPanickedBreathDelay;
    [SerializeField]
    [FormerlySerializedAs("panickedBreathDelayMax")]
    private float _maxPanickedBreathDelay;
    [SerializeField]
    private float _panickedBreathExpressionThreshold;
    [SerializeField]
    private float _minPlaybackMul;
    [SerializeField]
    private float _maxPlaybackMul;
    [SerializeField]
    private float _minFidgetDelay;
    [SerializeField]
    private float _maxFidgetDelay;
    [Space(10f)]
    [FormerlySerializedAs("activateStageTriggerName")]
    [SerializeField]
    private string _activateStageTriggerParamName;
    [SerializeField]
    private string _transitioningStateParamName;
    [Space(10f)]
    [SerializeField]
    private string _sickStateParamName;
    [SerializeField]
    private string _sickToggleParamName;
    [SerializeField]
    private string _sleepStateParamName;
    [SerializeField]
    private string _sleepTriggerParamName;
    [FormerlySerializedAs("min_angularSickThreshold")]
    [SerializeField]
    private float _minAngularSickThreshold;
    [FormerlySerializedAs("min_geeForceSickThreshold")]
    [SerializeField]
    private float _minGForceSickThreshold;
    [SerializeField]
    [FormerlySerializedAs("angularSleepThresholdOffset")]
    private float _angularSleepThresholdOffset;
    [FormerlySerializedAs("geeForceSleepThresholdOffset")]
    [SerializeField]
    private float _gForceSleepThresholdOffset;
    [Space(10f)]
    [SerializeField]
    private string _throttleDUPhaseParamName;
    [SerializeField]
    private string _turnLRPhaseParamName;
    [SerializeField]
    private string _forceLRPhaseParamName;
    [SerializeField]
    private string _forceDUPhaseParamName;
    [SerializeField]
    private string _forceBFPhaseParamName;
    [SerializeField]
    [Space(10f)]
    private int _crashedRecoveryAnimationCount;
    [SerializeField]
    private string _crashTriggerName;
    [SerializeField]
    private string _crashedStateBoolName;
    [SerializeField]
    private string _crashedBlendStateName;
    [SerializeField]
    private string _crashedRecoveryIndexName;
    [SerializeField]
    private float _crashedRecoveryTimeAtMinCon;
    [SerializeField]
    private float _crashedRecoveryTimeAtMaxCon;
    [Tooltip("Multiplier we apply to the Vessel's Angular Acceleration in radians/second^2 with the intent of bringing it within the [-1, +1] range of animation variables before the clamp. Tune this well enough to where normal Angular Acceleration changes utilize most of the [-1, +1] range in a normal gameplay scenario. I.e., we don't want animation variables to be stuck at min -1 or max +1 during non-extreme changes.")]
    [SerializeField]
    private float _angularAccelerationMultiplier;
    [SerializeField]
    [Tooltip("Multiplier we apply to the Vessel's Linear Acceleration in meters/second^2 with the intent of bringing it within the [-1, +1] range of animation variables before the clamp. Tune this well enough to where normal Linear Acceleration changes utilize most of the [-1, +1] range in a normal gameplay scenario. I.e., we don't want animation variables to be stuck at min -1 or max +1 during non-extreme changes.")]
    private float _linearAccelerationMultiplier;
    [Tooltip("Duration in seconds for the Damp Time while setting animation variables via Animator.SetFloat() calls. I.e., this helps smooth out abrupt value changes.")]
    [SerializeField]
    private float _animVarDampTime;
    [Space(30f)]
    [SerializeField]
    [ReadOnly]
    private float _curAngularVelocity;
    [SerializeField]
    [ReadOnly]
    private float _curGForce;
    private VesselBehavior _vessel;
    private Vector3 _lastAngularVelocity;
    private float _angularSickThreshold;
    private float _gForceSickThreshold;
    private float _angularSleepThreshold;
    private float _gForceSleepThreshold;
    private float _lastThrottle;
    private float _lastTurning;
    private float _panickedBreathTimer;
    private float _lastForceLR;
    private float _lastForceDU;
    private float _lastForceBF;
    private float _throttleDUPhaseValue;
    private float _turnLRPhaseValue;
    private float _forceLRPhaseValue;
    private float _forceBFPhaseValue;
    private float _forceDUPhaseValue;
    private float _crashedRecoveryTimer;
    private bool _inCrashedState;
    private int _expressionID;
    private int _bodyFidgetTriggerID;
    private int _bodyFidgetIndexID;
    private int _headFidgetTriggerID;
    private int _headFidgetIndexID;
    private int _panickedBreathTriggerID;
    private int _activateStageTriggerID;
    private int _transitioningStateID;
    private int _sickStateID;
    private int _sickToggleID;
    private int _sleepStateID;
    private int _sleepTriggerID;
    private int _throttleDUPhaseID;
    private int _turnLRPhaseID;
    private int _forceLRPhaseID;
    private int _forceDUPhaseID;
    private int _forceBFPhaseID;
    private int _crashTriggerID;
    private int _crashedStateID;
    private int _crashedBlendStateID;
    private int _crashedRecoveryIndexID;

    private bool IsVesselValid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetContainedPart(PartBehavior ourPart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitAttributeValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitAnimTreeParamIndices() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStageActivated(int stage) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerACrash() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AnimationManager_IVA() => throw null;
  }
}
