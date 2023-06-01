// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.ProtocolMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.VsCodeDebugger.SDK
{
  public class ProtocolMessage
  {
    public int seq;

    public string type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProtocolMessage(string typ) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ProtocolMessage(string typ, int sq) => throw null;
  }
}
