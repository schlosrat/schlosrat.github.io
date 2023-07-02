// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.SwimKerbalCharacterStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class SwimKerbalCharacterStateHandler : KerbalCharacterStateHandler
  {
    private const float EQUAL_ANGLE_DEGREES_THRESHOLD = 0.1f;
    private CharacterForce _swimForce;
    private Vector3 _moveOnWaterLocalSpace;
    private Vector3 _moveOnWaterWorldSpace;
    private Vector3 _desiredFacingDirWorldSpace;
    private bool _isSwimmingFast;
    private float _normalToSprintLerpSpeed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SwimKerbalCharacterStateHandler(KerbalBehavior kerbalBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CanBeDeactivatedByLocomotionHandler(
      KerbalCharacterStateHandler deactivateByHandler)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ShouldApplyUpright() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool ShouldBeActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitSwimForce() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeinitSwimForce() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSwimInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetSwimInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateSwimInputAnimationState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeSwimInputMoveDir(Transform cameraTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeSwimDesiredFacingDir(Transform cameraTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessSwim(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessSwimMove() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessSwimRotate(float deltaTime) => throw null;
  }
}
