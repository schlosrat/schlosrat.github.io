// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.Request
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
