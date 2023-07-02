// Decompiled with JetBrains decompiler
// Type: KSP.DiffUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
