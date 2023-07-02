// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Telemetry.Models.VesselEnteredSOIEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Telemetry.Models
{
  public class VesselEnteredSOIEvent
  {
    public string MainCelestialBodyName;
    public double Longitude;
    public double Latitude;
    public double Altitude;
    public IGGuid VesselID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselEnteredSOIEvent() => throw null;
  }
}
