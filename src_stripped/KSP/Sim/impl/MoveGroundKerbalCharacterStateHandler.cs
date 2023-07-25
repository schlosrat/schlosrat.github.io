// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.MoveGroundKerbalCharacterStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public abstract class MoveGroundKerbalCharacterStateHandler : KerbalCharacterStateHandler
  {
    private Vector3 _moveOnGroundWorldSpace;
    private Vector3 _moveBestUpSurfaceWorldSpace;
    private Vector3 _desiredFacingDirOnGroundWorldSpace;
    private float _slopeMoveGroundDotProductThreshold;
    private float _slopeMoveUpDetectDotProductThreshold;
    private float _moveUpFlipDotProductThreshold;
    private float _moveOnGroundRotateFallbackDotProductThreshold;
    private float _walkToRunLerpSpeed;
    private bool _isCameraUpsideDown;
    private bool _isRunning;
    private bool _isMovingUpSlope;
    private bool _isMovingUpSlopeBlocked;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoveGroundKerbalCharacterStateHandler(
      KerbalBehavior kerbalBehavior,
      KerbalCharacterStateHandlerType handlerType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ShouldApplyStaticFriction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ShouldApplyUpright() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOnGroundInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetOnGroundInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateOnGroundInputAnimationState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessMoveUpSlopeBlocked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetBestGroundContactNormal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeOnGroundInputMoveDir(Transform cameraTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeOnGroundInputDesiredFacingDir(Transform cameraTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessOnGroundMoveRotate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessOnGroundMove() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool DetermineCameraUpsideDown(
      ref Vector3 bestGroundContactNormal,
      in Vector3 cameraUp,
      float flipUpDotProductThreshold)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3 GetMoveInputForPlane(
      in Vector3 planeNormal,
      in Vector3 moveInputCameraWorldSpace,
      in Vector3 moveInputCameraNormalizedWorldSpace,
      in Vector3 moveInputFallbackWorldSpace,
      float fallbackDotProductThreshold)
    {
      throw null;
    }
  }
}
