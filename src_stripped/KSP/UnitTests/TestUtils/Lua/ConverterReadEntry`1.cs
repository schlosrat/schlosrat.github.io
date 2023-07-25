// Decompiled with JetBrains decompiler
// Type: KSP.UnitTests.TestUtils.Lua.ConverterReadEntry`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.UnitTests.TestUtils.Lua
{
  public struct ConverterReadEntry<T>
  {
    public string name;
    public int index;
    public DynValue input;
    public T expected_value;
    public bool expected_result;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConverterReadEntry(string name, DynValue input, T value, bool result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void InitListIndexes(IList<ConverterReadEntry<T>> list) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FillTable(Table toFill, IList<ConverterReadEntry<T>> list) => throw null;
  }
}
