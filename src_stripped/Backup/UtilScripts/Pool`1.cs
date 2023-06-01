// Decompiled with JetBrains decompiler
// Type: UtilScripts.Pool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Utilities;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UtilScripts
{
  public class Pool<T> : IObjectPool<T>, IDisposable
  {
    private readonly Stack<T> values;
    private readonly Func<T> create;
    private readonly Action<T> reset;
    private readonly Func<T> release;
    private PoolsStatus status;

    public int Size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Allocated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Pool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pool(Func<T> create, Action<T> reset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T FetchInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseInstance(T value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseAllActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;
  }
}
