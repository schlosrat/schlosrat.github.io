// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Telemetry.Models.VesselEnteredSOIEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Telemetry.Models
{
  public class VesselEnteredSOIEvent
  {
    public IGGuid MainCelestialBodyID;
    public double Longitude;
    public double Latitude;
    public double Altitude;
    public IGGuid VesselID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselEnteredSOIEvent() => throw null;
  }
}
