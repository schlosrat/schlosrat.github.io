// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Telemetry.Models.VesselLandedEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Networking.OnlineServices.Telemetry.Models
{
  public class VesselLandedEvent
  {
    public IGGuid LandingObjectID;
    public double Longitude;
    public double Latitude;
    public double Altitude;
    public bool IsSplash;
    public IGGuid VesselID;
    public MissionData CurrentMissionData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselLandedEvent() => throw null;
  }
}
