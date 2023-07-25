// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.lua.SpaceSimulationLua
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ScriptInterop;
using KSP.Sim.State;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl.lua
{
  public class SpaceSimulationLua
  {
    private SpaceSimulation spaceSimulation;
    private IHandOfGodForces godForces;
    private IScriptEnvironment scriptEnvironment;
    private const double TELEPORT_MAGIC_NUMBER = 5000.0;
    private VesselComponent _pendingVesselTeleport;
    private SpaceSimulationLua.TeleportationType _pendingTeleport;
    private KeplerOrbitState _pendingOrbitTeleportData;
    private SpaceSimulationLua.SurfaceTeleportData _pendingSurfaceTeleportData;
    private SpaceSimulationLua.RendezvousTeleportData _pendingRendezvousTeleportData;
    private IScriptThread thread;

    private bool HaveDebugHud
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private ITypeInterop TypeInterop
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private ITypeWriter TypeWriter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SpaceSimulationLua(SpaceSimulation spaceSimulation, IHandOfGodForces godForces) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Action<string> WrapClosure(IScriptClosure callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<string, string> GetTypes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DebugWaitFor(float seconds, IScriptClosure callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator DebugWaitForCoroutine(float seconds, IScriptClosure callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TeleportToRendezvous(
      string guid,
      string target,
      double distanceX,
      double distanceY,
      double distanceZ,
      double pitchDeg,
      double yawDeg,
      double rollDeg)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineTeleportToRendezvous(
      VesselComponent vessel,
      SimulationObjectModel targetObject,
      Vector3d distance,
      Vector3d rotationDeg)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TeleportToOrbit(
      string guid,
      string celestialBodyGuid,
      double inclination,
      double eccentricity,
      double semiMajorAxis,
      double longitudeOfAscendingNode,
      double argumentOfPeriapsis,
      double meanAnomalyAtEpoch,
      double epoch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineTeleportToOrbit(
      VesselComponent vessel,
      string celestialBodyNameKey,
      double inclination,
      double eccentricity,
      double semiMajorAxis,
      double longitudeOfAscendingNode,
      double argumentOfPeriapsis,
      double meanAnomalyAtEpoch,
      double epoch)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TeleportToSurface(
      string guid,
      string celestialBodyGuid,
      double altitude,
      double latitude,
      double longitude,
      double verticalSpeed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator CoroutineTeleportToSurface(
      VesselComponent vessel,
      string celestialBodyNameKey,
      double altitude,
      double latitude,
      double longitude,
      double verticalSpeed)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalSpaceCelestialBodyLoaded(string bodyName, bool success) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SetLaunchSite(string launchSite) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double Debug_GetUniversalTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Debug_SetTimeScale(float timeScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float Debug_GetTimeScale() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool Debug_SetPhysicsMode(
      string simObjectGuid,
      string vesselPhysics,
      bool enablePhysX,
      bool enablePartUnpack)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DebugLog(string msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool HOG_ApplyImpulse(string simObjGuid, ForceState forceState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string HOG_CreateForce(string forceGuid, string simObjGuid, ForceState forceState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string HOG_CreateTorque(string forceGuid, string simObjGuid, ForceState forceState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HOG_SetLocalForce(string forceGuid, Vector3 forceValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HOG_SetLocalTorque(string forceGuid, Vector3 torqueValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HOG_Destroy(string forceGuid) => throw null;

    private struct SurfaceTeleportData
    {
      public string CelestialBodyName;
      public double Latitude;
      public double Longitude;
      public double AltitudeFromRadius;
      public double VerticalSpeed;
    }

    private struct RendezvousTeleportData
    {
      public SimulationObjectModel TargetObject;
      public Vector3d Distance;
      public Vector3d RotationDeg;
    }

    private enum TeleportationType : byte
    {
      None,
      Orbit,
      Surface,
      Rendezvous,
    }
  }
}
