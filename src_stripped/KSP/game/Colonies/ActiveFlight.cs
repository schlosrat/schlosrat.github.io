// Decompiled with JetBrains decompiler
// Type: KSP.Game.Colonies.ActiveFlight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Game.Colonies
{
  public class ActiveFlight
  {
    private int _activeFlightID;
    private ActiveFlight.FlightStatus _flightStatus;
    private IGGuid _vesselGUID;
    private IGGuid _originatingColonyGUID;
    private IGGuid _destinationColonyGUID;
    public ResourceSnapshot InitialResources;
    public ResourceSnapshot PreDestinationResources;
    public ResourceSnapshot PostDestinationResources;
    public ResourceSnapshot FinalResources;
    private double _missionTimeAtLaunch;
    private double _missionTimeAtDestination;
    private double _missionTimeAtRecovery;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int ActiveFlightID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ActiveFlight.FlightStatus Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGGuid VesselGUID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGGuid OriginatingColonyGUID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IGGuid DestinationColonyGUID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double MissionTimeAtLaunch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double MissionTimeAtDestination
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double MissionTimeAtRecovery
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(int activeFlightID, IGGuid vesselGUID, IGGuid originatingColonyGUID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RevertToLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDockedAtDestination(IGGuid destination) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LaunchFromDestination() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RecoverAtOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateResourceDeltas() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GenerateResourceSnapshot(ref ResourceSnapshot snapshot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActiveFlight() => throw null;

    public enum FlightStatus : byte
    {
      Invalid,
      ProceedingToDestination,
      DockedAtDestination,
      ReturningToOrigin,
      Complete,
      Failed,
    }
  }
}
