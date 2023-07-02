// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.JumpKerbalCharacterStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Utilities;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class JumpKerbalCharacterStateHandler : KerbalCharacterStateHandler
  {
    private CharacterForce _jumpForce;
    private SimpleTimer _minJumpStateTimer;
    private SimpleTimer _maxJumpStateTimer;
    private JumpKerbalCharacterStateHandler.PreSubState _preSubState;
    private JumpKerbalCharacterStateHandler.InitialSubState _initialSubState;
    private JumpKerbalCharacterStateHandler.ExtendSubState _extendSubState;
    private JumpKerbalCharacterStateHandler.SubState _currentSubState;
    private Vector3 _lastMoveBestUpSurfaceWorldSpace;
    private Vector3 _lastMoveBestUpSurfaceLocalSpace;
    private float _eventJumpImpulseTimestamp;
    private bool _wasPressingContinuouslyJumpInput;
    private bool _wasPressingMoveInput;
    private bool _wasPressingRunInput;
    private bool _isJumpStateBlocked;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JumpKerbalCharacterStateHandler(KerbalBehavior kerbalBehavior) => throw null;

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
    public override bool CanBeActivatedByInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Update(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CanBeDeactivatedByLocomotionHandler(
      KerbalCharacterStateHandler deactivateByHandler)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ShouldApplyStaticFriction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ShouldApplyUpright() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitSubStates() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GoToSubState(
      JumpKerbalCharacterStateHandler.SubState nextSubState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitJumpForce() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeinitJumpForce() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeLastMoveBestUpSurfaceLocalSpace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeJumpForce() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessJumpForce(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterAnimationEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterAnimationEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEventJumpImpulse() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessJumpRotate(float deltaTime) => throw null;

    private class SubState
    {
      protected JumpKerbalCharacterStateHandler _owner;
      protected KerbalBehavior _behavior;
      protected KerbalComponent _model;
      protected SimpleTimer _timer;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SubState(JumpKerbalCharacterStateHandler owner) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void Start() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual JumpKerbalCharacterStateHandler.SubState Update(float deltaTime) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void Stop() => throw null;
    }

    private class PreSubState : JumpKerbalCharacterStateHandler.SubState
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public PreSubState(JumpKerbalCharacterStateHandler owner) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Start() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Stop() => throw null;
    }

    private class InitialSubState : JumpKerbalCharacterStateHandler.SubState
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public InitialSubState(JumpKerbalCharacterStateHandler owner) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Start() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override JumpKerbalCharacterStateHandler.SubState Update(float deltaTime) => throw null;
    }

    private class ExtendSubState : JumpKerbalCharacterStateHandler.SubState
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public ExtendSubState(JumpKerbalCharacterStateHandler owner) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Start() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override JumpKerbalCharacterStateHandler.SubState Update(float deltaTime) => throw null;
    }
  }
}
