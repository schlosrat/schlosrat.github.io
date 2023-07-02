// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.EVAInputHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Input;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class EVAInputHandler : FlightInputHandlerBase
  {
    private GameInput.EVAActions _EVAInputMap;
    private EVAInputDefinition _inputDefinition;
    private float _moveLeftRight;
    private float _moveStrafeLeftRight;
    private float _moveFrontBack;
    private float _moveUpDown;
    private float _rotateYaw;
    private float _rotatePitch;
    private float _rotateRoll;
    private bool _run;
    private bool _jump;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMoving() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMovingInGroundPlane() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMovingStrafeOnly() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetInput(VesselComponent vesselComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMoveLeftRight(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMoveStrafeLeftRight(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMoveFrontBack(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMoveUpDown(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotateYaw(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotatePitch(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotateRoll(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRun(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnJump(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EVAInputHandler() => throw null;
  }
}
