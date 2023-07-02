// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.GameObjectPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
