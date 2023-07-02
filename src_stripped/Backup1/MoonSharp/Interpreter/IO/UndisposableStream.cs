// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.IO.UndisposableStream
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.IO
{
  public class UndisposableStream : Stream
  {
    private Stream m_Stream;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UndisposableStream(Stream stream) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Close() => throw null;

    public override bool CanRead
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override bool CanSeek
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override bool CanWrite
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Flush() => throw null;

    public override long Length
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override long Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int Read(byte[] buffer, int offset, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override long Seek(long offset, SeekOrigin origin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetLength(long value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Write(byte[] buffer, int offset, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IAsyncResult BeginRead(
      byte[] buffer,
      int offset,
      int count,
      AsyncCallback callback,
      object state)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override IAsyncResult BeginWrite(
      byte[] buffer,
      int offset,
      int count,
      AsyncCallback callback,
      object state)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EndWrite(IAsyncResult asyncResult) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int EndRead(IAsyncResult asyncResult) => throw null;

    public override bool CanTimeout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Equals(object obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetHashCode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int ReadByte() => throw null;

    public override int ReadTimeout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void WriteByte(byte value) => throw null;

    public override int WriteTimeout
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }
  }
}
