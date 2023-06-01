// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.IO.BinDumpBinaryWriter
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
  public class BinDumpBinaryWriter : BinaryWriter
  {
    private Dictionary<string, int> m_StringMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BinDumpBinaryWriter(Stream s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BinDumpBinaryWriter(Stream s, Encoding e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Write(uint value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Write(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Write(string value) => throw null;
  }
}
