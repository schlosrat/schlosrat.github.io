// Decompiled with JetBrains decompiler
// Type: KSP.Game.CampaignPlayerManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game.Missions.Definitions;
using KSP.OAB;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class CampaignPlayerManager
  {
    public const OnCampaignPlayerEntryEventCallback DEFAULT_ON_CAMPAIGN_PLAYER_ENTRY_EVENT_CALLBACK = null;
    public const bool DEFAULT_PROPAGATE_UDPATES_FLAG = false;
    private List<CampaignPlayerEntry> _list;
    private Dictionary<string, CampaignPlayerEntry> _playerNameDict;
    private Dictionary<string, CampaignPlayerEntry> _playerGuidDict;
    private Dictionary<byte, CampaignPlayerEntry> _playerIdDict;
    private OnCampaignPlayerEntryEventCallback _onCampaignPlayerEntryEventCallback;
    private bool _propagateUpdatesFlag;

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumPlayers
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IndexOfEntry(CampaignPlayerEntry campaignPlayerEntry) => throw null;

    public OnCampaignPlayerEntryEventCallback OnCampaignPlayerEntryEventCallback
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOnCampaignPlayerEntryEventCallback(
      OnCampaignPlayerEntryEventCallback onCampaignPlayerEntryEventCallback)
    {
      throw null;
    }

    public bool PropagateUpdatesFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPropagateUpdatesFlag(bool propagateUpdatesFlag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    ~CampaignPlayerManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCampaignPlayerEntry(CampaignPlayerEntry campaignPlayerEntry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveCampaignPlayerEntry(CampaignPlayerEntry campaignPlayerEntry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UpdatePlayerNameStringDict(CampaignPlayerEntry campaignPlayerEntry, bool add) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UpdatePlayerGuidStringDict(CampaignPlayerEntry campaignPlayerEntry, bool add) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UpdatePlayerIdDict(CampaignPlayerEntry campaignPlayerEntry, bool add) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool MoveCampaignPlayerEntryToIndex(CampaignPlayerEntry campaignPlayerEntry, int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LoopThroughAllCampaignPlayerEntries(CampaignPlayerEntryLoopCallback cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry FindCampaignPlayerEntryByIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry FindCampaignPlayerEntryByPlayerNameString(string playerNameString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry FindCampaignPlayerEntryByPlayerGuidString(string playerGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry FindCampaignPlayerEntryByPlayerId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetCampaignPlayerEntry(
      byte playerId,
      out CampaignPlayerEntry campaignPlayerEntryOut,
      bool logWarningIfFail = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetMyCampaignPlayerEntry(
      out CampaignPlayerEntry campaignPlayerEntryOut,
      bool logWarningIfFail = true)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Empty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry CreateCampaignPlayerEntry(
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
    public CampaignPlayerEntry CreateCampaignPlayerEntry(
      SerializedCampaignPlayerEntry serializedCampaignPlayerEntry)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry CreateFirstCampaignPlayerAndAgency(
      string playerNameString,
      string playerGuidString,
      byte playerId,
      NewPlayerSetupInfo newPlayerSetupInfo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry CreateJoiningPlayersCampaignPlayerAndAgency(
      string playerNameString,
      string playerGuidString,
      byte playerId,
      NewPlayerSetupInfo newPlayerSetupInfo)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InvalidateCampaignPlayerByPlayerId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry ImportSerializedCampaignPlayerEntry(SerializedCampaignPlayerEntry src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ImportSerializedCampaignPlayerEntries(SerializedCampaignPlayerEntry[] array) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedCampaignPlayerEntry[] ExportSerializedCampaignPlayerEntries() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load(SerializedSavedGame src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save(SerializedSavedGame dest) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLocalPlayerActiveCameraInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLocalPlayerLastOABWorkspaceSnapshotInfo() => throw null;
  }
}
