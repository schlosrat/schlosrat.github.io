// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselUndockedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
