// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.KSP2MissionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using KSP.Game.Missions.State;
using KSP.Messages;
using KSP.OAB;
using KSP.Sim;
using KSP.UI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Missions
{
  public class KSP2MissionManager : KerbalMonoBehaviour
  {
    public const string DIALOG_PREFAB = "TrainingCenter.prefab";
    private List<string> _baseGlobalMissionJsonStringList;
    private List<string> _baseAgencyMissionJsonStringList;
    private List<string> _basePlayerMissionJsonStringList;
    private List<MissionData> _baseGlobalMissionDataList;
    private List<MissionData> _baseAgencyMissionDataList;
    private List<MissionData> _basePlayerMissionDataList;
    private List<MissionData> missions;
    private string _completedTutorialIDs;
    private List<MissionData> _completedTutorials;
    private List<MissionData> _completedMissions;
    private KSP2MissionLuaInterface luaInterface;
    private KSP2MissionUI missionUI;
    private bool isReady;
    private bool _missionsInitialized;
    private string _currentTutorialMissionSave;
    private TutorialsItems Tutorials;
    private bool _isInTutorial;
    private bool _tutorialMode;
    private bool _transitioningToNextTutorial;
    private bool _restartingMission;
    private string _lastMissionIDPlayed;
    private static readonly GameState[] _statesToStopTimeWarp;
    private bool _revertActiveVesselInOAB;
    private OABHistoricalSnapshot backedUpOABHistoricalSnapshot;
    private MissionData _activeMission;
    private MissionData _completedMission;
    private List<Tuple<TextAsset, Texture2D>> _workspacesToLoad;
    private readonly List<MainTutorialsItem> _tutorialItems;
    private readonly List<SubTutorialsItem> _subTutorialsItems;
    private readonly List<MissionData> _lessons;
    private float cooldownRate;
    private float _cachedCooldownTime;
    private UIView _backupViewState;
    public float heavypropertyCooldownRate;
    public float HeavyPropertyCooldownTime;
    private bool _isMyPlayersFTUEEnabled;
    private SubscriptionHandle _onToggleMissionUI;
    private SubscriptionHandle _onAbortTutorial;
    private SubscriptionHandle _onShuttingDownGameHandle;
    private SubscriptionHandle _onGameStateChangedHandle;
    private SubscriptionHandle _onMapModeChangedHandle;
    private SubscriptionHandle _onQuitToMainMenuHandle;
    private MissionData _crossLoadMission;
    private byte[] _missionReloadSnapshot;
    private string _savedActiveCampaignName;
    private byte[] _saveGameData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetStringList(ref List<string> dest, List<string> src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ImportMissionJsonStringList(
      List<MissionData> missionDataList,
      List<string> src)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static MissionData FindMissionDataByID(List<MissionData> missionDataList, string id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ApplyMissionSaveDataToList(
      List<MissionData> missionDataList,
      List<MissionData> src)
    {
      throw null;
    }

    public List<string> BaseGlobalMissionJsonStringList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<string> BaseAgencyMissionJsonStringList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<string> BasePlayerMissionJsonStringList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<MissionData> BaseGlobalMissionDataList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<MissionData> BaseAgencyMissionDataList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<MissionData> BasePlayerMissionDataList
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBaseGlobalMissionJsonStringList(List<string> src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBaseAgencyMissionJsonStringList(List<string> src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBasePlayerMissionJsonStringList(List<string> src) => throw null;

    public List<MissionData> Missions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string CompletedTutorialIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsReady
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool MissionsInitialized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] protected set => throw null;
    }

    public bool IsInTutorial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool RevertActiveVesselInOAB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public OABHistoricalSnapshot BackedUpOABHistoricalSnapshot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMyPlayersFTUEEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MissionData ActiveMission
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MissionData CompletedMission
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool HasValidSaveBuffer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckForMyPlayersFTUEEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadMissions(MissionData mission) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryActivateMission(MissionData mission) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ref List<MissionData> GetMissions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetMissionData(string missionID, out MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadTutorials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialAssetLoaded(TextAsset tutorialTextAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillLessons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLessonAssetLoaded(TextAsset lessonTextAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MainTutorialsItem[] GetTutorials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubTutorialsItem[] GetLessons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<MissionData> GetCompletedMissionsList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<MissionData> GetCompletedTutorialsList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyTutorialProgress() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ApplyProgressFromSavedGame(SerializedSavedGame data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeMissions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void MergeMissionDataProgress(MissionData fromData, MissionData toData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SaveProgressToSavedGame(SerializedSavedGame data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateTutorialsProgressToCampaignPlayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateReloadSnapshot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnReloadSnapshotCreated(
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket,
      bool success)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReloadSnapshot(string missionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ActivateMission(string missionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMissionState(
      string missionID,
      MissionState state,
      Action onMissionCompleteCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetMissionState(string missionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadTutorialSave(
      string saveFileAssetKey,
      MissionData caller,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadTutorialSaveInternal(
      string saveFileAssetKey,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ExitTutorialSave(Action onCompleteCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBackCachedActiveCampaignName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllMissions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AbortTutorialCallback(bool success, Action onCompletedCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AbortTutorial(bool reloadPriorState = false, Action onCompleteCallback = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetCompletedTutorials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AbortTutorialMessageHandler(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGameStateChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapModeChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnQuitToMainMenu(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RestoreBackupViewState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTutorialModeStarted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTutorialModeEnded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReplayTutorial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PlayNextTutorial(string nextMissionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStartGameShutdown(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleMissionUI(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BackupOABHistoricalSnapshot(OABHistoricalSnapshot snapshot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteBackupOABHistoricalSnapshot() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionSummaryActionDismissed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTutorialWorkspaceToLoad(Tuple<TextAsset, Texture2D> workspace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetTutorialWorkspacesToLoad(
      out List<Tuple<TextAsset, Texture2D>> workspacesToLoad)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearTutorialWorkspacestoLoad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBackupViewState(UIView view) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TransitionToTrainingCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideDialogsAndStopTimewarp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2MissionManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static KSP2MissionManager() => throw null;
  }
}
