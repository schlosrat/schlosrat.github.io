// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.CrewMemberState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
