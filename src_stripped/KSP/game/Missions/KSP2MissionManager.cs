// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.KSP2MissionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Missions.Definitions;
using KSP.Game.Missions.State;
using KSP.Messages;
using KSP.Networking.MP.Message;
using KSP.OAB;
using KSP.UI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game.Missions
{
  public class KSP2MissionManager : KerbalMonoBehaviour
  {
    public const string MISSIONS_ADDRESSABLE_LABEL = "missions";
    public const string LESSSONS_ADDRESSABLE_LABEL = "lesson";
    public const string TRAINING_CENTER_DIALOG_PREFAB = "TrainingCenter.prefab";
    public const string TUTORIAL_MESSAGE_BOX_PREFAB = "TutorialMessageBox.prefab";
    public const string TUTORIAL_SCREEN_VIDEO_PREFAB = "TutorialFullScreenVideo.prefab";
    public const string TUTORIALS_ADDRESSABLES_LABEL = "main_tutorial";
    private List<MissionData> _missionDefinitions;
    private List<KSP.Game.Missions.Definitions.ActiveMissions> _activeMissions;
    private Stack<MissionData> _missionsToAdd;
    private List<string> _completedTutorialsIds;
    private KSP2MissionLuaInterface luaInterface;
    private bool isReady;
    private bool _missionsInitialized;
    private TutorialsItems Tutorials;
    private readonly List<MainTutorialsItem> _tutorialItems;
    private readonly List<SubTutorialsItem> _subTutorialsItems;
    private readonly List<MissionData> _lessons;
    private bool _isInTutorial;
    private bool _transitioningToNextTutorial;
    private bool _restartingMission;
    private int _lastMissionPlayedOwnerId;
    private MissionOwner _lastMissionPlayedOwnerType;
    private string _lastMissionPlayedId;
    private static readonly GameState[] _statesToStopTimeWarp;
    private bool _revertActiveVesselInOAB;
    private List<string> _stringCacheList;
    private OABHistoricalSnapshot backedUpOABHistoricalSnapshot;
    private List<Tuple<TextAsset, Texture2D>> _workspacesToLoad;
    private const float COOLDOWN_RATE = 0.3f;
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
    private byte[] _missionReloadSnapshot;
    private int _reloadSnapshotCurrentStageIndex;
    private string _savedActiveCampaignName;
    private byte[] _saveGameData;

    public List<KSP.Game.Missions.Definitions.ActiveMissions> ActiveMissions
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

    private bool HasValidSaveBuffer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckForMyPlayersFTUEEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool RemoveMissionDataFromActiveMissions(
      KSP.Game.Missions.Definitions.ActiveMissions activeMissions,
      MissionData missionData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetActiveTutorial(
      out MissionData tutorialData,
      out KSP.Game.Missions.Definitions.ActiveMissions activeMissions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TryActivateMission(MissionData mission) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<MissionData> GetMissionDefinitions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNewActiveMission(MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNewActiveMission(string missionID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMissionDataItemLoaded(TextAsset textAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MainTutorialsItem[] GetTutorials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubTutorialsItem[] GetLessons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadTutorials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialAssetLoaded(TextAsset tutorialTextAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FillLessons() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLessonAssetLoaded(TextAsset lessonTextAsset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<MissionData> GetCompletedTutorialsList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadTutorialAndFTUEProgress() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TryActivateMissions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeActiveMissions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReloadSnapshot(MissionData missionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateReloadSnapshot(int currentStageIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMissionState(
      string missionID,
      MissionState state,
      Action onMissionCompleteCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetMissionState(MissionOwner owner, int ownerID, string missionID) => throw null;

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
    public void ResetAllActiveMissions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AbortTutorialCallback(bool success, Action onCompletedCallback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AbortTutorial(bool reloadPriorState = false, Action onCompleteCallback = null) => throw null;

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
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStartGameShutdown(MessageCenterMessage msg) => throw null;

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
    public void OnReloadSnapshotCreated(
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket,
      bool success)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBackupViewState(UIView view) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TransitionToTrainingCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideDialogsAndStopTimewarp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TriggerMissionMPAction(MissionMPActionData missionMPActionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ProcessMissionMPAction(MissionMPActionData missionMPActionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetActiveTutorial(string misisonID, out MissionData tutorialMissionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSP2MissionManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static KSP2MissionManager() => throw null;
  }
}
