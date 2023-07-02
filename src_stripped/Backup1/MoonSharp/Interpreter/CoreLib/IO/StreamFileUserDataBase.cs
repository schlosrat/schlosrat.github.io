// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.CoreLib.IO.StreamFileUserDataBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.IO;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.CoreLib.IO
{
  internal abstract class StreamFileUserDataBase : FileUserDataBase
  {
    protected Stream m_Stream;
    protected StreamReader m_Reader;
    protected StreamWriter m_Writer;
    protected bool m_Closed;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Initialize(Stream stream, StreamReader reader, StreamWriter writer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckFileIsNotClosed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool Eof() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override string ReadLine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override string ReadToEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override string ReadBuffer(int p) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override char Peek() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Write(string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override string Close() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool flush() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long seek(string whence, long offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool setvbuf(string mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected internal override bool isopen() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected StreamFileUserDataBase() => throw null;
  }
}
