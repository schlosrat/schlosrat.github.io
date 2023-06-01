// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.IO.BinDumpBinaryReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace MoonSharp.Interpreter.IO
{
  public class BinDumpBinaryReader : BinaryReader
  {
    private List<string> m_Strings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BinDumpBinaryReader(Stream s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BinDumpBinaryReader(Stream s, Encoding e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int ReadInt32() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override uint ReadUInt32() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ReadString() => throw null;
  }
}
