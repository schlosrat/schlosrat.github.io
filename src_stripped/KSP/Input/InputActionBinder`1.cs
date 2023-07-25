// Decompiled with JetBrains decompiler
// Type: KSP.Input.InputActionBinder`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

namespace KSP.Input
{
  public class InputActionBinder<T> : ToggleableInputAction
  {
    private Action<T> _action;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public InputActionBinder(InputAction inputAction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindAction(Action<T> action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnbindAction(Action<T> action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Invoke(T data) => throw null;
  }
}
