// Decompiled with JetBrains decompiler
// Type: KSP.Game.LoadOrSaveCampaignTicket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Contexts.Game;
using KSP.Game.Load;
using KSP.Sim;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  public class LoadOrSaveCampaignTicket
  {
    public const LoadOrSaveCampaignStatus DEFAULT_LOAD_OR_SAVE_CAMPAIGN_STATUS = LoadOrSaveCampaignStatus.Unknown;
    public const LoadOrSaveCampaignFailureCode DEFAULT_LOAD_OR_SAVE_CAMPAIGN_FAILURE_CODE = LoadOrSaveCampaignFailureCode.None;
    public const LoadOrSaveCampaignOperation DEFAULT_LOAD_OR_SAVE_CAMPAIGN_OPERATION = LoadOrSaveCampaignOperation.None;
    public const string DEFAULT_CAMPAIGN_NAME = "";
    public const CampaignType DEFAULT_CAMPAIGN_TYPE = CampaignType.None;
    public const bool DEFAULT_CAMPAIGN_READ_ONLY_FLAG = false;
    public const string DEFAULT_CAMPAIGN_DESCRIPTION = "";
    public static readonly byte[] DEFAULT_SOURCE_JSON_BUFFER;
    public const string DEFAULT_ADDRESSABLE_ASSET_KEY = "";
    public const string DEFAULT_LOAD_FILE_NAME = "";
    public const bool DEFAULT_INITIALIZE_AS_NEW_CAMPAIGN = false;
    public const string DEFAULT_SAVE_FILE_NAME = "";
    public const SavedGameType DEFAULT_SAVED_GAME_TYPE = SavedGameType.Invalid;
    public const bool DEFAULT_SAVE_OVERWRITE_FILE_IF_EXISTS = false;
    public const SaveJsonFormatting DEFAULT_SAVE_JSON_FORMATTING = SaveJsonFormatting.None;
    public static readonly byte[] DEFAULT_NEW_JSON_BUFFER;
    public const byte DEFAULT_PLAYER_ID = 0;
    public const OnLoadOrSaveCampaignFinishedCallback DEFAULT_ON_LOAD_OR_SAVE_CAMPAIGN_FINISHED_CALLBACK = null;
    public const object DEFAULT_CUSTOM_DATA_OBJECT = null;
    public const CurtainContext DEFAULT_CURTAIN_CONTEXT = CurtainContext.None;
    private LoadOrSaveCampaignStatus _loadOrSaveCampaignStatus;
    private LoadOrSaveCampaignFailureCode _loadOrSaveCampaignFailureCode;
    private LoadOrSaveCampaignOperation _loadOrSaveCampaignOperation;
    private string _campaignName;
    private CampaignType _campaignType;
    private bool _campaignReadOnlyFlag;
    private string _campaignDescription;
    private GameModeData _gameModeData;
    private string _gameMode;
    private byte[] _sourceJsonBuffer;
    private string _addressableAssetKey;
    private string _loadFileName;
    private bool _initializeAsNewCampaign;
    private NewGameSetupInfo _newGameSetupInfo;
    private NewPlayerSetupInfo _newPlayerSetupInfo;
    private string _saveFileName;
    private SavedGameType _savedGameType;
    private bool _saveOverwriteFileIfExists;
    private SaveJsonFormatting _saveJsonFormatting;
    private byte[] _newJsonBuffer;
    private byte _playerId;
    private OnLoadOrSaveCampaignFinishedCallback _onLoadOrSaveCampaignFinishedCallback;
    private object _customDataObject;
    private CurtainContext _loadingScreenCurtainContext;
    private LoadGameData _loadGameData;
    private long _timeStampStarted;
    private int _ms;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public LoadOrSaveCampaignStatus LoadOrSaveCampaignStatus
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLoadOrSaveCampaignStatus(LoadOrSaveCampaignStatus loadOrSaveCampaignStatus) => throw null;

    public LoadOrSaveCampaignFailureCode LoadOrSaveCampaignFailureCode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLoadOrSaveCampaignFailureCode(
      LoadOrSaveCampaignFailureCode loadOrSaveCampaignFailureCode)
    {
      throw null;
    }

    public LoadOrSaveCampaignOperation LoadOrSaveCampaignOperation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLoadOrSaveCampaignOperation(
      LoadOrSaveCampaignOperation loadOrSaveCampaignOperation)
    {
      throw null;
    }

    public string CampaignName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCampaignName(string campaignName) => throw null;

    public CampaignType CampaignType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCampaignType(CampaignType campaignType) => throw null;

    public bool CampaignReadOnlyFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCampaignReadOnlyFlag(bool campaignReadOnlyFlag) => throw null;

    public string CampaignDescription
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCampaignDescription(string campaignDescription) => throw null;

    public GameModeData GameModeData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGameModeData(GameModeData gameModeData) => throw null;

    public string GameMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGameMode(string gameMode) => throw null;

    public byte[] SourceJsonBuffer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSourceJsonBuffer(byte[] sourceJsonBuffer) => throw null;

    public string AddressableAssetKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAddressableAssetKey(string addressableAssetKey) => throw null;

    public string LoadFileName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLoadFileName(string loadFileName) => throw null;

    public CurtainContext LoadingScreenCurtainContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLoadingScreenCurtainContext(CurtainContext curtainContext) => throw null;

    public bool InitializeAsNewCampaign
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetInitializeAsNewCampaign(bool initializeAsNewCampaign) => throw null;

    public NewGameSetupInfo NewGameSetupInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public NewPlayerSetupInfo NewPlayerSetupInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string SaveFileName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSaveFileName(string saveFileName) => throw null;

    public SavedGameType SavedGameType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSavedGameType(SavedGameType savedGameType) => throw null;

    public bool SaveOverwriteFileIfExists
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSaveOverwriteFileIfExists(bool saveOverwriteFileIfExists) => throw null;

    public SaveJsonFormatting SaveJsonFormatting
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSaveJsonFormatting(SaveJsonFormatting saveJsonFormatting) => throw null;

    public byte[] NewJsonBuffer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNewJsonBuffer(byte[] newJsonBuffer) => throw null;

    public byte PlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerId(byte playerId) => throw null;

    public OnLoadOrSaveCampaignFinishedCallback OnLoadOrSaveCampaignFinishedCallback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOnLoadOrSaveCampaignFinishedCallback(
      OnLoadOrSaveCampaignFinishedCallback onLoadOrSaveCampaignFinishedCallback)
    {
      throw null;
    }

    public object CustomDataObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCustomDataObject(object customDataObject) => throw null;

    public LoadGameData LoadGameData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLoadGameData(LoadGameData loadGameData) => throw null;

    public long TimeStampStarted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTimeStampStarted(long timeStampStarted) => throw null;

    public int MS
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMS(int ms) => throw null;

    public int MSSoFar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadOrSaveCampaignTicket() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoadOrSaveCampaignTicket(LoadOrSaveCampaignTicket src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~LoadOrSaveCampaignTicket() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(LoadOrSaveCampaignTicket src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(LoadOrSaveCampaignTicket src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool StartLoadOrSaveOperation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerSuccess() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerFailure(
      LoadOrSaveCampaignFailureCode loadOrSaveCampaignFailureCode,
      bool force = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSuccess() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnFailure() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static LoadOrSaveCampaignTicket() => throw null;
  }
}
