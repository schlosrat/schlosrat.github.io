// Decompiled with JetBrains decompiler
// Type: KSP.DiffUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP
{
  public static class DiffUtils
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool DiffCollectionChanges<T>(
      ICollection<T> before,
      ICollection<T> after,
      out HashSet<T> added,
      out HashSet<T> removed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool DiffCollectionChanges<T>(ICollection<T> before, ICollection<T> after) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool DiffCollectionCountChanges<T>(
      ICollection<T> before,
      ICollection<T> after,
      out Dictionary<T, int> added,
      out Dictionary<T, int> removed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool DiffCollectionCountChanges<T>(ICollection<T> before, ICollection<T> after) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool DiffCollectionOrder<T>(ICollection<T> before, ICollection<T> after) => throw null;
  }
}
