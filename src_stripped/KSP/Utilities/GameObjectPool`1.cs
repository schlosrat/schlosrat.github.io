// Decompiled with JetBrains decompiler
// Type: KSP.Utilities.GameObjectPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Utilities
{
  public class GameObjectPool<T> : IObjectPool<T>, IDisposable where T : Component
  {
    private T _targetObject;
    private Transform _poolParent;
    private bool _didCreateGameObjectForPool;
    private Queue<T> _availablePool;
    private List<T> _instances;
    private Action<T> _onReset;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObjectPool(
      T targetObject,
      Action<T> onReset = null,
      Transform parent = null,
      bool worldPositionStays = true,
      int prewarmCount = 0,
      bool createGameObjectForPool = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PreWarm(int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T FetchInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T FetchInstance(Transform newParent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private T CreateInstance(Transform newParent = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseInstance(T targetInstance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReleaseAllActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerable<T> GetActiveInstances() => throw null;
  }
}
