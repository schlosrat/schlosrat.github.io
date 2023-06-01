// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.ListExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace AwesomeTechnologies.Utility
{
  public static class ListExtensions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static T[] GetInternalArray<T>(this List<T> list) => throw null;

    private static class ArrayAccessor<T>
    {
      public static readonly Func<List<T>, T[]> Getter;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static ArrayAccessor() => throw null;
    }
  }
}
