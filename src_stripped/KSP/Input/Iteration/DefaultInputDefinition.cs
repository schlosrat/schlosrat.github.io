// Decompiled with JetBrains decompiler
// Type: KSP.Input.Iteration.DefaultInputDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
