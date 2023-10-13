// Decompiled with JetBrains decompiler
// Type: KSP.Game.AnalyticsUtils
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Missions.Definitions;
using KSP.Messages;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game
{
  internal static class AnalyticsUtils
  {
    private static bool _disableNewAnalytics;
    private static bool _logEventSending;
    private static readonly Dictionary<string, string> _workingDict;
    private static HashSet<GameState> _stateListForExclusion;
    private static GameState _previousMonitoredState;
    private static readonly Dictionary<GameState, double> _gameStateStarts;
    private static readonly Dictionary<string, double> _startedTutorials;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SendAnalyticsEvent(
      string eventId,
      Dictionary<string, string> data,
      string debugMessage)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SendTestEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void Initialize(GameInstance game) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void Shutdown(GameInstance game) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void HandleLoadSaveFinish(
      LoadOrSaveCampaignTicket ticket,
      double operationDuration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void AddCommonCampaignData(
      LoadOrSaveCampaignTicket ticket,
      double operationDuration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SendCampaignStarted(
      LoadOrSaveCampaignTicket ticket,
      double operationDuration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SendCampaignLoaded(
      LoadOrSaveCampaignTicket ticket,
      double operationDuration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void OnGameStateChanged(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SendMonitoredStateLeft(GameState gameState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SendMonitoredStateChange(
      GameState previousGameState,
      GameState nextGameState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SendSOIReached(VesselComponent vessel, double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SendCBLanded(VesselComponent vessel, double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SendCBLaunched(VesselComponent vessel, double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SendTutorialStarted(MissionData tutorial) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void SendTutorialEnded(
      MissionData tutorial,
      AnalyticsUtils.TutorialEndStates endState)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool TryGetTutorialStrings(
      MissionData tutorial,
      out string tutorialId,
      out string stageName)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AnalyticsUtils() => throw null;

    internal enum TutorialEndStates
    {
      Complete,
      Cancelled,
      Restarted,
      Failed,
    }
  }
}
