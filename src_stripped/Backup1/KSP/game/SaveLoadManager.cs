// Decompiled with JetBrains decompiler
// Type: KSP.Game.SaveLoadManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Contexts.Game;
using KSP.Game.Flow;
using KSP.Game.Load;
using KSP.IO;
using KSP.Sim;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class SaveLoadManager : KerbalMonoBehaviour
  {
    public static readonly string FILE_VERSION;
    public const string SAVE_LOAD_DIALOG_PREFAB = "SaveLoadGameDialog.prefab";
    public const string LAUNCHPAD_DIALOG_PREFAB = "LaunchpadDialog.prefab";
    private const string YEAR_TIME = "HUD/Year";
    private const string DAYS_TIME = "HUD/days";
    private const string HOURS_TIME = "Unit/Symbol/Hours";
    private const string MINUTES_TIME = "Unit/Symbol/Minutes";
    private const string NOTIFICATION_QUICKSAVED = "NotificationEvent/IO/QuickSaved";
    private bool _isSaving;
    private bool _isLoading;
    private bool _isLoaded;
    private Stopwatch _loadingStopwatch;
    private NotificationData _quickSaveNotificationData;
    private float _secondsSinceLastAutoSave;
    private readonly Dictionary<SaveLoadManager.AutoSaveEvents, SaveLoadManager.AutoSaveStatus> _autoSaveStatusByEvent;
    private SaveGameMetadataLoader _saveGameMetadataLoader;
    private SaveGameThumbnailCreator _saveGameThumbnailCreator;
    private Coroutine _extendedSaveFileInfoLoaderRoutine;
    private DirectoryInfo[] _singlePlayerDirectoryInfos;
    private DirectoryInfo[] _multiPlayerDirectoryInfos;
    private static readonly Comparison<IOProvider.IGFileInfo> s_fileLastWriteTimeComparison;
    private static readonly Comparison<SaveFileInfo> s_saveFileInfoLastWriteTimeComparison;
    private static readonly Comparison<IOProvider.IGFileInfo> s_fileFullNameComparison;

    public bool IsSaving
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLoading
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLoaded
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearIsLoadedFlag() => throw null;

    public SaveGameThumbnailCreator ThumbnailCreator
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCampaignFolderPath(CampaignType campaignType, string campaignName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CampaignExists(CampaignType campaignType, string campaignName) => throw null;

    public string ActiveCampaignFolderPath
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetActiveCampaignWorkspaceFolderPath() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LoadDependentPrefabs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<SaveFileInfo> GetSaveFileInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<SaveFileInfo> GetSaveFileInfo(string campaignFolder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<SaveFileInfo> GetSaveFileInfo(string campaignFolder, string searchPattern) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetExtendedSaveFileInfo(
      string campaignFolder,
      SaveLoadManager.ExtendedSaveFileLoadFinishedDelegate finished)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator LoadExtendedSaveFileInfo(
      string campaignFolder,
      SaveLoadManager.ExtendedSaveFileLoadFinishedDelegate finished)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<List<SaveFileInfo>> GetCampaignSaveFiles(CampaignType campaignType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsValidGameStateForSave() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnQuickSave() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnQuickLoad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnQuickLoadHold() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ResetAutoSaveEventTimes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AutoSave(
      SaveLoadManager.AutoSaveEvents autoSaveEvent,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SaveInternal(
      SavedGameType saveType,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetLatestFilePathFromCampaign(
      string campaignName,
      CampaignType campaignType,
      out string path)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void QuickLoadInternal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetSaveTypePrefix(SavedGameType saveType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNextSaveIndex(SavedGameType saveType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetHighestSaveIndex(SavedGameType saveType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateCampaignFolder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateCampaignWorkspacesFolder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerSuccess(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerFailure(
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket,
      LoadOrSaveCampaignFailureCode loadOrSaveCampaignFailureCode,
      bool force = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool StartLoadOrSaveOperation(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PrivateLoadGameFromAsset(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PrivateLoadGameFromAddressable(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PrivateLoadGameFromBuffer(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PrivateLoadGameFromFile(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PrivateLoadPlayerDataFromBuffer(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoadGameMetadataFromFile(
      string filepath,
      SaveLoadManager.GameMetadataFinishedDelegate finishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PrivateSaveGameToFile(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PrivateSaveGameToMemory(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PrivateSaveSpecificPlayerToFileOrMemory(
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DeleteSaveFile(
      string filepath,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PrivateDeleteSaveFile(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool DeleteDirectory(
      string filepath,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool PrivateDeleteDirectory(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsBusy(bool logErrorIfBusy, out BusyCode busyCodeOut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLoadStarting() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnLoadEnding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSaveStarting() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSaveEnding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsBusy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CheckLoadingAndSavingFlags(LoadOrSaveCampaignTicket loadOrSaveCampaignTicket) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrivateSaveCommon(
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket,
      SequentialFlow savingFlow)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrivateLoadCommonAfterFade(
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket,
      LoadGameData loadGameData,
      SequentialFlow loadingFlow,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrivateLoadCommon(
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket,
      LoadGameData loadGameData,
      SequentialFlow loadingFlow,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PrivateLoadAdditive(
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket,
      LoadGameData loadGameData,
      SequentialFlow loadingFlow,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void OnLoadingFlowUpdate(object obj, float progress) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LoadGameFromAsset(
      GameModeData gameModeData,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LoadGameFromFile(
      string loadFileName,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LoadGameFromBuffer(
      byte[] sourceJsonBuffer,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback,
      CurtainContext curtainContextOverride = CurtainContext.EnterGamePlay)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LoadGameFromAddressable(
      string addressableAssetKey,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SaveGameToFile(
      string filepath,
      SavedGameType savedGameType,
      bool saveOverwriteFileIfExists,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SaveGameToMemory(
      SaveJsonFormatting saveJsonFormatting,
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogMessage(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void LogError(string error) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetField<T>(
      string fieldName,
      object value,
      ref T @object,
      ref Dictionary<string, FieldInfo> fieldInfoCache)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string ConvertSecondsToGameTime(double time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CompareToLastWriteTimeUtc(IOProvider.IGFileInfo f1, IOProvider.IGFileInfo f2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CompareToSaveFileLastWriteTimeUtc(SaveFileInfo f1, SaveFileInfo f2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CompareToFileFullName(IOProvider.IGFileInfo f1, IOProvider.IGFileInfo f2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SaveLoadManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SaveLoadManager() => throw null;

    public delegate void GameMetadataFinishedDelegate(
      bool success,
      SerializedSaveGameMetadata metadata);

    public delegate void ExtendedSaveFileLoadFinishedDelegate(
      bool success,
      List<ExtendedSaveFileInfo> saveFileData);

    public enum AutoSaveEvents
    {
      LaunchURILoad,
      CampaignCreationAtMainMenu,
      CampaignExitToMainMenu,
      MissionComplete,
      SOIChange,
      AtmosphereTransition,
      VesselLanded,
      VesselSplashed,
    }

    private class AutoSaveStatus
    {
      private readonly SaveLoadManager.AutoSaveEvents _eventType;
      private bool _hasSaved;
      private float _realtimeSinceStartupOfLastSave;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AutoSaveStatus(SaveLoadManager.AutoSaveEvents eventType) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool ShouldSave() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void UpdateSaveTime(float realTimeSinceStartup) => throw null;
    }
  }
}
