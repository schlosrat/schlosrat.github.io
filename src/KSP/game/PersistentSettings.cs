// Decompiled with JetBrains decompiler
// Type: KSP.Game.PersistentSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.IO;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Game
{
  [JsonObject(MemberSerialization.OptIn)]
  public class PersistentSettings : VersionedBase
  {
    public const IOProvider.DataLocation SettingsFileLocation = IOProvider.DataLocation.Global;
    public const string SettingsFilename = "Settings";
    public const string CURRENT_FILE_VERSION = "0.1.0";
    public static readonly string[] PreviousFileVersionsThatRequireReset;
    public const string DEFAULT_LANGUAGE_KEY = "en";
    [JsonProperty("LanguageKey")]
    public string LanguageKey;
    public const float DEFAULT_MASTER_VOLUME = 100f;
    [JsonProperty("MasterVolume")]
    public float MasterVolume;
    public const float DEFAULT_MUSIC_VOLUME = 100f;
    [JsonProperty("MusicVolume")]
    public float MusicVolume;
    public const float DEFAULT_SFX_VOLUME = 100f;
    [JsonProperty("SFXVolume")]
    public float SFXVolume;
    public const float DEFAULT_VOICE_VOLUME = 100f;
    [JsonProperty("VoiceVolume")]
    public float VoiceVolume;
    public const float DEFAULT_KERBALCOMM_VOLUME = 100f;
    [JsonProperty("KerbalCommVolume")]
    public float KerbalCommVolume;
    public const float DEFAULT_KERBALIVA_VOLUME = 100f;
    [JsonProperty("KerbalIVAVolume")]
    public float KerbalIVAVolume;
    public const float DEFAULT_AMBIENCE_VOLUME = 100f;
    [JsonProperty("AmbienceVolume")]
    public float AmbienceVolume;
    public const int DEFAULT_AUDIO_LISTENING_MODE = 0;
    [JsonProperty("AudioListeningMode")]
    public int AudioListeningMode;
    public const bool DEFAULT_TAB_AWAY_AUDIO = false;
    [JsonProperty("TabAwayAudio")]
    public bool TabAwayAudio;
    public const float DEFAULT_UI_VOLUME = 100f;
    [JsonProperty("UIVolume")]
    public float UIVolume;
    public const string DEFAULT_QUALITY_PRESET = "high";
    [JsonProperty("QualityPreset")]
    public string QualityPreset;
    public const string DEFAULT_SCREEN_RESOLUTION = "1920x1080";
    [JsonProperty("ScreenResolution")]
    public string ScreenResolution;
    public const bool DEFAULT_IS_FULLSCREEN = false;
    [JsonProperty("IsFullscreen")]
    public bool IsFullscreen;
    public const FullScreenMode DEFAULT_FULLSCREEN_MODE = FullScreenMode.FullScreenWindow;
    [JsonProperty("FullScreenMode")]
    public FullScreenMode FullScreenMode;
    public const bool DEFAULT_IS_VSYNC = true;
    [JsonProperty("IsVsync")]
    public bool IsVsync;
    public const bool DEFAULT_CLOUDS_ENABLED = true;
    [JsonProperty("CloudsEnabled")]
    public bool CloudsEnabled;
    public const int DEFAULT_CLOUD_QUALITY = 2;
    [JsonProperty("CloudQuality")]
    public int CloudQuality;
    public const int DEFAULT_WATER_QUALITY = 2;
    [JsonProperty("WaterQuality")]
    public int WaterQuality;
    public const int DEFAULT_GROUND_SHADING_QUALITY = 2;
    [JsonProperty("GroundShadingQuality")]
    public int GroundShadingQuality;
    public const bool DEFAULT_REFLECTIONS_ENABLED = true;
    [JsonProperty("ReflectionsEnabled")]
    public bool ReflectionsEnabled;
    public const int DEFAULT_REFLECTIONS_QUALITY = 0;
    [JsonProperty("ReflectionsQuality")]
    public int ReflectionsQuality;
    public const int DEFAULT_ANTI_ALIASING = 2;
    [JsonProperty("AntiAliasing")]
    public int AntiAliasing;
    public const bool DEFAULT_ANISOTROPIC_FILTERING = true;
    [JsonProperty("AnisotropicFiltering")]
    public bool AnisotropicFiltering;
    public const ShadowQuality DEFAULT_SHADOW_QUALITY = ShadowQuality.All;
    [JsonProperty("ShadowQuality")]
    public ShadowQuality ShadowQuality;
    public const ShadowResolution DEFAULT_SHADOW_RESOLUTION = ShadowResolution.High;
    [JsonProperty("ShadowResolution")]
    public ShadowResolution ShadowResolution;
    public const int DEFAULT_TEXTURE_QUALITY = 0;
    [JsonProperty("TextureQuality")]
    public int TextureQuality;
    public const float DEFAULT_UI_SCALE_FACTOR = 1f;
    [JsonProperty("UIScaleFactor")]
    public float UIScaleFactor;
    public const int DEFAULT_CONIC_PATCH_DRAWMODE = 0;
    [JsonProperty("ConicPatchDrawMode")]
    public int ConicPatchDrawMode;
    public const int DEFAULT_CONIC_PATCH_LIMIT = 3;
    [JsonProperty("ConicPatchLimit")]
    public int ConicPatchLimit;
    public const int DEFAULT_PART_HIGHLIGHTER_BRIGHTNESS_FACTOR = 0;
    [JsonProperty("PartHighlighterBrightnessFactor")]
    public int PartHighlighterBrightnessFactor;
    public const bool DEFAULT_SCATTER_STATE = true;
    [JsonProperty("ScatterState")]
    public bool ScatterState;
    public const int DEFAULT_SCATTER_DENSITY = 3;
    [JsonProperty("ScatterDensity")]
    public int ScatterDensity;
    public const int DEFAULT_SCATTER_DRAW_DISTANCE = 2;
    [JsonProperty("ScatterClutterDrawDistance")]
    public int ScatterClutterDrawDistance;
    public const bool DEFAULT_SCATTER_SYSTEM_SUSPENDED = false;
    [JsonProperty("ScatterSystemSuspended")]
    public bool ScatterSystemSuspended;
    public const bool DEFAULT_PART_HIGHLIGHTING_ENABLED_IN_FLIGHT = false;
    [JsonProperty("PartHighlightingEnabledInFlight")]
    public bool PartHighlightingEnabledInFlight;
    public const bool DEFAULT_IS_THERMAL_HIGHLIGHTS = false;
    [JsonProperty("IsThermalHighlights")]
    public bool IsThermalHighlights;
    public const bool DEFAULT_IS_TEMPERATURE_GAUGES = false;
    [JsonProperty("IsTemperatureGauges")]
    public bool IsTemperatureGauges;
    public const bool DEFAULT_SHOW_VESSEL_LABELS = true;
    [JsonProperty("ShowVesselLabels")]
    public bool ShowVesselLabels;
    public const bool DEFAULT_IS_EVAS_AUTO_ROTATE_TO_CAMERA = false;
    [JsonProperty("IsEVAsAutoRotateToCamera")]
    public bool IsEVAsAutoRotateToCamera;
    public const float DEFAULT_INITIAL_THROTTLE_IN_PRELAUNCH = 1f;
    [JsonProperty("InitialThrottleInPreLaunch")]
    public float InitialThrottleInPreLaunch;
    public const bool DEFAULT_SKIP_LAUNCH_SEQUENCE = false;
    [JsonProperty("SkipLaunchSequence")]
    public bool SkipLaunchSequence;
    public const bool DEFAULT_SHOW_FPS = false;
    [JsonProperty("ShowFPS")]
    public bool ShowFPS;
    public const bool DEFAULT_VERBOSE_LOGGING = true;
    [JsonProperty("VerboseLogging")]
    public bool VerboseLogging;
    public const bool DEFAULT_AUTO_SAVE_ENABLED = true;
    [JsonProperty("AutoSaveEnabled")]
    public bool AutoSaveEnabled;
    public const float DEFAULT_AUTO_SAVE_TIME_SECONDS = 600f;
    [JsonProperty("AutoSaveTimeSeconds")]
    public float AutoSaveTimeSeconds;
    public const int DEFAULT_MAX_NUM_AUTO_SAVES = 3;
    [JsonProperty("MaxNumAutoSaves")]
    public int MaxNumAutoSaves;
    public const bool DEFAULT_OAB_AUTO_SAVE_ENABLED = true;
    [JsonProperty("OABAutoSaveEnabled")]
    public bool OABAutoSaveEnabled;
    public const float DEFAULT_OAB_AUTO_SAVE_TIME_SECONDS = 300f;
    [JsonProperty("OABAutoSaveTimeSeconds")]
    public float OABAutoSaveTimeSeconds;
    public const int DEFAULT_OAB_MAX_NUM_AUTO_SAVES = 3;
    [JsonProperty("OABMaxNumAutoSaves")]
    public int OABMaxNumAutoSaves;
    public const int DEFAULT_MAX_DEBRIS_COUNT = 50;
    [JsonProperty("MaxDebrisCount")]
    public int MaxDebrisCount;
    public const string DEFAULT_MOST_RECENT_CAMPAIGN_NAME = "";
    [JsonProperty("MostRecentCampaignName")]
    public string MostRecentCampaignName;
    public const CampaignType DEFAULT_MOST_RECENT_CAMPAIGN_TYPE = CampaignType.SinglePlayer;
    [JsonProperty("MostRecentCampaignType")]
    public CampaignType MostRecentCampaignType;
    public const string DEFAULT_PLAYER_LEGAL_ACCEPTANCE_STRING = "";
    [JsonProperty("PlayerEULALegalAcceptanceUTCTime")]
    public string PlayerEULALegalAcceptanceUTCTime;
    [JsonProperty("PlayerPPLegalAcceptanceUTCTime")]
    public string PlayerPPLegalAcceptanceUTCTime;
    [JsonProperty("PlayerTOSLegalAcceptanceUTCTime")]
    public string PlayerTOSLegalAcceptanceUTCTime;
    [JsonProperty("PlayerEULALegalAcceptanceVersion")]
    public string PlayerEULALegalAcceptanceVersion;
    [JsonProperty("PlayerPPLegalAcceptanceVersion")]
    public string PlayerPPLegalAcceptanceVersion;
    [JsonProperty("PlayerTOSLegalAcceptanceVersion")]
    public string PlayerTOSLegalAcceptanceVersion;
    public const bool REQUIRE_HELD_QUICK_LOAD = false;
    [JsonProperty("RequireHeldQuickLoad")]
    public bool RequireHeldQuickLoad;
    public const string SUB_TITLE_TEXT_SIZE = "Medium";
    [JsonProperty("SubtitleTextSize")]
    public string SubtitleTextSize;
    public const bool IS_FTUE_ENABLED = true;
    [JsonProperty("IsFTUEEnabled")]
    public bool IsFTUEEnabled;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PersistentSettings() => throw null;

    protected override string CurrentVersionString
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PersistentSettings() => throw null;
  }
}
