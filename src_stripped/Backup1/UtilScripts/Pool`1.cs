// Decompiled with JetBrains decompiler
// Type: UtilScripts.Pool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
