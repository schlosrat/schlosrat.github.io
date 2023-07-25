﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselRecoverableMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Vessel/VesselRecoverableMessage", false, "Players active/inactive vessel can be recovered", "")]
  public class VesselRecoverableMessage : FlightMessageBase
  {
    public IGGuid VesselID;
    public IGGuid RecoveryLocation;
    public VesselComponent VesselComp;
    public SimulationObjectModel SimulationObject;
    public bool isActiveVessel;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselRecoverableMessage() => throw null;
  }
}
