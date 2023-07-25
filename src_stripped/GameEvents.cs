// Decompiled with JetBrains decompiler
// Type: GameEvents
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using KSP.Sim;
using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Obsolete("Don't use this or IContext.")]
public class GameEvents : GameEventsBase
{
  public static EventDataObsolete<int> onStageActivate;
  public static EventDataObsolete<Vector3d> onKrakensbaneEngage;
  public static EventDataObsolete<Vector3d> onKrakensbaneDisengage;
  public static EventVoidObsolete onGamePause;
  public static EventVoidObsolete onGameUnpause;
  public static EventVoidObsolete onFlightReady;
  public static EventVoidObsolete onTimeWarpRateChanged;
  public static EventDataObsolete<GameScenes> onGameSceneLoadRequested;
  public static EventDataObsolete<GameEvents.FromToAction<GameScenes, GameScenes>> onGameSceneSwitchRequested;
  public static EventDataObsolete<GameScenes> onLevelWasLoaded;
  public static EventDataObsolete<GameScenes> onLevelWasLoadedGUIReady;
  public static EventDataObsolete<int, int> onScreenResolutionModified;
  public static EventVoidObsolete OnGameDatabaseLoaded;
  public static EventVoidObsolete OnUpgradesFilled;
  public static EventVoidObsolete OnUpgradesLinked;
  public static EventVoidObsolete OnPartLoaderLoaded;
  public static EventVoidObsolete OnMapEntered;
  public static EventVoidObsolete OnMapExited;
  public static EventDataObsolete<GameEvents.FromToAction<ControlTypes, ControlTypes>> onInputLocksModified;
  public static EventVoidObsolete OnGameSettingsApplied;
  public static EventDataObsolete<bool> OnAppFocus;
  public static EventDataObsolete<bool> OnFlightGlobalsReady;
  public static EventVoidObsolete onLanguageSwitched;
  public static EventVoidObsolete OnResourceMapLoaded;
  public static EventDataObsolete<string> onFlagSelect;
  public static EventDataObsolete<string> onMissionFlagSelect;
  public static EventDataObsolete<PQS> OnPQSStarting;
  public static EventDataObsolete<CelestialBodyBehavior, string> OnPQSCityLoaded;
  public static EventDataObsolete<CelestialBodyBehavior, string> OnPQSCityUnloaded;
  public static EventVoidObsolete onTooltipDestroyRequested;
  public static EventVoidObsolete onGUILock;
  public static EventVoidObsolete onGUIUnlock;
  public static EventDataObsolete<GameEvents.VesselSpawnInfo> onGUILaunchScreenSpawn;
  public static EventVoidObsolete onGUILaunchScreenDespawn;
  public static EventVoidObsolete onGUIAstronautComplexSpawn;
  public static EventVoidObsolete onGUIAstronautComplexDespawn;
  public static EventVoidObsolete onGUIRnDComplexSpawn;
  public static EventVoidObsolete onGUIRnDComplexDespawn;
  public static EventVoidObsolete onGUIMissionControlSpawn;
  public static EventVoidObsolete onGUIMissionControlDespawn;
  public static EventVoidObsolete onGUIAdministrationFacilitySpawn;
  public static EventVoidObsolete onGUIAdministrationFacilityDespawn;
  public static EventVoidObsolete onGUIKSPediaSpawn;
  public static EventVoidObsolete onGUIKSPediaDespawn;
  public static EventVoidObsolete onHideUI;
  public static EventVoidObsolete onShowUI;
  [Obsolete]
  public static EventVoidObsolete onGUIPrefabLauncherReady;
  public static EventVoidObsolete onGUIApplicationLauncherReady;
  public static EventDataObsolete<GameScenes> onGUIApplicationLauncherUnreadifying;
  public static EventVoidObsolete onGUIApplicationLauncherDestroyed;
  public static EventVoidObsolete onGUIMessageSystemReady;
  public static EventVoidObsolete onGUIEditorToolbarReady;
  public static EventVoidObsolete onGUIEngineersReportReady;
  public static EventVoidObsolete onGUIEngineersReportDestroy;
  public static EventDataObsolete<SpeedDisplayMode> onSetSpeedMode;
  public static EventDataObsolete<AltimeterDisplayMode> onSetAltitudeMode;
  public static EventDataObsolete<Space> onEditorSymmetryCoordsChange;
  public static EventDataObsolete<int> onEditorSymmetryModeChange;
  public static EventDataObsolete<bool> onEditorSnapModeChange;
  public static EventDataObsolete<KSP.Sim.CameraMode> OnCameraChange;
  public static EventVoidObsolete OnFlightCameraModeChange;
  public static EventDataObsolete<FlightCameraMode> OnFlightCameraAngleChange;
  public static EventDataObsolete<float, float> OnFlightThrottleChanged;
  public static EventDataObsolete<AutopilotMode> OnSasButtonPressed;
  public static EventDataObsolete<Vector3> OnFlightCameraRotate;
  public static EventDataObsolete<float> OnFlightCameraZoomChanged;
  public static EventDataObsolete<string, bool> OnKerbalPopulationBoomOccurred;
  public static EventVoidObsolete OnColonySettingsChanged;
  public static EventVoidObsolete OnCollisionIgnoreUpdate;
  public static EventDataObsolete<string> onChatMessageSent;
  public static EventDataObsolete<string> OnShipConstructSaved;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static T FindEvent<T>(string eventName) where T : BaseGameEventObsolete => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public GameEvents() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static GameEvents() => throw null;

  public struct ExplosionReaction
  {
    public float distance;
    public float magnitude;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ExplosionReaction(float distance, float magnitude) => throw null;
  }

  public struct HostTargetAction<A, B>
  {
    public A host;
    public B target;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HostTargetAction(A host, B target) => throw null;
  }

  public struct FromToAction<A, B>
  {
    public A from;
    public B to;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FromToAction(A from, B to) => throw null;
  }

  public struct HostedFromToAction<A, B>
  {
    public A host;
    public B from;
    public B to;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HostedFromToAction(A host, B from, B to) => throw null;
  }

  public struct VesselSpawnInfo
  {
    public string craftSubfolder;
    public string profileName;
  }

  public static class StageManager
  {
    public static EventDataObsolete<bool> SortIcons;
    public static EventVoidObsolete OnGUIStageSequenceModified;
    public static EventDataObsolete<int> OnGUIStageAdded;
    public static EventDataObsolete<int> OnGUIStageRemoved;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static StageManager() => throw null;
  }

  public class Input
  {
    public static EventDataObsolete<bool> OnPrecisionModeToggle;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Input() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Input() => throw null;
  }
}
