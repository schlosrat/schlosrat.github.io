// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.Converters.TableConversions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.Converters
{
  internal static class TableConversions
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Table ConvertIListToTable(Script script, IList list) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Table ConvertIDictionaryToTable(Script script, IDictionary dict) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static bool CanConvertTableToType(Table table, Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object ConvertTableToType(Table table, Type t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object ConvertTableToDictionaryOfGenericType(
      Type dictionaryType,
      Type keyType,
      Type valueType,
      Table table)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object ConvertTableToArrayOfGenericType(
      Type arrayType,
      Type itemType,
      Table table)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static object ConvertTableToListOfGenericType(
      Type listType,
      Type itemType,
      Table table)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static List<T> TableToList<T>(Table table, Func<DynValue, T> converter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Dictionary<TK, TV> TableToDictionary<TK, TV>(
      Table table,
      Func<DynValue, TK> keyconverter,
      Func<DynValue, TV> valconverter)
    {
      throw null;
    }
  }
}
