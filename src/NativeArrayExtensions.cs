// Decompiled with JetBrains decompiler
// Type: NativeArrayExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using Unity.Collections;

public static class NativeArrayExtensions
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CopyToFast<T>(this NativeArray<T> nativeArray, T[] array) where T : struct => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CopyToFast<T>(this NativeSlice<T> nativeSlice, T[] array) where T : struct => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CopyToFast<T>(this NativeArray<T> nativeArray, T[,,] array) where T : struct => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CopyFromFast<T>(this NativeArray<T> nativeArray, T[,] array) where T : struct => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CopyFromFast<T>(this NativeArray<T> nativeArray, T[,,] array) where T : struct => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void CopyFromFast<T>(this NativeArray<T> nativeArray, T[] array) where T : struct => throw null;
}
