// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.ProtocolServer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace MoonSharp.VsCodeDebugger.SDK
{
  public abstract class ProtocolServer
  {
    public bool TRACE;
    public bool TRACE_RESPONSE;
    protected const int BUFFER_SIZE = 4096;
    protected const string TWO_CRLF = "\r\n\r\n";
    protected static readonly Regex CONTENT_LENGTH_MATCHER;
    protected static readonly Encoding Encoding;
    private int _sequenceNumber;
    private Stream _outputStream;
    private ByteBuffer _rawData;
    private int _bodyLength;
    private bool _stopRequested;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProtocolServer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessLoop(Stream inputStream, Stream outputStream) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Stop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendEvent(Event e) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void DispatchRequest(string command, Table args, Response response) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Dispatch(string req) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SendMessage(ProtocolMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static byte[] ConvertToBytes(ProtocolMessage request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ProtocolServer() => throw null;
  }
}
