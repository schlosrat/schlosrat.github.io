// Decompiled with JetBrains decompiler
// Type: ListExtension
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public static class ListExtension
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void Shuffle<T>(this IList<T> list) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T AddUnique<T>(this IList<T> list, T item) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool TryAddUnique<T>(this IList<T> list, T item) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void AddUniqueRange<T>(this IList<T> list, IEnumerable<T> items) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void AddUniqueRange<T>(this IList<T> list, IList<T> items) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T MaxAt<T, TKey>(this IList<T> list, Func<T, TKey> sortBy) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T MinAt<T, TKey>(this IList<T> list, Func<T, TKey> sortBy) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetRange<T>(this List<T> list, T[] range, int startIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetRange<T>(this List<T> list, List<T> range, int startIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetRange<T>(this T[] list, List<T> range, int startIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void SetRange<T>(this T[] list, T[] range, int startIndex) => throw null;
}
