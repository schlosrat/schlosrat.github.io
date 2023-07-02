// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.Pool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class Pool<T> : IPool<T> where T : class
  {
    protected List<T> _available;
    protected Pool<T>.Allocator _allocator;
    protected Pool<T>.Resetter _resetterOnAcquire;
    protected Pool<T>.Resetter _resetterOnReturn;
    protected object _optionalLock;

    public int AvailableCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Pool(
      Pool<T>.Allocator allocator,
      Pool<T>.Resetter resetOnAcquire,
      Pool<T>.Resetter resetOnReturn,
      object optionalLock)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Flush() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void MakeAvailable(int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual T Acquire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual Pool<T>.ReturnableHandle AcquireHandle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void AcquireMultiple(ICollection<T> collection, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Return(ref T t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void ReturnUnprotected(T t) => throw null;

    public struct ReturnableHandle : IDisposable
    {
      public T Value;
      private Pool<T> _pool;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ReturnableHandle(Pool<T> pool) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Dispose() => throw null;
    }

    public delegate T Allocator() where T : class;

    public delegate void Resetter(T t) where T : class;
  }
}
