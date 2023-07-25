// Decompiled with JetBrains decompiler
// Type: KSP.Api.CoreTypes.DelegateAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Api.CoreTypes
{
  public class DelegateAction : IAction
  {
    private Delegate action;
    private static Action fallback;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DelegateAction() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DelegateAction(Delegate action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Invoke(params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InvokeSafe(params object[] args) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InternalBindDelegate(Delegate del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate(Action del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate<T1>(Action<T1> del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate<T1, T2>(Action<T1, T2> del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate<T1, T2, T3>(Action<T1, T2, T3> del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate<T1, T2, T3, T4>(Action<T1, T2, T3, T4> del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate<R>(Func<R> del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate<T1, R>(Func<T1, R> del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate<T1, T2, R>(Func<T1, T2, R> del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate<T1, T2, T3, R>(Func<T1, T2, T3, R> del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate<T1, T2, T3, T4, R>(Func<T1, T2, T3, T4, R> del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindDelegate(Delegate del) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static object[] SanitizeArgs(
      Delegate action,
      bool fillArgsWithoutDefault,
      object[] args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool InternalInvoke(
      bool catchExceptions,
      bool fillArgsWithoutDefault,
      params object[] args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Type[] GetParamTypes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Type GetReturnType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DelegateAction() => throw null;
  }
}
