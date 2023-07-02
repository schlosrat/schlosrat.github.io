// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.Request
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter;
using System.Runtime.CompilerServices;

namespace MoonSharp.VsCodeDebugger.SDK
{
  public class Request : ProtocolMessage
  {
    public string command;
    public Table arguments;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Request(int id, string cmd, Table arg) => throw null;
  }
}
