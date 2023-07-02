// Decompiled with JetBrains decompiler
// Type: KSP.Input.Iteration.DefaultInputDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

namespace KSP.Input.Iteration
{
  public class DefaultInputDefinition : InputDefinition
  {
    public const string ButtonId = "Button";
    public const string AxisId = "Axis";
    private TestInput _inputSource;

    public override InputActionMap InputSourceMap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DefaultInputDefinition(TestInput inputSource) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void InitializeActionBinders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnButton(InputAction.CallbackContext context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAxis(InputAction.CallbackContext context) => throw null;
  }
}
