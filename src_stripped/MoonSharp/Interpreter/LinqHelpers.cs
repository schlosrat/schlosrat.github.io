// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.LinqHelpers
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public static class LinqHelpers
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<T> Convert<T>(this IEnumerable<DynValue> enumerable, DataType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<DynValue> OfDataType(
      this IEnumerable<DynValue> enumerable,
      DataType type)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<object> AsObjects(this IEnumerable<DynValue> enumerable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IEnumerable<T> AsObjects<T>(this IEnumerable<DynValue> enumerable) => throw null;
  }
}
