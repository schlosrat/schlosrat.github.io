// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.IReadOnlyListEqualityComparerExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public static class IReadOnlyListEqualityComparerExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(this IReadOnlyList<T> list, T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(this IReadOnlyList<T> list, T item, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(this IReadOnlyList<T> list, T item, int index, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(this IReadOnlyList<T> list, T item, IEqualityComparer<T> comparer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(
      this IReadOnlyList<T> list,
      T item,
      int index,
      IEqualityComparer<T> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int IndexOf<T>(
      this IReadOnlyList<T> list,
      T item,
      int index,
      int count,
      IEqualityComparer<T> comparer)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.AggressiveInlining)]
    private static int ExtendedIReadOnlyListIndexOf<T>(
      IReadOnlyList<T> list,
      T item,
      int index,
      int count,
      IEqualityComparer<T> comparer)
    {
      throw null;
    }
  }
}
