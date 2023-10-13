// Decompiled with JetBrains decompiler
// Type: KSP.Audio.KSPAudioEventManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
using KSP.Game;
using KSP.Map;
using KSP.Messages;
using KSP.OAB;
using KSP.Sim;
using KSP.UI;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Audio
{
  public class KSPAudioEventManager : KerbalMonoBehaviour
  {
    private const string WARNING_MESSAGE_INITIALIZATION = "KspAudioEventManager has not been initialized.";
    private static KSPAudioEventManager _Mgr;
    private float _masterVolume;
    private float _musicVolume;
    private float _SFXVolume;
    private float _VOVolume;
    private float _KerbalCommVolume;
    private float _KerbalIVAVolume;
    private float _AmbienceVolume;
    private float _UIVolume;
    private float _p_distance_to_pariapisis;
    private float _p_distance_to_apoapsis;
    private float _p_planetary_temp;
    private float _g_vessel_gforce;
    private float _g_vessel_mass_rtpc;
    private float _g_trajectory_toward_ground_or_sky;
    private float _g_vessel_distance_to_listener;
    private static OABProvider.LaunchLocation _launchPadType;
    [SerializeReference]
    public List<BasePropertyWatcherBinding> PropertyWatcherBindings;
    [SerializeField]
    [HideInInspector]
    public List<KSPAudioEventBinding> AudioEventBindings;
    private static SubscriptionHandle _handleVesselChanged;
    private static SubscriptionHandle _handleTimeZoomChangeActivated;
    private static SubscriptionHandle _handleTimeZoomChangeCompleted;
    private ManeuverGizmoInputType _lastManipulatedType;
    private GameObject _uiAudioGameObject;
    private KSPAudioDebug _audioDebug;
    public KSPAudioEventManager.UIEvents _uiEvents;
    public KSPAudioEventManager.VehicleEvents _vehicleEvents;
    public KSPAudioEventManager.GameFlowEvents _GameFlowEvents;
    public KSPAudioEventManager.VABSoundEvents _VABSoundEvents;
    public KSPAudioEventManager.TimeWarpEvents _timeWarpEvents;
    public KSPAudioEventManager.FlightSoundEvents _FlightSoundEvents;
    public KSPAudioEventManager.MapModeEvents _mapModeEvents;
    public KSPAudioEventManager.NotificationEvents _notificationEvents;
    public KSPAudioEventManager.ResourceEvents _resourceEvents;
    public KSPAudioEventManager.KSPPartAudioSettings PartAudioSettings;
    private bool _isGameMutedFromKey;
    private bool _isMusicMutedFromKey;

    public static GameObject UIAudioGameObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetInstance(KSPAudioEventManager instance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterAudioEventBindings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnregisterAudioEventBindings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateUIAudioObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAudioEventBindings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PostEvents(Event[] audioEventToPlay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PostEvents(Event[] audioEventToPlay, GameObject sourceObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PostEvent(string audioEventToPlay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private uint GetIDFromString(string inString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void PostAKEvents(Event[] audioEventToPlay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void PostAKEvent(string audioEventToPlay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void PostAKEvents(Event[] audioEventToPlay, GameObject sourceObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static uint GetAudioIDFromString(string inString) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RegisterEvents(
      ObjectAssemblyBuilderEvents eventsBuilder,
      ObjectAssemblyUIEvents eventsUI)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RegisterViewControllerEvents(IViewController viewController) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnregisterViewControllerEvents(IViewController viewController) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void OnVesselChanged(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onUIButtonDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onUIButtonHover() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onUIButtonToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnTabAwayResumeSound() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnKSCBuildingClick(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnVehicleDocked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnVehicleUndocked() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnActiveVehicleIsARover() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnActiveVehicleIsNotARover() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowEnterKSC() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowEnterVAB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowEnterDeepSpace() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowActivateMonument() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowOnLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowOnLaunchAtmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowOnLaunchLiftoff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowOnLaunchOrbit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowOnLandingSafe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowOnLose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGamePaused() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameUnpaused() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameQuickLoad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameQuickSave() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowEnterTutorial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowLeaveTutorial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowEnterTrainingCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowLeaveTrainingCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowEnterMissionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onGameFlowLeaveMissionControl() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onSetLaunchpadLocation(OABProvider.LaunchLocation location) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABCubeMouseHoverChanged(bool isHovering) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABEditorPartGrabbed(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABPartDropped(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABEditorPlaceConnected(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABEditorPlaceNonConnected(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABPartDisconnected(IObjectAssemblyPart part) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnStagingStackBeginDrag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnStagingStackEndDrag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABPartHighlighted(IObjectAssemblyPart part, Vector3 pos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABPartSnapped() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onEditorPlacePartTrash() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onEditorHoverPartTrash() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABEditorPartsListCategorySelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABEditorPartsListCategoryHover() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABEditorPartsListPartHover(bool isFavoritePart) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABButtonLaunch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABButton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABButton(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABButton(ManipulationMode state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABButton(IObjectAssemblyTool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABButtonToggle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABCutsceneEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABEnterBlueprintMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABExitBlueprintMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onVABBlueprintModeChangeOrientation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetMasterVolume(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetMasterVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetMusicVolume(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetMusicVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetSFXVolume(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetSFXVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetVoiceVolume(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetVoiceVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetKerbalCommVolume(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetKerbalCommVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetKerbalIVAVolume(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetKerbalIVAVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetAmbienceVolume(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetAmbienceVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetUIVolume(float val) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetTabAwayAudio(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetAudioListeningMode(
      AudioSettingsMenuManager.AudioListeningModeEnum mode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetUIVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void OnTimeZoomChangeActivated(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void OnTimeZoomChangeCompleted(MessageCenterMessage msg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TriggerWarpLoop(bool isActivated, int rate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onFlightPartHighlighted(Vector3 viewportPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void onPartManagerVisibilityChanged(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeShowManeuverPopup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeHideManeuverPopup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeWarpTo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeGizmoCreated() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeGizmoDeleted() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeScrubStart(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeScrubStop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeScrubUpdatePosition(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeGizmoExpanded(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeGizmoCollapsed(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeManipulateGizmo(
      ManeuverGizmoInputType type,
      float amount,
      Vector3 arrowHeadViewportPos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeStopManipulateGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnManipulateGizmo(
      ManeuverGizmoInputType type,
      float amount,
      Vector3 arrowHeadViewportPos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnStopManipulateGizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeGizmoDragStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnMapModeGizmoDragStop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UpdateMapModeGizmoPosition(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnManeuverETA_RemaingingTimeChanged(int newTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnNotifcationOpen(NotificationTier tier) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnNotifcationClose(NotificationTier tier) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnResourceTransfertStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void OnResourceTransfertStop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetWheelRoverDetectionTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetWheelRoverCooldownDetectionTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetWheelRoverMinNumberOfWheel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetAirplaneWheelTouchDown_MinAirTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float GetAirplaneWheelTouchDown_MinAltitude() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateGlobalRTPCValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BindMenuKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UnbindMenuKeys() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleMuteGame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnToggleMuteMusic() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSPAudioEventManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static KSPAudioEventManager() => throw null;

    [Serializable]
    public class UIEvents
    {
      [NonReorderable]
      public Event[] OnUIButtonDown;
      [NonReorderable]
      public Event[] OnUIButtonHover;
      [NonReorderable]
      public Event[] OnUIButtonToggle;
      [NonReorderable]
      public Event[] OnTabAwayResumeSound;
      [NonReorderable]
      public Event[] OnKSCBuildingClick;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public UIEvents() => throw null;
    }

    [Serializable]
    public class VehicleEvents
    {
      [NonReorderable]
      public Event[] OnVehicleActivated;
      [NonReorderable]
      public Event[] OnVehicleDeactivated;
      [NonReorderable]
      public Event[] OnVehicleDocked;
      [NonReorderable]
      public Event[] OnVehicleUndocked;
      [NonReorderable]
      public Event[] OnActiveVehicleIsARover;
      [NonReorderable]
      public Event[] OnActiveVehicleIsNotARover;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public VehicleEvents() => throw null;
    }

    [Serializable]
    public class GameFlowEvents
    {
      [NonReorderable]
      public Event[] onGameEnterKSC;
      [NonReorderable]
      public Event[] onGameEnterVAB;
      [NonReorderable]
      public Event[] onGameEnterDeepSpace;
      [NonReorderable]
      public Event[] onGameActivateMonument;
      [NonReorderable]
      public Event[] onGameLaunch;
      [NonReorderable]
      public Event[] onGameLaunchAtmos;
      [NonReorderable]
      public Event[] onGameLaunchLiftoff;
      [NonReorderable]
      public Event[] onGameLaunchOrbit;
      [NonReorderable]
      public Event[] onGameLandingSafe;
      [NonReorderable]
      public Event[] onGameLose;
      [NonReorderable]
      public Event[] onGamePaused;
      [NonReorderable]
      public Event[] onGameUnpaused;
      [NonReorderable]
      public Event[] onGameEnterTutorial;
      [NonReorderable]
      public Event[] onGameLeaveTutorial;
      [NonReorderable]
      public Event[] onGameQuickSave;
      [NonReorderable]
      public Event[] onGameQuickLoad;
      [NonReorderable]
      public Event[] onSetLaunchLocationLaunchpad;
      [NonReorderable]
      public Event[] onSetLaunchLocationLaunchpad_1;
      [NonReorderable]
      public Event[] onSetLaunchLocationLaunchpad_2;
      [NonReorderable]
      public Event[] onSetLaunchLocationLaunchpad_3;
      [NonReorderable]
      public Event[] onSetLaunchLocationLaunchpad_4;
      [NonReorderable]
      public Event[] onSetLaunchLocationRunway;
      [NonReorderable]
      public Event[] onSetLaunchLocationRunway_1;
      [NonReorderable]
      public Event[] onSetLaunchLocationRunway_2;
      [NonReorderable]
      public Event[] onSetLaunchLocationOrbital;
      [NonReorderable]
      public Event[] onGameEnterTrainingCenter;
      [NonReorderable]
      public Event[] onGameLeaveTrainingCenter;
      [NonReorderable]
      public Event[] onGameEnterMissionControl;
      [NonReorderable]
      public Event[] onGameLeaveMissionControl;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public GameFlowEvents() => throw null;
    }

    [Serializable]
    public class VABSoundEvents
    {
      [NonReorderable]
      public Event[] onPartsListCategorySelected;
      [NonReorderable]
      public Event[] onPartsListCategoryHover;
      [NonReorderable]
      public Event[] onPartsListPartHover;
      [NonReorderable]
      public Event[] onFavoritePartsListPartHover;
      [NonReorderable]
      public Event[] onButtonLaunch;
      [NonReorderable]
      public Event[] onBttonToolToggle;
      [NonReorderable]
      public Event[] onEditorPartHighlight;
      [NonReorderable]
      public Event[] onEditorPartSnapped;
      [NonReorderable]
      public Event[] onEditorPlaceConnected;
      [NonReorderable]
      public Event[] onEditorPlaceNonConnected;
      [NonReorderable]
      public Event[] onEditorPartDisconnected;
      [NonReorderable]
      public Event[] onEditorPartGrabbed;
      [NonReorderable]
      public Event[] onEditorPartDropped;
      [NonReorderable]
      public Event[] onEditorPlacePartTrash;
      [NonReorderable]
      public Event[] onEditorHoverPartTrash;
      [NonReorderable]
      public Event[] onVABCutsceneEnd;
      [NonReorderable]
      public Event[] onVABEnterBlueprintMode;
      [NonReorderable]
      public Event[] onVABExitBlueprintMode;
      [NonReorderable]
      public Event[] onVABBlueprintModeChangeOrientation;
      [NonReorderable]
      public Event[] onVABCubeHoverStart;
      [NonReorderable]
      public Event[] onVABCubeHoverStop;
      [NonReorderable]
      public Event[] OnStagingStackBeginDrag;
      [NonReorderable]
      public Event[] OnStagingStackEndDrag;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public VABSoundEvents() => throw null;
    }

    [Serializable]
    public class TimeWarpLoop
    {
      [NonReorderable]
      public Event TimeWarpStarted;
      [NonReorderable]
      public Event TimeWarpFinished;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TimeWarpLoop() => throw null;
    }

    [Serializable]
    public class TimeWarpEvents
    {
      public KSPAudioEventManager.TimeWarpLoop WarpTo1;
      public KSPAudioEventManager.TimeWarpLoop WarpTo2;
      public KSPAudioEventManager.TimeWarpLoop WarpTo3;
      public KSPAudioEventManager.TimeWarpLoop WarpTo4;
      public KSPAudioEventManager.TimeWarpLoop WarpTo5;
      public KSPAudioEventManager.TimeWarpLoop WarpTo6;
      public KSPAudioEventManager.TimeWarpLoop WarpTo7;
      public KSPAudioEventManager.TimeWarpLoop WarpTo8;
      public KSPAudioEventManager.TimeWarpLoop WarpTo9;
      public KSPAudioEventManager.TimeWarpLoop WarpTo10;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public TimeWarpEvents() => throw null;
    }

    [Serializable]
    public class FlightSoundEvents
    {
      [NonReorderable]
      public Event[] onPartHighlight;
      [NonReorderable]
      public Event[] onPartMenuOpened;
      [NonReorderable]
      public Event[] onPartMenuClosed;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public FlightSoundEvents() => throw null;
    }

    [Serializable]
    public class GizmoManipulationLoop
    {
      [NonReorderable]
      public Event[] onStarted;
      [NonReorderable]
      public Event[] onFinished;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public GizmoManipulationLoop() => throw null;
    }

    [Serializable]
    public class MapModeEvents
    {
      [NonReorderable]
      public Event[] onShowManeuverPopup;
      [NonReorderable]
      public Event[] onHideManeuverPopup;
      [NonReorderable]
      public Event[] onWarpTo;
      [NonReorderable]
      public Event[] onGizmoCreated;
      [NonReorderable]
      public Event[] onGizmoDeleted;
      [NonReorderable]
      public Event[] onGizmoExpanded;
      [NonReorderable]
      public Event[] onGizmoCollpased;
      public KSPAudioEventManager.GizmoManipulationLoop onGizmoPropgradeManipulated;
      public KSPAudioEventManager.GizmoManipulationLoop onGizmoRetrogradeManipulated;
      public KSPAudioEventManager.GizmoManipulationLoop onGizmoRadialOutManipulated;
      public KSPAudioEventManager.GizmoManipulationLoop onGizmoRadialInManipulated;
      public KSPAudioEventManager.GizmoManipulationLoop onGizmoNormalManipulated;
      public KSPAudioEventManager.GizmoManipulationLoop onGizmoAntiNormalManipulated;
      public KSPAudioEventManager.GizmoManipulationLoop onGizmoDrag;
      public KSPAudioEventManager.GizmoManipulationLoop onManeuverScrub;
      [NonReorderable]
      public Event[] onManeuverETA_RemaingingTime_3;
      [NonReorderable]
      public Event[] onManeuverETA_RemaingingTime_2;
      [NonReorderable]
      public Event[] onManeuverETA_RemaingingTime_1;
      [NonReorderable]
      public Event[] onManeuverETA_RemaingingTime_0;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public MapModeEvents() => throw null;
    }

    [Serializable]
    public class NotificationEvents
    {
      [NonReorderable]
      public Event[] OnPassiveNotificationOpen;
      [NonReorderable]
      public Event[] OnPassiveNotificationClose;
      [NonReorderable]
      public Event[] OnAlertNotificationOpen;
      [NonReorderable]
      public Event[] OnAlertNotificationClose;
      [NonReorderable]
      public Event[] OnAdminNotificationOpen;
      [NonReorderable]
      public Event[] OnAdminNotificationClose;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public NotificationEvents() => throw null;
    }

    [Serializable]
    public class ResourceEvents
    {
      [NonReorderable]
      public Event[] OnResourceTransfertStart;
      [NonReorderable]
      public Event[] OnResourceTransfertStop;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ResourceEvents() => throw null;
    }

    [Serializable]
    public class KSPPartAudioSettings
    {
      public float WheelRoverDetectionTime;
      public float WheelRoverCooldownDetectionTime;
      public int WheelRoverMinNumberOfWheel;
      public float AirplaneWheelTouchDown_MinAirTime;
      public float AirplaneWheelTouchDown_MinAltitude;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public KSPPartAudioSettings() => throw null;
    }
  }
}
