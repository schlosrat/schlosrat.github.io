// Decompiled with JetBrains decompiler
// Type: KSP.Game.CampaignPlayerEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using KSP.Networking.MP.Utils;
using KSP.OAB;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class CampaignPlayerEntry
  {
    public const CampaignPlayerManager DEFAULT_CAMPAIGN_PLAYER_MANAGER = null;
    public const string DEFAULT_PLAYER_NAME_STRING = "";
    public const string DEFAULT_PLAYER_GUID_STRING = "";
    public const byte DEFAULT_PLAYER_ID = 0;
    public const GameState DEFAULT_STARTING_GAME_STATE = GameState.KerbalSpaceCenter;
    public const GameState DEFAULT_HISTORICAL_GAME_STATE = GameState.Invalid;
    public const int DEFAULT_AGENCY_ID = 0;
    public const string DEFAULT_ACTIVE_LOCAL_SPACE_CB = "";
    public static readonly IGGuid DEFAULT_OBSERVED_SIMOBJECT_GUID;
    public const string DEFAULT_ACTIVE_VESSEL_NAME = "";
    public static IGGuid DEFAULT_ACTIVE_VESSEL_GUID;
    public const ActiveCameraGroup DEFAULT_ACTIVE_CAMERA_GROUP = ActiveCameraGroup.None;
    public const SerializedFlightControlState DEFAULT_FLIGHT_CONTROL_STATE = null;
    public const OABHistoricalSnapshot DEFAULT_LAST_OAB_WORKSPACE_SNAPSHOT = null;
    public const SerializedOABConfig DEFAULT_LAST_OAB_CONFIG = null;
    public const string DEFAULT_COPY_LOCATION_STRING = "";
    public const Dictionary<string, uint> DEFAULT_FAVORITED_PARTS = null;
    public const bool DEFAULT_IS_FTUE_ENABLED = true;
    public const string DEFAULT_COMPLETED_TUTORIALS = "";
    public static Color DEFAULT_PART_COLOR_BASE;
    public static Color DEFAULT_PART_COLOR_ACCENT;
    private CampaignPlayerManager _campaignPlayerManager;
    private string _playerNameString;
    private string _playerGuidString;
    private byte _playerId;
    private GameState _startingGameState;
    private GameState _historicalGameState;
    private int _agencyId;
    private string _activeLocalSpaceCB;
    private IGGuid _observedSimObjectGuid;
    private string _activeVesselName;
    private IGGuid _activeVesselGuid;
    private ActiveCameraGroup _activeCameraGroup;
    private SerializedActiveCameraInfo _activeCameraInfo;
    private SerializedFlightControlState _flightControlState;
    private OABHistoricalSnapshot _lastOABWorkspaceSnapshot;
    private SerializedOABConfig _lastOABConfig;
    private string _copyLocationString;
    private Dictionary<string, uint> _favoritedParts;
    private bool _isFTUEEnabled;
    private List<MissionData> _missions;
    private string _completedTutorials;
    private Color _partColorBase;
    private Color _partColorAccent;

    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CampaignPlayerManager CampaignPlayerManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string PlayerNameString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerNameString(string playerNameString, bool force = false) => throw null;

    public string PlayerGuidString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerGuidString(string playerGuidString, bool force = false) => throw null;

    public byte PlayerId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerId(byte playerId, bool force = false) => throw null;

    public GameState StartingGameState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStartingGameState(GameState startingGameState, bool force = false) => throw null;

    public GameState HistoricalGameState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHistoricalGameState(GameState historicalGameState, bool force = false) => throw null;

    public int AgencyId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyId(int agencyId, bool force = false) => throw null;

    public string ActiveLocalSpaceCB
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveLocalSpaceCB(string activeLocalSpaceCB, bool force = false) => throw null;

    public IGGuid ObservedSimObjectGuid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObservedSimObjectGuid(IGGuid simObjectGuid, bool force = false) => throw null;

    public string ActiveVesselName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveVesselName(string activeVesselName, bool force = false) => throw null;

    public IGGuid ActiveVesselGuid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveVesselGuid(IGGuid activeVesselGuid, bool force = false) => throw null;

    public ActiveCameraGroup ActiveCameraGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveCameraGroup(ActiveCameraGroup activeCameraGroup, bool force = false) => throw null;

    public SerializedActiveCameraInfo ActiveCameraInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveCameraInfo(SerializedActiveCameraInfo activeCameraInfo, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetActiveCameraInfo() => throw null;

    public SerializedFlightControlState FlightControlState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFlightControlState(SerializedFlightControlState flightControlState, bool force = false) => throw null;

    public OABHistoricalSnapshot LastOABWorkspaceSnapshot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLastOABWorkspaceSnapshot(
      OABHistoricalSnapshot lastOABWorkspaceSnapshot,
      bool force = false)
    {
      throw null;
    }

    public SerializedOABConfig LastOABConfig
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLastOABConfig(SerializedOABConfig lastOABConfig, bool force = false) => throw null;

    public string CopyLocationString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCopyLocationString(string copyLocationString) => throw null;

    public Dictionary<string, uint> FavoritedParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string FavoritedPartsString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumFavoritedParts
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetFavoritedParts(Dictionary<string, uint> src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetFavoritedPartsFromString(string favoritedPartsString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsFavoritedPart(string partName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddFavoritedPart(string partName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveFavoritedPart(string partName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ToggleFavoritedPart(string partName) => throw null;

    public bool IsFTUEEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIsFTUEEnabled(bool isFTUEEnabled) => throw null;

    public List<MissionData> Missions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMissions(List<MissionData> src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearMissions() => throw null;

    public string CompletedTutorials
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCompletedTutorials(string completedTutorials) => throw null;

    public Color PartColorBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetPartColorBase(Color partColorBase) => throw null;

    public Color PartColorAccent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetPartColorAccent(Color partColorAccent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry(
      CampaignPlayerManager campaignPlayerManager,
      string playerNameString,
      string playerGuidString,
      byte playerId,
      GameState startingGameState,
      GameState historicalGameState,
      int agencyId,
      string activeLocalSpaceCB,
      IGGuid observedSimObjectGuid,
      string activeVesselName,
      IGGuid activeVesselGuid,
      ActiveCameraGroup activeCameraGroup,
      SerializedActiveCameraInfo activeCameraInfo,
      SerializedFlightControlState flightControlState,
      OABHistoricalSnapshot lastOABWorkspaceSnapshot,
      SerializedOABConfig lastOABConfig,
      string copyLocationString,
      Dictionary<string, uint> favoritedParts,
      bool isFTUEEnabled,
      List<MissionData> missions,
      string completedTutorials,
      Color partColorBase,
      Color partColorAccent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~CampaignPlayerEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      CampaignPlayerManager campaignPlayerManager,
      string playerNameString,
      string playerGuidString,
      byte playerId,
      GameState startingGameState,
      GameState historicalGameState,
      int agencyId,
      string activeLocalSpaceCB,
      IGGuid observedSimObjectGuid,
      string activeVesselName,
      IGGuid activeVesselGuid,
      ActiveCameraGroup activeCameraGroup,
      SerializedActiveCameraInfo activeCameraInfo,
      SerializedFlightControlState flightControlState,
      OABHistoricalSnapshot lastOABWorkspaceSnapshot,
      SerializedOABConfig lastOABConfig,
      string copyLocationString,
      Dictionary<string, uint> favoritedParts,
      bool isFTUEEnabled,
      List<MissionData> missions,
      string completedTutorials,
      Color partColorBase,
      Color partColorAccent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetIndex() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MoveToIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLookupInfo(string playerNameString, string playerGuidString, byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString(bool abbrev = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugPlayerIdNameAndGuidString(StringUtil.PlayerNameFlag playerNameFlags = StringUtil.PlayerNameFlag.Default) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CampaignPlayerEntry() => throw null;
  }
}
