// Decompiled with JetBrains decompiler
// Type: KSP.Game.Colonies.DeliveryRoute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Game.Colonies
{
  public class DeliveryRoute
  {
    private int _deliveryRouteID;
    private DeliveryRoute.RouteStatus _routeStatus;
    private bool _pausePending;
    private IGGuid _originatingColonyGUID;
    private IGGuid _destinationColonyGUID;
    private double _totalMissionTime;
    private double _missionTimeToDestination;
    private double _currentMissionLaunchTime;
    public ResourceSnapshot OriginCost;
    public ResourceSnapshot DeliveryToDestination;
    public ResourceSnapshot DeliveryToOrigin;

    public int DeliveryRouteID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public DeliveryRoute.RouteStatus Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool PausePending
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

    public double TotalMissionTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double MissionTimeToDestination
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double CurrentMissionLaunchTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeFromFlight(ActiveFlight flight, int routeID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LaunchRoute() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LeaveDestination() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReturnToOrigin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyResourcesToColony(IGGuid target, ResourceSnapshot snapshot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Pause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPausePending(bool pause) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeliveryRoute() => throw null;

    public enum RouteStatus : byte
    {
      Invalid,
      ReadyToLaunch,
      ProceedingToDestination,
      ReturningToOrigin,
      Paused,
    }
  }
}
