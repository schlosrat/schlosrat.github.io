// Decompiled with JetBrains decompiler
// Type: MoonSharp.VsCodeDebugger.SDK.ProtocolMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
