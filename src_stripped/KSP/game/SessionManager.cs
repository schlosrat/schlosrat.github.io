// Decompiled with JetBrains decompiler
// Type: KSP.Game.SessionManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Colonies;
using KSP.Map;
using KSP.Rendering;
using KSP.ScriptInterop;
using KSP.Sim;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  public class SessionManager
  {
    public const bool DEFAULT_ACTIVE_CAMPAIGN_NEW_PLAYER_IS_FTUE_ENABLED = false;
    private string _activeCampaignName;
    private CampaignType _activeCampaignType;
    private bool _activeCampaignReadOnlyFlag;
    private bool _trainingCenterPopupAppearedOnceFlag;
    private string _activeCampaignDescription;
    private string _activeGameMode;
    private DifficultyOptionsData _difficultyOptions;
    private DifficultyOptionsData _defaultDifficultyOptions;
    private List<TrackingStationObjectTypeFilter> _activeTrackingStationObjectEntryFilters;
    private string _activeGalaxyDefinitionKey;
    private NewPlayerSetupInfo _newPlayerSetupInfo;
    public KerbalRosterManager KerbalRosterManager;
    public NonIVACrewCamManager NonIVACrewCamManager;
    private ColonyManager _colonyManager;
    private CommNetManager _commNetManager;
    private string _lastLaunchLocation;
    public static Color DEFAULT_AGENCY_COLOR_BASE;
    public static Color DEFAULT_AGENCY_COLOR_ACCENT;
    public static string DEFAULT_FLAG_SPRITE_LOCATION;
    public static bool SHOW_PWARP_WARNING;
    public static bool ORBIT_WARP_DOWN_AT_SOI;
    public static bool KERBIN_TIME;
    public static bool SHOW_DEADLINES_AS_DATES;
    public static float VAB_CAMERA_ORBIT_SENS;
    public static float VAB_CAMERA_ZOOM_SENS;
    public static float FLT_CAMERA_CHASE_SHARPNESS;
    public static bool CAMERA_DOUBLECLICK_MOUSELOOK;
    public static bool HIGHLIGHT_FX;
    public static bool CHECK_FOR_UPDATES;
    public static bool LOG_MISSING_KEYS_TO_FILE;
    public static bool SHOW_TRANSLATION_KEYS_ON_SCREEN;
    public static bool ShowFrameTimes;
    public static bool LEGACY_ORBIT_TARGETING;
    public static bool LOG_INSTANT_FLUSH;
    public static float MOUSE_DOUBLE_CLICK_TIME;
    public static float MOUSE_VIRTUAL_MOVE_SPEED;
    public static float VOICE_VOLUME;
    public static float SHIP_VOLUME;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding TIME_WARP_INCREASE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding TIME_WARP_DECREASE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding TIME_WARP_STOP;
    public static bool IS_ZOOM_MODE;
    public static bool IS_ACTIVE_CURSOR;
    public static bool IS_ACTIVE_FUNCTION_MENU_WHEEL;
    public static bool IS_ACTIVE_MANRUVER_NODE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding MODIFIER_KEY;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding MAP_VIEW_TOGGLE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_ZOOM;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_ZOOM_SWITCH;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding ZOOM_IN;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding ZOOM_OUT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_PAN_UP;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_PAN_DOWN;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_PAN_LEFT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_PAN_RIGHT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_ROLL_LEFT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_ROLL_RIGHT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_RESET;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding AXIS_CAMERA_HDG;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding AXIS_CAMERA_PITCH;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding AXIS_MOUSEWHEEL;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_ORBIT_UP;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_ORBIT_DOWN;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_ORBIT_LEFT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_ORBIT_RIGHT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding RSC_CONTROL_CAMERA_UP;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding RSC_CONTROL_CAMERA_DOWN;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding RSC_CONTROL_CAMERA_LEFT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding RSC_CONTROL_CAMERA_RIGHT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_KEYINPUT_INCREASE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_KEYINPUT_DECREASE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_AUTO_ORBIT_TOGGLE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_MODE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static KeyBinding CAMERA_LOCAL_ROT_MODE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding ZOOM_MODE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    private static AxisBinding XBOX_PAD_HORIZONTAL;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    private static AxisBinding XBOX_PAD_VERTICAL;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding VAB_NAVIGATE_PAD_RIGHT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding VAB_NAVIGATE_PAD_LEFT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding VAB_NAVIGATE_PAD_UP;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding VAB_NAVIGATE_PAD_DOWN;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PARTS_INFO_TOGGLE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding VAB_SYMMETRY_MODE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding MOUSE_LEFT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding MOUSE_RIGHT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding MOUSE_MIDDLE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding MOUSE_MOVEMENT_X;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding MOUSE_MOVEMENT_Y;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding MOUSE_AXIS_X;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding MOUSE_AXIS_Y;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding CAMERA_MOUSE_TOGGLE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_LEGEND_MENU_NAVIGATE_DOWN;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_LEGEND_MENU_NAVIGATE_UP;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_PAD_RIGHT_HOLDON;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_PAD_LEFT_HOLDON;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_PAD_LEFT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_PAD_RIGHT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_KeyBoard_ENTER;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_SAVE_CAMERA_POSITION_KeyBoard_1;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_SAVE_CAMERA_POSITION_KeyBoard_2;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_SAVE_CAMERA_POSITION_KeyBoard_3;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_SAVE_CAMERA_POSITION_KeyBoard_4;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_SAVE_CAMERA_POSITION_KeyBoard_5;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_SAVE_CAMERA_POSITION_KeyBoard_6;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_SAVE_CAMERA_POSITION_KeyBoard_7;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_SAVE_CAMERA_POSITION_KeyBoard_8;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_SAVE_CAMERA_POSITION_KeyBoard_9;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_BACK_PAUSE_MENU;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_KEYBOARD_SPACE;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PHOTO_MODE_KEYBOARD_ESC_BACK_TO_PAUSE_MENU;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding WHEEL_SELECT_X;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding WHEEL_SELECT_Y;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding AXIS_PITCH;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding AXIS_ROLL;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding AXIS_YAW;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PITCH_DOWN;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding PITCH_UP;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding YAW_LEFT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding YAW_RIGHT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding ROLL_LEFT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding ROLL_RIGHT;
    [Obsolete("Needs replacing with a GameInput actionmap equivalent as ControllerBinding is obsolete")]
    public static ControllerBinding SHOW_PLATFORM_KEYBOARD;

    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string ActiveCampaignName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveCampaignName(string activeCampaignName) => throw null;

    public CampaignType ActiveCampaignType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveCampaignType(CampaignType activeCampaignType) => throw null;

    public bool ActiveCampaignReadOnlyFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveCampaignReadOnlyFlag(bool activeCampaignReadOnlyFlag) => throw null;

    public bool TrainingCenterPopupAppearedOnceFlag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTrainingCenterPopupAppearedFlag(bool trainingCenterPopupAppearOnceFlag) => throw null;

    public string ActiveCampaignDescription
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveCampaignDescription(string activeCampaignDescription) => throw null;

    public string ActiveGameMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveGameMode(string activeGameMode) => throw null;

    public DifficultyOptionsData DifficultyOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveCampaignDifficultyOptions(DifficultyOptionsData difficultyOptions) => throw null;

    public DifficultyOptionsData DefaultDifficultyOptions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDifficultyToDefault() => throw null;

    public List<TrackingStationObjectTypeFilter> ActiveTrackingStationObjectEntryFilters
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetActiveTrackingStationObjectEntryFilters(
      List<TrackingStationObjectTypeFilter> activeTrackingStationObjectEntryFilters)
    {
      throw null;
    }

    public string ActiveGalaxyDefinitionKey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public NewPlayerSetupInfo NewPlayerSetupInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ColonyManager ColonyManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CommNetManager CommNetManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string LastLaunchLocation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string SetLastLaunchLocation(string lastLaunchLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSPCampaign() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMPCampaign() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsReadOnlyCampaign() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMPHosting() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMPClient() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void InitializeSessionManager(
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket,
      SerializedSaveGameMetadata metadata)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShutdownSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedSessionManager ExportSerializedSessionManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ImportSerializedSessionManager(
      SerializedSessionManager serializedSessionManager,
      LoadOrSaveCampaignTicket loadOrSaveCampaignTicket)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMyAgencyName(string agencyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyName(int agencyId, string agencyName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetMyAgencyName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetMyAgencyID(bool logWarningIfFail = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMyAgencyColorBase(Color colorBase) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyColorBase(int agencyId, Color colorBase) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color GetMyAgencyColorBase() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMyAgencyColorAccent(Color colorAccent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyColorAccent(int agencyId, Color colorAccent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color GetMyAgencyColorAccent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMyAgencyFlagSpriteLocation(string flagSpriteLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAgencyFlagSpriteLocation(int agencyId, string flagSpriteLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetMyAgencyFlagSpriteLocation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMyAgencyFlag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMyPlayerPartColorBase(Color newColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerPartColorBase(byte playerId, Color newColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color GetMyPlayerPartColorBase() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMyPlayerPartColorAccent(Color newColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPlayerPartColorAccent(byte playerId, Color newColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color GetMyPlayerPartColorAccent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnlockPart(string partID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPartUnlocked(string partID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MarkCelestialBodyAsDiscovered(string CelestialBodyID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsCelestialBodyDiscovered(string CelestialBodyID) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ActiveCameraGroup GetMyActiveCameraGroup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetMyActiveCameraGroup(ActiveCameraGroup activeCameraGroup, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera GetCameraForGroup(ActiveCameraGroup group) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera GetMyActiveCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraEffectsSystem GetCameraRenderEffectsSystem(
      ActiveCameraGroup group,
      RenderSpaceType renderSpaceType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetCameraGimbalForGroup(ActiveCameraGroup group, out GimbalState gimbalState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetMyActiveCameraGimbalState(out GimbalState gimbalState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ICameraGimbalStateProvider InternalGetGimbalStateProviderForGroup(
      ActiveCameraGroup group)
    {
      throw null;
    }

    [Obsolete("Use GameInput instead of ControllerBinding")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    private static ControllerBinding Bind(
      KeyBinding _key = null,
      ConsoleBinding _console = null,
      AxisBinding _axis = null)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SessionManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SessionManager() => throw null;
  }
}
