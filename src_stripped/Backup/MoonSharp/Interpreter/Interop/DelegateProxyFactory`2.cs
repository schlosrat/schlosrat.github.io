// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.DelegateProxyFactory`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class DelegateProxyFactory<TProxy, TTarget> : IProxyFactory<TProxy, TTarget>, IProxyFactory
    where TProxy : class
    where TTarget : class
  {
    private Func<TTarget, TProxy> wrapDelegate;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DelegateProxyFactory(Func<TTarget, TProxy> wrapDelegate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TProxy CreateProxyObject(TTarget target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object CreateProxyObject(object o) => throw null;

    public Type TargetType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Type ProxyType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
