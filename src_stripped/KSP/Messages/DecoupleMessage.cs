// Decompiled with JetBrains decompiler
// Type: KSP.Messages.DecoupleMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Parts/DecoupleMessage", true, "Player has triggered a decoupler on a vehicle", "")]
  public class DecoupleMessage : PartModuleMessageBase
  {
    public IGGuid OtherPartGuid;
    public IGGuid VesselGuid;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DecoupleMessage() => throw null;
  }
}
