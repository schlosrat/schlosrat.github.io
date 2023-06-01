// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtComponentPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SpaceGraphicsToolkit
{
  public static class SgtComponentPool<T> where T : Component
  {
    private static SgtPoolComponent pool;

    public static int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Add(T entry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Add(T element, Action<T> onAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Cache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Pop(Transform parent, string name, int layer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Pop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Pop(Predicate<T> match) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void UpdateComponent(bool allowCreation) => throw null;
  }
}
