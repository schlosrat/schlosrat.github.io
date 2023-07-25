// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselRecoveredMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Vessel/VesselRecoveredMessage", false, "Player vessel has been recovered", "")]
  public class VesselRecoveredMessage : FlightMessageBase
  {
    public IGGuid VesselID;
    public IGGuid RecoveryLocation;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselRecoveredMessage() => throw null;
  }
}
