// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.CrewMemberState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct CrewMemberState
  {
    public string inPartGuid;
    public int seatIndex;
    public CrewState state;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Defaults(out CrewMemberState definition) => throw null;
  }
}
