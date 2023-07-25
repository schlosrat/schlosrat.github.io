// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselUndockedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Vessel/VesselUndockedMessage", true, "Player's vehicle has undocked from another vehicle or colony", "")]
  public class VesselUndockedMessage : FlightMessageBase
  {
    public VesselBehavior VesselOne;
    public VesselBehavior VesselTwo;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselUndockedMessage() => throw null;
  }
}
