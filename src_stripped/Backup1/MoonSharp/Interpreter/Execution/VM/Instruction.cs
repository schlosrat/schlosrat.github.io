// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Execution.VM.Instruction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Debugging;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Execution.VM
{
  internal class Instruction
  {
    internal OpCode OpCode;
    internal SymbolRef Symbol;
    internal SymbolRef[] SymbolList;
    internal string Name;
    internal DynValue Value;
    internal int NumVal;
    internal int NumVal2;
    internal SourceRef SourceCodeRef;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal Instruction(SourceRef sourceref) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string PurifyFromNewLines(DynValue Value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GenSpaces() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void WriteBinary(
      BinaryWriter wr,
      int baseAddress,
      Dictionary<SymbolRef, int> symbolMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void WriteSymbol(
      BinaryWriter wr,
      SymbolRef symbolRef,
      Dictionary<SymbolRef, int> symbolMap)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SymbolRef ReadSymbol(BinaryReader rd, SymbolRef[] deserializedSymbols) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static Instruction ReadBinary(
      SourceRef chunkRef,
      BinaryReader rd,
      int baseAddress,
      Table envTable,
      SymbolRef[] deserializedSymbols)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static DynValue ReadValue(BinaryReader rd, Table envTable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DumpValue(BinaryWriter wr, DynValue value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void GetSymbolReferences(out SymbolRef[] symbolList, out SymbolRef symbol) => throw null;
  }
}
