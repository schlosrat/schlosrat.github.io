// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.Data.impl.DemoHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Api.Generic;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration.Data.impl
{
  [Serializable]
  public class DemoHealth : IDemoHealth
  {
    public PropertyExternal<int> maxLivesInternal;
    public PropertyExternal<int> curLivesInternal;
    public PropertyDerived<bool, int> isDeadInternal;
    [SerializeField]
    private int maxLives;
    [SerializeField]
    private int curLives;

    public IProperty<int> MaxLives
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IProperty<int> CurLives
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IProperty<bool> IsDead
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public event Action LifeLost
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event Action LifeGained
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Revive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Kill() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Hurt() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Heal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DemoHealth() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int HandleLivesSet(int requestedLives) => throw null;
  }
}
