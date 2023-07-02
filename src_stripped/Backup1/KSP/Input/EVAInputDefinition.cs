// Decompiled with JetBrains decompiler
// Type: KSP.Input.EVAInputDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

namespace KSP.Input
{
  public class EVAInputDefinition : InputDefinition
  {
    private GameInput.EVAActions _inputSourceMap;

    public override InputActionMap InputSourceMap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EVAInputDefinition(GameInput inputSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeActionBinders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMoveLeftRight(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMoveStrafeLeftRight(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMoveFrontBack(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnMoveUpDown(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotateYaw(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotatePitch(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotateRoll(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRun(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnJump(InputAction.CallbackContext context) => throw null;
  }
}
