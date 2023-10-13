// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.SaveLoadMissionUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Missions.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  public static class SaveLoadMissionUtils
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetMissionDataByID(
      List<MissionData> missionDataList,
      string missionID,
      out MissionData missionData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void AddOrOverwriteMissionData(
      GameInstance gameInstance,
      List<MissionData> missionDataList,
      MissionData missionDataDefinition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int GetMissionDataOwnerId(GameInstance gameInstance, MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MergeMissionDataProgress(MissionData fromData, MissionData toData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryAddActiveMissions(
      GameInstance gameInstance,
      List<ActiveMissions> activeMissions,
      List<MissionData> missionDatas)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryAddNewActiveMission(
      GameInstance gameInstance,
      List<ActiveMissions> activeMissions,
      MissionData missionData,
      out MissionData newActiveMissionData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryDeactivateMission(List<ActiveMissions> activeMissions, string missionId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool TryGetActiveMissions(
      int ownerID,
      List<MissionSaveData> missionSaveDatas,
      List<MissionData> missionDefinitions,
      out List<MissionData> missionDatas)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool TryGetCompletedStagesPerOwnerID(
      int ownerID,
      CompletedStages[] completedStages,
      out CompletedStages target)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetMissionsDatasFromActiveMissions(
      List<ActiveMissions> activeMissions,
      out List<MissionData> missionDatas)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SaveMissionState(
      GameInstance gameInstance,
      MissionData missionData,
      bool isActive,
      bool completed,
      bool available = false,
      bool turnedIn = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetMissionSaveData(
      List<MissionSaveData> missionSaveDatas,
      string missionId,
      out MissionSaveData missionSaveData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryCreateNewMissionSaveData(
      string missionId,
      int playerId,
      out MissionSaveData missionSaveData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void RecordMissionProgress(
      MissionData missionData,
      int playerId,
      MissionSaveData missionSaveData,
      bool isActive,
      bool isAvailable,
      bool isCompleted,
      bool turnedIn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetCompletedFTUEorTutorial(
      CampaignPlayerEntry playerEntry,
      MissionType missionType,
      string missionId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool TryGetCompletedTutorials(
      CampaignPlayerEntry playerEntry,
      List<MissionData> missions,
      out List<MissionData> completedTutorials)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void TrackMission(GameInstance gameInstance, MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnTrackMission(GameInstance gameInstance, MissionData missionData) => throw null;
  }
}
