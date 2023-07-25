// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.ListExtensions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
