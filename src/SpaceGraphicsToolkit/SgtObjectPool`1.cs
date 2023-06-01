// Decompiled with JetBrains decompiler
// Type: SpaceGraphicsToolkit.SgtObjectPool`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace SpaceGraphicsToolkit
{
  public static class SgtObjectPool<T> where T : UnityEngine.Object
  {
    private static SgtPoolObject pool;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SgtObjectPool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Add(T entry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Add(T element, Action<T> onAdd) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T Pop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void UpdateComponent(bool allowCreation) => throw null;
  }
}
