﻿// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.Request
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
