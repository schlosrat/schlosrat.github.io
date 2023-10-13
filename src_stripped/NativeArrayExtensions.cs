// Decompiled with JetBrains decompiler
// Type: NativeArrayExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
