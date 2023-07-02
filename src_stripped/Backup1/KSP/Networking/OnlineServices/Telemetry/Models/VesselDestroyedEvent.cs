// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Telemetry.Models.VesselDestroyedEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Telemetry.Models
{
  public class VesselDestroyedEvent
  {
    public string MainCelestialBodyName;
    public double Longitude;
    public double Latitude;
    public double Altitude;
    public IGGuid VesselID;
    public MissionData CurrentMissionData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselDestroyedEvent() => throw null;
  }
}
