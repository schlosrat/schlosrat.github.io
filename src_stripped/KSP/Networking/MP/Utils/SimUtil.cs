// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.SimUtil
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Networking.MP.Utils
{
  public class SimUtil
  {
    public const float TRANSLATE_NORMAL_SCALE_XY = 2f;
    public const float TRANSLATE_NORMAL_SCALE_Z = 5f;
    public const float TRANSLATE_SLOW_SCALE_XY = 0.5f;
    public const float TRANSLATE_SLOW_SCALE_Z = 1.25f;
    public const float TRANSLATE_MEDIUM_SCALE_XY = 20f;
    public const float TRANSLATE_MEDIUM_SCALE_Z = 50f;
    public const float TRANSLATE_FAST_SCALE_XY = 200f;
    public const float TRANSLATE_FAST_SCALE_Z = 500f;
    public const float ROTATE_NORMAL_DELTA_ANGLE = 5f;
    public const float ROTATE_SLOW_DELTA_ANGLE = 1.25f;
    public const float ROTATE_MEDIUM_DELTA_ANGLE = 45f;
    public const float ROTATE_FAST_DELTA_ANGLE = 90f;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDebugVectorString(Vector3d vector3d) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetDebugVectorString(Vector vector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetCoordinateSystemDebugString(ICoordinateSystem coordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SimulationObjectModel FindSimulationObjectModelByGlobalId(IGGuid globalId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ObjectComponent FindObjectComponent(
      IGGuid simObjectModelGlobalId,
      string objectComponentTypeString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ModuleData FindModuleDataInPartComponent(
      PartComponent partComponent,
      string pcmSystemTypeString,
      string moduleSystemTypeString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static ModuleData FindModuleData(
      IGGuid simObjectModelGlobalId,
      string pcmSystemTypeString,
      string moduleSystemTypeString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoopThroughTopLevelChildrenPartModels(
      SimulationObjectModel simulationObjectModel,
      SimUtil.LoopThroughTopLevelChildrenPartModelsCallback cb)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSimulationObjectModelTypeString(
      SimulationObjectModel simulationObjectModel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetVesselIndexAndCountForPlayer(
      string ownerPlayerGuidString,
      SimulationObjectModel selectedVesselOrNull,
      out int selectedIndexOut,
      out int numVesselsForThisPlayerOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void LoopThroughAllSimulationObjectModels(
      string matchFilterString,
      SimUtil.SimObjectModelLoopThroughCallback callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void LoopThroughAllCelestialBodiesSimulationObjectModels(
      string matchFilterString,
      SimUtil.SimObjectModelLoopThroughCallback callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoopThroughAllVesselSimulationObjectModels(
      string matchFilterString,
      SimUtil.SimObjectModelLoopThroughCallback callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoopThroughAllPartsSimulationObjectModels(
      string matchFilterString,
      SimUtil.SimObjectModelLoopThroughCallback callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoopThroughAllVesselsAndPartsSimulationObjectModels(
      string matchFilterString,
      SimUtil.SimObjectModelLoopThroughCallback callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoopThroughAllMiscSimulationObjectModels(
      string matchFilterString,
      SimUtil.SimObjectModelLoopThroughCallback callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoopThroughAllSimulationObjectModels(
      SimUtil.SimObjectModelLoopMode simObjectModelLoopMode,
      string matchFilterString,
      SimUtil.SimObjectModelLoopThroughCallback callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetSimObjectModelCount(
      SimUtil.SimObjectModelLoopMode simObjectModelLoopMode,
      string matchFilterString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LoopThroughSimulationObjectModelParts(
      SimulationObjectModel simulationObjectModel,
      Action<SimulationObjectModel, PartComponent> callback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void PotentiallyInvalidatePlayerIdForSimObjectModel(
      SimulationObjectModel simulationObjectModel,
      byte playerId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void InvalidatePlayerId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void PotentiallyApplyPlayerIdForPlayerToSimulationObjectModel(
      byte playerId,
      string playerGuidString,
      SimulationObjectModel simulationObjectModel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyPlayerIdForPlayerToSim(byte playerId, string playerGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool GetScreenCoordinateOfSimulationObjectModel(
      SimulationObjectModel simObject,
      out Vector3 screenPoint)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetSimObjectModelPartsCount(SimulationObjectModel simulationObjectModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetSimObjectModelComponentsCount(SimulationObjectModel simulationObjectModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SimulationObjectModel> FindSimObjectsOrNull(
      SimUtil.SimObjectFindMode simObjectFindMode,
      string playerGuidString = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SimulationObjectModel> FindAllCelestialBodiesOrNull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SimulationObjectModel> FindAllVesselsOrNull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SimulationObjectModel> FindMyVesselsOrNull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SimulationObjectModel> FindOtherPlayersVesselsOrNull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SimulationObjectModel> FindOfflinePlayersVesselsOrNull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SimulationObjectModel> FindOfflineOrNotReadyYetOnlinePlayerVesselsOrNull() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<SimulationObjectModel> FindSpecificPlayersVesselsOrNull(
      string playerGuidString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SimulationObjectModel FindMyCurrentFlightCameraModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SimulationObjectModel GetMyCurrentSimulationObjectModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SelectFlightCameraModel(SimulationObjectModel simulationObjectModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void GetFlightCameraModelListInfo(
      List<SimulationObjectModel> modelList,
      SimulationObjectModel model,
      out int indexOut,
      out int numItemsOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanSelectFlightCameraModelPrev(
      List<SimulationObjectModel> modelList,
      SimulationObjectModel model)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SelectFlightCameraModelPrev(
      List<SimulationObjectModel> modelList,
      SimulationObjectModel model)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanSelectFlightCameraModelNext(
      List<SimulationObjectModel> modelList,
      SimulationObjectModel model)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool SelectFlightCameraModelNext(
      List<SimulationObjectModel> modelList,
      SimulationObjectModel model)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3d GetTranslateDirectionEnumVector(
      SimulationObjectModel simulationObjectModel,
      SimUtil.TranslateDirectionEnum translateDirectionEnum,
      double scale = 1.0)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Vector3d GetPosInParent(SimulationObjectModel simulationObjectModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetPosInParent(SimulationObjectModel simulationObjectModel, Vector3d pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ModelTranslate(SimulationObjectModel simulationObjectModel, Vector3d delta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ModelTranslate(
      SimulationObjectModel simulationObjectModel,
      SimUtil.TranslateDirectionEnum translateDirectionEnum,
      float scale)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RotateQuat(
      ref QuaternionD quatRef,
      SimUtil.RotateDirectionEnum rotateDirectionEnum,
      float deltaAngle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static QuaternionD GetOrientationInParent(SimulationObjectModel simulationObjectModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetOrientationInParent(
      SimulationObjectModel simulationObjectModel,
      QuaternionD quat)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ModelRotate(
      SimulationObjectModel simulationObjectModel,
      SimUtil.RotateDirectionEnum rotateDirectionEnum,
      float deltaAngle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ModelZeroOutVelocity(SimulationObjectModel simulationObjectModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ModelZeroOutAngularVelocity(SimulationObjectModel simulationObjectModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool ModelZeroOutVelocityAndAngularVelocity(
      SimulationObjectModel simulationObjectModel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool RemoveOurVesselMaybe(SimulationObjectModel simulationObjectModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetNumPlayerVesselsThatHaveGameObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetSpawnNearOffset(
      Vector3 position,
      Quaternion rotation,
      float distance,
      float angle,
      out Vector3 offsetOut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TeleportVessel(
      TeleportVesselMethod teleportVesselMethod,
      SimulationObjectModel simObjectModelSrc,
      SimulationObjectModel simObjectModelDest,
      float distance,
      float angle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DeleteAllSimObjectModelsInList(List<SimulationObjectModel> simObjectModelList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DeletePlayerOwnedObjectsForSpecificPlayer(
      string playerGuidString,
      bool propagate = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DeletePlayerOwnedObjectsForAllPlayers(bool propagate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HaveAuthorityOverThisVesselForMP(SimulationObjectModel simObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimUtil() => throw null;

    public delegate bool LoopThroughTopLevelChildrenPartModelsCallback(
      SimulationObjectModel simulationObjectModel);

    public enum SimObjectFindMode
    {
      None,
      CelestialBodies,
      AllVessels,
      MyVessels,
      OtherPlayerVessels,
      OfflinePlayerVessels,
      OfflineOrNotReadyYetOnlinePlayerVessels,
      SpecificPlayersVessels,
    }

    public enum TranslateDirectionEnum
    {
      None,
      NegativeX,
      PositiveX,
      NegativeY,
      PositiveY,
      NegativeZ,
      PositiveZ,
      Forward,
      Backward,
      Left,
      Right,
      Up,
      Down,
    }

    public enum RotateDirectionEnum
    {
      None,
      NegativeX,
      PositiveX,
      NegativeY,
      PositiveY,
      NegativeZ,
      PositiveZ,
    }

    public enum SimObjectModelLoopMode
    {
      None,
      All,
      CelestialBodies,
      Vessels,
      Parts,
      VesselsAndParts,
      Misc,
    }

    public delegate void SimObjectModelLoopThroughCallback(
      SimulationObjectModel simulationObjectModel);
  }
}
