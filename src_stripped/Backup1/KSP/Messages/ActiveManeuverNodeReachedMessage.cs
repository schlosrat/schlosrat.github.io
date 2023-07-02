// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ActiveManeuverNodeReachedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/ActiveManeuverNodeReached", true, "Fired when the time to reach the Active Maneuver Node is 0.", "")]
  public class ActiveManeuverNodeReachedMessage : FlightMessageBase
  {
    public SimulationObjectModel simObject;
    public double UT;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActiveManeuverNodeReachedMessage() => throw null;
  }
}
