// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.NativeArrayExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace AwesomeTechnologies.Utility
{
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CopyFromFast<T>(this NativeArray<T> nativeArray, List<T> managedList) where T : struct => throw null;
  }
}
