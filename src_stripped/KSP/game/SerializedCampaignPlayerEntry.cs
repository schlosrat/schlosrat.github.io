// Decompiled with JetBrains decompiler
// Type: KSP.Game.SerializedCampaignPlayerEntry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using KSP.Networking.MP.Utils;
using KSP.OAB;
using KSP.Sim;
using KSP.Sim.impl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  [Serializable]
  public class SerializedCampaignPlayerEntry
  {
    public const string DEFAULT_PLAYER_NAME_STRING = "";
    public const string DEFAULT_PLAYER_GUID_STRING = "";
    public const byte DEFAULT_PLAYER_ID = 0;
    public const GameState DEFAULT_STARTING_GAME_STATE = GameState.KerbalSpaceCenter;
    public const GameState DEFAULT_HISTORICAL_GAME_STATE = GameState.Invalid;
    public const int DEFAULT_AGENCY_ID = 0;
    public const string DEFAULT_ACTIVE_VESSEL_NAME = "";
    public static IGGuid DEFAULT_ACTIVE_VESSEL_GUID;
    public const ActiveCameraGroup DEFAULT_ACTIVE_CAMERA_GROUP = ActiveCameraGroup.None;
    public const string DEFAULT_ACTIVE_LOCAL_SPACE_CB = "";
    public static IGGuid DEFAULT_OBSERVED_SIMOBJECT_GUID;
    public const SerializedFlightControlState DEFAULT_FLIGHT_CONTROL_STATE = null;
    public const OABHistoricalSnapshot DEFAULT_LAST_OAB_WORKSPACE_SNAPSHOT = null;
    public const SerializedOABConfig DEFAULT_LAST_OAB_CONFIG = null;
    public const string DEFAULT_COPY_LOCATION_STRING = null;
    public const Dictionary<string, uint> DEFAULT_FAVORITED_PARTS = null;
    public const bool DEFAULT_IS_FTUE_ENABLED = false;
    public const List<MissionData> DEFAULT_MISSIONS = null;
    public const string DEFAULT_COMPLETED_TUTORIALS = null;
    public static Color DEFAULT_PART_COLOR_BASE;
    public static Color DEFAULT_PART_COLOR_ACCENT;
    [JsonProperty("PlayerName")]
    public string PlayerNameString;
    [JsonProperty("PlayerGuid")]
    public string PlayerGuidString;
    [JsonProperty("PlayerId")]
    public byte PlayerId;
    [JsonProperty("StartingGameState")]
    public GameState StartingGameState;
    [JsonProperty("HistoricalGameState")]
    public GameState HistoricalGameState;
    [JsonProperty("AgencyId")]
    public int AgencyId;
    [JsonProperty("ActiveVesselName")]
    public string ActiveVesselName;
    [JsonProperty("ActiveVesselGuid")]
    public IGGuid ActiveVesselGuid;
    [JsonProperty("ActiveCameraGroup")]
    public ActiveCameraGroup ActiveCameraGroup;
    [JsonProperty("ActiveCameraInfo")]
    public SerializedActiveCameraInfo ActiveCameraInfo;
    [JsonProperty("ActiveLocalSpaceCB")]
    public string ActiveLocalSpaceCB;
    [JsonProperty("ObservedSimObjectGuid")]
    public IGGuid ObservedSimObjectGuid;
    [JsonProperty("FlightControlState")]
    public SerializedFlightControlState FlightControlState;
    [JsonProperty("LastOABWorkspaceSnapshot")]
    public OABHistoricalSnapshot LastOABWorkspaceSnapshot;
    [JsonProperty("LastOABConfig")]
    public SerializedOABConfig LastOABConfig;
    [JsonProperty("CopyLocation")]
    public string CopyLocationString;
    [JsonProperty("FavoritedParts")]
    public Dictionary<string, uint> FavoritedParts;
    [JsonProperty("FTUE")]
    public bool IsFTUEEnabled;
    [JsonProperty("MissionData")]
    public List<MissionData> Missions;
    [JsonProperty("CompletedTutorials")]
    public string CompletedTutorials;
    [JsonProperty("PartColorBase")]
    public Color PartColorBase;
    [JsonProperty("PartColorAccent")]
    public Color PartColorAccent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedCampaignPlayerEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedCampaignPlayerEntry(CampaignPlayerEntry src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~SerializedCampaignPlayerEntry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugPlayerIdNameAndGuidString(StringUtil.PlayerNameFlag playerNameFlags = StringUtil.PlayerNameFlag.Default) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SerializedCampaignPlayerEntry() => throw null;
  }
}
