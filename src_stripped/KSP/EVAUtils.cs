// Decompiled with JetBrains decompiler
// Type: KSP.EVAUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP
{
  public static class EVAUtils
  {
    private const float LADDER_SAFE_POS_OFFSET_Y = 0.1f;
    private const float LADDER_AIRLOCK_SAFE_POS_OFFSET_Z = -0.2f;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanBoardPart(PartBehavior part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryStartEVA(PartBehavior partBehavior, int seatIdx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryStopEVA(IGGuid kerbalVesselId, IGGuid kerbalId, PartBehavior part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void StopEVA(IGGuid kerbalGuid, IGGuid vesselGuid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SimulationObjectModel CreateKerbalSimObject(
      SimulationObjectModel vesselSimObject,
      PartBehavior vesselPartBehavior,
      KerbalInfo kerbalInfo,
      int seatIdx,
      Action<IGGuid> createdCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SimulationObjectModel CreateKerbalSimObject(
      Position spawnPos,
      Rotation spawnRot,
      KerbalInfo kerbalInfo,
      int seatIdx,
      Action<IGGuid> createdCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SimulationObjectModel CreateKerbalSimObject(
      SerializedLocation location,
      KerbalInfo kerbalInfo,
      int seatIdx,
      Action<IGGuid> createdCallback,
      bool createdFromEVA = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateFlagSimObject(
      FlagComponentDefinition definition,
      SimulationObjectModel kerbalSimObject,
      Action<IGGuid> modelCreatedCallback,
      Action<SimulationObjectView> viewCreatedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CreateFlagSimObject(
      FlagComponentDefinition definition,
      SerializedLocation location,
      Action<IGGuid> modelCreatedCallback,
      Action<SimulationObjectView> viewCreatedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetFirstLadderOrAirlockPhysicsSpacePosRot(
      PartBehavior vesselPartBehavior,
      bool applySpawnOffset,
      out Vector3 position,
      out Quaternion rotation)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3 GetColliderTopPos(Collider collider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool GetFirstLadderOrAirlockLocalPosRot(
      SimulationObjectModel vesselSimObject,
      PartBehavior vesselPartBehavior,
      out Vector3d localPos,
      out QuaternionD localRot)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SerializedLocation ComputeOrbitLocation(
      SimulationObjectModel vesselSimObject,
      PartBehavior vesselPartBehavior)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SerializedLocation ComputeOrbitLocation(Position spawnPos, Rotation spawnRot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SerializedLocation ComputeOrbitLocation(
      Position position,
      Velocity velocity,
      CelestialBodyComponent celestialBodyComponent,
      SerializedRigidbodyState? serializedRigidbodyState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SerializedLocation ComputeFlagLocation(SimulationObjectModel kerbalSimObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetActiveVesselSimObject(SimulationObjectModel vesselSimObject) => throw null;
  }
}
