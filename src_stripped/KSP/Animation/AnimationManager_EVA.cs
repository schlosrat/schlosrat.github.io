// Decompiled with JetBrains decompiler
// Type: KSP.Animation.AnimationManager_EVA
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Animation
{
  [DisallowMultipleComponent]
  public class AnimationManager_EVA : AnimationManager
  {
    private const float INPUT_THRESHOLD = 0.01f;
    public Action OnEventJumpImpulse;
    public Action OnEventAnimationEnd;
    [SerializeField]
    [Space(10f)]
    private float _minFidgetDelay;
    [SerializeField]
    private float _maxFidgetDelay;
    [Space(10f)]
    [SerializeField]
    private float _groundMoveTransitionSpeed;
    [SerializeField]
    private float _jetpackThrustMoveTransitionSpeed;
    [SerializeField]
    private float _swimMoveTransitionSpeed;
    [Space(10f)]
    [SerializeField]
    private string _randomIdleParamName;
    [SerializeField]
    private string _turnLRParamName;
    [SerializeField]
    private string _moveBFParamName;
    [SerializeField]
    private string _moveLRParamName;
    [SerializeField]
    private string _moveDUParamName;
    [SerializeField]
    private string _sprintModeParamName;
    [SerializeField]
    private string _gravityMulParamName;
    [SerializeField]
    private string _eVAModeParamName;
    [SerializeField]
    private string _ragdollSideFallenFBParamName;
    [SerializeField]
    private string _emoteIndexParamName;
    [SerializeField]
    private string _isFallingParamName;
    [FormerlySerializedAs("_isInWaterParamName")]
    [SerializeField]
    private string _isSwimmingParamName;
    [SerializeField]
    private string _isFloatingInWaterParamName;
    [SerializeField]
    private string _isOnLadderParamName;
    [SerializeField]
    private string _jumpTriggerParamName;
    [SerializeField]
    private string _standupTriggerParamName;
    [SerializeField]
    private string _toggleJetpackTriggerParamName;
    [SerializeField]
    private string _plantFlagTriggerParamName;
    [SerializeField]
    private string _startFloatingTriggerParamName;
    [SerializeField]
    private string _grabLadderTriggerParamName;
    [SerializeField]
    private string _emoteTriggerParamName;
    [SerializeField]
    private string _fidgetTriggerParamName;
    [SerializeField]
    [Space(10f)]
    private string _plantFlagAnimationStateName;
    private int _randomIdleID;
    private int _turnLRID;
    private int _moveBFID;
    private int _moveLRID;
    private int _moveDUID;
    private int _sprintID;
    private int _gravityMulID;
    private int _eVAOnID;
    private int _ragdollSideFallenFBID;
    private int _emoteIndexID;
    private int _isFallingID;
    private int _isSwimmingID;
    private int _isFloatingInWaterID;
    private int _onLadderID;
    private int _jumpTriggerID;
    private int _standTriggerID;
    private int _jetpackTriggerID;
    private int _flagTriggerID;
    private int _floatingTriggerID;
    private int _ladderTriggerID;
    private int _emoteTriggerID;
    private int _fidgetTriggerID;
    private float _turnLRTargetValue;
    private float _moveLRTargetValue;
    private float _moveBFTargetValue;
    private float _moveDUTargetValue;
    private bool _isFalling;
    private bool _isLadderClimbing;
    private bool _isClambering;
    private bool _isFloatingInWater;
    private bool _isSwimming;
    private bool _isJetpackInUse;
    private EVAKerbalAnimationState _animationState;

    public string PlantFlagAnimationStateName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlayAnimationRequestKerbalCharacterMessage CreatePlayAnimationMessageForFlagPlanet() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitAnimTreeParamIndices() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAnimationState(EVAKerbalAnimationState animStateToSet) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshTriggers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetAllTriggers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleMovementKeysOnUpdate(float? goal, ref float targetValue, int animID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ShouldStartFloatingTrigger() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsJetpackInUseAnimTree() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DoJumpImpulse() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AnimationEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsEqualInputValue(float value1, float value2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AnimationManager_EVA() => throw null;
  }
}
