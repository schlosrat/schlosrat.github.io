// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.SymbolRef
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter
{
  public class SymbolRef
  {
    private static SymbolRef s_DefaultEnv;
    internal SymbolRefType i_Type;
    internal SymbolRef i_Env;
    internal int i_Index;
    internal string i_Name;

    public SymbolRefType Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int Index
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SymbolRef Environment
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static SymbolRef DefaultEnv
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SymbolRef Global(string name, SymbolRef envSymbol) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static SymbolRef Local(string name, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static SymbolRef Upvalue(string name, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void WriteBinary(BinaryWriter bw) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static SymbolRef ReadBinary(BinaryReader br) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void WriteBinaryEnv(BinaryWriter bw, Dictionary<SymbolRef, int> symbolMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ReadBinaryEnv(BinaryReader br, SymbolRef[] symbolRefs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SymbolRef() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SymbolRef() => throw null;
  }
}
