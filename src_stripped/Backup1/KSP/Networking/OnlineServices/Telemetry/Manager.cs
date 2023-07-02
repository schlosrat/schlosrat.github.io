// Decompiled with JetBrains decompiler
// Type: KSP.Networking.OnlineServices.Telemetry.Manager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Game.Missions;
using KSP.Game.Missions.Definitions;
using KSP.Messages;
using KSP.Networking.OnlineServices.Shared.Models;
using KSP.Sim.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Networking.OnlineServices.Telemetry
{
  public class Manager
  {
    public const bool DEFAULT_LOG_INFO = false;
    public const bool DEFAULT_LOG_ASSERT = false;
    public const bool DEFAULT_LOG_WARN = false;
    public const bool DEFAULT_LOG_ERROR = true;
    public const bool DEFAULT_LOG_EXCEPTION = true;
    public const bool DEFAULT_LOG_MISC = true;
    public static bool LOG_INFO;
    public static bool LOG_ASSERT;
    public static bool LOG_WARN;
    public static bool LOG_ERROR;
    public static bool LOG_EXCEPTION;
    public static bool LOG_MISC;
    private const long GAME_STATE_START_INDEX = 10;
    private const bool HEARTBEAT_ENABLED = true;
    private const float HEARTBEAT_RATE = 60f;
    private static Manager _instance;
    private static KSP2MissionManager kSP2MissionManager;
    private DebugVisualizer _debugVisualizer;
    private bool _isInGameSession;
    private bool _isInApplicationSession;
    private bool _sendHeartbeatEvent;
    private SubscriptionHandle _handleTutorialStarted;
    private SubscriptionHandle _handleTutorialEnded;
    private SubscriptionHandle _handleTutorialReStarted;
    private SubscriptionHandle _handleTutorialStep;
    private SubscriptionHandle _handleGameStateStart;
    private SubscriptionHandle _handleGameStateEnd;
    private SubscriptionHandle _handleGameStateChange;
    private SubscriptionHandle _handlePlayerLoggedIn;
    private SubscriptionHandle _handleVesselLanded;

    private string _telemetryKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Guid ApplicationSessionId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static Guid GameSessionId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public static Manager Instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AnonymousLoginFailed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessEvent<T>(string eventName, T body) where T : MessageCenterMessage => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendDeviceInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUnityLog(string logString, string stackTrace, LogType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateLeft(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateEntered(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGameStateChanged(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialStepCompleted(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialStarted(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialReStarted(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTutorialEnded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPlayerLoggedIn(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselLanded(MessageCenterMessage obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendVesselDestroyedEvent(
      string celestialBodyName,
      double latitude,
      double longitude,
      double altitude,
      IGGuid vesselID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendVesselEnteredSOI(
      string celestialBodyName,
      double latitude,
      double longitude,
      double altitude,
      IGGuid vesselID)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendTelemetryRequest(string telemetryEventName, string telemetryEventBody) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Dictionary<string, string> GetTitleEventHeaders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private MissionData GetActiveMissionData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetLocalIPv4() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private EventBase GetBaseEvent<T>(T body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendGameSessionEvent(bool isStartEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendApplicationSessionEvent(bool isStartEvent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendSettingsTelemetryEvent(PersistentSettings settings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Heartbeat() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SendHeartbeatEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Manager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Manager() => throw null;
  }
}
