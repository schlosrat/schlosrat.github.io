// Decompiled with JetBrains decompiler
// Type: KSP.UnitTests.TestUtils.Lua.ConverterWriteEntry`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.UnitTests.TestUtils.Lua
{
  public struct ConverterWriteEntry<T>
  {
    public string name;
    public int index;
    public T value;
    public T expected_value;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConverterWriteEntry(string name, T value, bool expectDefault = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ConverterWriteEntry(string name, T value, T expectedValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void InitListIndexes(IList<ConverterWriteEntry<T>> list) => throw null;
  }
}
