// Decompiled with JetBrains decompiler
// Type: NativeCollectionsExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Jobs;

public static class NativeCollectionsExtensions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SafeDisposeIfCreated<T>(this NativeList<T> toDispose) where T : unmanaged => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SafeDisposeIfCreated<T>(this NativeArray<T> toDispose) where T : struct => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SafeDisposeIfCreated<T>(this NativeQueue<T> toDispose) where T : struct => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SafeDisposeIfCreated<TKey, TValue>(this NativeHashMap<TKey, TValue> toDispose)
    where TKey : struct, IEquatable<TKey>
    where TValue : struct
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SafeDisposeIfCreated(this TransformAccessArray toDispose) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SafeDisposeIfCreated(this ComputeBuffer toDispose) => throw null;
}
