// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ClimbKerbalCharacterStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class ClimbKerbalCharacterStateHandler : KerbalCharacterStateHandler
  {
    private static readonly int DISABLE_INTERACT_CONTEXT;
    private Collider _currentClimbTrigger;
    private ClimbInstance _currentClimbInstance;
    private InteractInstance _currentInteractInstance;
    private float _moveUpDownInput;
    private float _climbUpMult;
    private float _climbUpPosOffsetUpperLimit;
    private float _climbUpPosOffsetLowerLimit;
    private float _climbTriggerHalfHeight;
    private float _characterHalfHeight;
    private bool _externalRequestLadderUpPosOffset;
    private ClimbKerbalCharacterStateHandler.StartClimbDockSubState _startClimbDockSubState;
    private ClimbKerbalCharacterStateHandler.StopClimbUndockSubState _stopClimbUndockSubState;
    private ClimbKerbalCharacterStateHandler.ClimbingSubState _climbingSubState;
    private ClimbKerbalCharacterStateHandler.ClamberingSubState _clamberingSubState;
    private ClimbKerbalCharacterStateHandler.SubState _currentSubState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ClimbKerbalCharacterStateHandler(KerbalBehavior kerbalBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Update(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CanBeDeactivatedByLocomotionHandler(
      KerbalCharacterStateHandler deactivateByHandler)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void AcceptMessage(KerbalCharacterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ShouldApplyUpright() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool ShouldBeActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitSubStates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GoToSubState(
      ClimbKerbalCharacterStateHandler.SubState nextSubState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyCharacterCapsuleDimensions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateClimbInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetClimbInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CleanupClimbAndInteractObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MatchLadderPartVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExitClimb() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ClimbKerbalCharacterStateHandler() => throw null;

    private class SubState
    {
      protected ClimbKerbalCharacterStateHandler _owner;
      protected KerbalBehavior _behavior;
      protected KerbalComponent _model;
      protected SimpleTimer _timer;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SubState(ClimbKerbalCharacterStateHandler owner) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void Start() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual ClimbKerbalCharacterStateHandler.SubState Update(float deltaTime) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void Stop() => throw null;
    }

    private class StartClimbDockSubState : ClimbKerbalCharacterStateHandler.SubState
    {
      private Quaternion _sourceRotation;
      private Vector3 _sourceLocalPosition;
      public bool TweenTo;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StartClimbDockSubState(ClimbKerbalCharacterStateHandler owner) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Start() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override ClimbKerbalCharacterStateHandler.SubState Update(float deltaTime) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static float GetColliderHalfHeight(Collider collider) => throw null;
    }

    private class StopClimbUndockSubState : ClimbKerbalCharacterStateHandler.SubState
    {
      private Quaternion _sourceRotation;
      private Quaternion _targetRotation;
      private Vector3 _targetForward;
      private Vector3 _sourceLocalPosition;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StopClimbUndockSubState(ClimbKerbalCharacterStateHandler owner) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Start() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override ClimbKerbalCharacterStateHandler.SubState Update(float deltaTime) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Stop() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private void SetTargetRotation() => throw null;
    }

    private class ClimbingSubState : ClimbKerbalCharacterStateHandler.SubState
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ClimbingSubState(ClimbKerbalCharacterStateHandler owner) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override ClimbKerbalCharacterStateHandler.SubState Update(float deltaTime) => throw null;
    }

    private class ClamberingSubState : ClimbKerbalCharacterStateHandler.SubState
    {
      public Vector3 TargetPosition;
      public bool IsValidTargetPosition;
      public bool IsStepClambering;
      private Vector3 _sourcePosition;
      private Vector3 _intermediateTargetPosition;
      private Vector3 _sourceLocalPosition;
      private Vector3 _targetLocalPosition;
      private Vector3 _intermediateTargetLocalPosition;
      private SimpleTimer _delayTimer;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ClamberingSubState(ClimbKerbalCharacterStateHandler owner) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Start() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override ClimbKerbalCharacterStateHandler.SubState Update(float deltaTime) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Stop() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool IsValidLadderTopClamberingObject() => throw null;
    }
  }
}
