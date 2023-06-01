// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.JetpackKerbalCharacterStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class JetpackKerbalCharacterStateHandler : MoveGroundKerbalCharacterStateHandler
  {
    private JetpackResourceManager _jetpackResourceManager;
    private List<CharacterForce> _jetpackForces;
    private List<CharacterTorque> _jetpackTorques;
    private CharacterForce _resultantJetpackForce;
    private CharacterTorque _resultantJetpackTorque;
    private Vector3 _moveLocalSpace;
    private Vector3 _rotateLocalSpace;
    private Vector3 _rotateResetAngularVelocity;
    private Vector3d _resultantForceLocalSpace;
    private Vector3d _resultantTorqueLocalSpace;
    private bool _isResetTorqueAllowed;
    private bool _isAlignToCameraAllowed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public JetpackKerbalCharacterStateHandler(KerbalBehavior kerbalBehavior) => throw null;

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
    public override bool CanBeDeactivatedByLocomotionHandler(
      KerbalCharacterStateHandler deactivateByHandler)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool ShouldBeActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetJetpackInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitJetpackForces() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeinitJetpackForces() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitJetpackTorques() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeinitJetpackTorques() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMoveInputCameraRelative(in Quaternion kerbalToCameraRotationDiff) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateRotateInputAlignToCamera(in Quaternion kerbalToCameraRotationDiff) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateInputCameraFeatures() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateJetpackMoveRotateInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateAnimationState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessJetpackForces() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetJetpackForces() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessJetpackTorques(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetJetpackTorques() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ClampJetpackRotateAngularVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetJetpackTorquesSmooth(float fixedDeltaTime, ref bool isRotateTorqueLSZeroMag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeJetpackRotateAngularVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyJetpackRotateAngularVelocity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetJetpack() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateJetpackVFXMoveVector(bool isMoveForceLSZeroMag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateJetpackVFXRotateVector(bool isRotateTorqueLSZeroMag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessJetpackLiquidDragScalar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetDragScalar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool ApplyAngleAsRotateInput(
      Data_Kerbal kerbalData,
      float angleDegrees,
      ref float inputValue)
    {
      throw null;
    }
  }
}
