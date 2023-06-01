// Decompiled with JetBrains decompiler
// Type: KSP.Game.CampaignPlayerManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
    public void LoopThroughAllCampaignPlayerEntries(CampaignPlayerEntryLoopCallback cb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAllFoundFlags(bool foundFlag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAllFoundFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearAllFoundFlags() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry FindCampaignPlayerEntryByIndex(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry FindCampaignPlayerEntryByPlayerNameString(string playerNameString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry FindCampaignPlayerEntryByPlayerGuidString(string playerGuidString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry FindCampaignPlayerEntryByPlayerId(byte playerId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CampaignPlayerEntry FindCampaignPlayerEntryFirstNotFound() => throw null;

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
      string activeVesselName,
      IGGuid activeVesselGuid,
      string activeLocalSpaceCB,
      IGGuid observedSimObjectGuid,
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
