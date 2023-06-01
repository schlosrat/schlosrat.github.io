// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.GameObjectPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Utilities
{
  public class GameObjectPool<T> : IObjectPool<T>, IDisposable where T : Component
  {
    private T _targetObject;
    private Transform _parentTransform;
    private Transform _poolParent;
    private Queue<T> _availablePool;
    private List<T> _instances;
    private Action<T> _onReset;

    private Transform PoolParent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectPool(
      T targetObject,
      Action<T> onReset = null,
      Transform parent = null,
      bool worldPositionStays = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T FetchInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseInstance(T targetInstance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseAllActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<T> GetActiveInstances() => throw null;
  }
}
