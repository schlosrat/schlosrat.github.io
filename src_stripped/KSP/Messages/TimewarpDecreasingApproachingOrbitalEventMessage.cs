// Decompiled with JetBrains decompiler
// Type: KSP.Messages.TimewarpDecreasingApproachingOrbitalEventMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Map/TimewarpDecreasingApproachingOrbitalEventMessage", true, "Player is approaching the end of the burn and decreasing time warp.", "")]
  public class TimewarpDecreasingApproachingOrbitalEventMessage : MessageCenterMessage
  {
    public PatchTransitionType PatchEndTransition;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimewarpDecreasingApproachingOrbitalEventMessage() => throw null;
  }
}
