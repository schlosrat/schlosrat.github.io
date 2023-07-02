// Decompiled with JetBrains decompiler
// Type: KSP.Input.InputDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.InputSystem;

namespace KSP.Input
{
  public abstract class InputDefinition : IDisposable
  {
    protected Dictionary<string, ToggleableInputAction> _actions;
    protected bool _enabled;

    public abstract InputActionMap InputSourceMap
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Dictionary<string, ToggleableInputAction> Actions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void InitializeActionBinders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BindAction(string id, Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BindAction<T>(string id, Action<T> action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UnbindAction(string id, Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UnbindAction<T>(string id, Action<T> action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void TriggerAction(string id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void TriggerAction<T>(string id, T value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetEnabled(bool enabled, bool forced = false, bool appliedToActions = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool TryGetAction(string id, out ToggleableInputAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected InputDefinition() => throw null;
  }
}
