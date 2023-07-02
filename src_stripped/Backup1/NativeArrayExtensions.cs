// Decompiled with JetBrains decompiler
// Type: NativeArrayExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
