// Decompiled with JetBrains decompiler
// Type: KSP.UI.ApplySettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine.UI;

namespace KSP.UI
{
  public class ApplySettings
  {
    private SettingsProperties settingsProperties;
    private GraphicsSettings graphicsSettings;
    private Button applyButton;
    private Button revertButton;
    private Action onRevert;
    private Action onApply;
    private bool resolutionSelectionChanged;
    private string resolution;
    private bool fullscreenSelectionChanged;
    private bool isFullscreen;
    private bool vsyncSelectionChanged;
    private bool isVSync;
    private bool antiAliasingSelectionChanged;
    private int antiAliasing;
    private bool anisotropicFilteringSelectionChanged;
    private bool anisotropicFiltering;
    private bool textureQualitySelectionChanged;
    private int textureQuality;
    private bool conicPatchDrawModeSelectionChanged;
    private int conicPatchDrawMode;
    private bool conicPatchLimitChanged;
    private int conicPatchLimit;
    private bool partHighlighterBrightnessFactorChanged;
    private int partHighlighterBrightnessFactor;
    private bool partHighlighterEnabledInFlightChanged;
    private bool isPartHighlighterEnabledInFlight;
    private bool _suspendScatterSystemChanged;
    private bool _suspendScatterSystem;
    private bool isEnableClouds;
    private bool enableCloudsSelectionChanged;
    private bool reflectionsEnabled;
    private bool reflectionsEnabledSelectionChanged;
    private int reflectionsQuality;
    private bool reflectionsQualitySelectionChanged;
    private bool languageSelectionChanged;
    private string languageKey;
    private bool thermalHighlightsSelectionChanged;
    private bool isThermalHighlights;
    private bool temperatureGaugesSelectionChanged;
    private bool isTemperatureGauges;
    private bool evasAutoRotateToCameraSelectionChanged;
    private bool isEvasAutoRotateToCamera;
    private bool enableAutoSaves;
    private int maxNumAutosaves;
    private float autoSaveTimeInSeconds;
    private bool uiScaleFactorChanged;
    private float uiScaleBaseValue;
    private float uiScaleFactor;
    private bool defaultThrottleInPrelaunchChanged;
    private float defaultThrottleInPrelaunch;
    private float masterVolume;
    private bool _masterVolumeInitialized;
    private float musicVolume;
    private bool _musicVolumeInitialized;
    private float sfxVolume;
    private bool _sfxVolumeInitialized;
    private float voiceoverVolume;
    private bool _voiceoverVolumeInitialized;
    private float kerbalCommVolume;
    private bool _kerbalCommVolumeInitialized;
    private float ambienceVolume;
    private bool _ambienceVolumeInitialized;
    private float uiVolume;
    private bool _uiVolumeInitialized;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGraphicsSettingsReference(GraphicsSettings gs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSettingsProperties(SettingsProperties inSettingsProperties) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetApplyButton(Button button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRevertButton(Button button) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddRevertListener(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveRevertListener(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddApplyListener(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveApplyListener(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableApplyButton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableApplyButton() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideAndDisableUIElement(
      MenuLocationEnum menuLocationToValidateAgainst,
      string settingName,
      string settingHeader = "",
      string settingSpacer = "")
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideAudioUIElements(MenuLocationEnum menuLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideGraphicsUIElements(MenuLocationEnum menuLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HideGameplayUIElements(MenuLocationEnum menuLocation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetSliderValue(Slider slider, float scaled0To100AudioValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIMasterVolumeSlider(Slider target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIMusicVolumeSlider(Slider target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUISFXVolumeSlider(Slider target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIVoiceoverVolumeSlider(Slider target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIKerbalCommVolumeSlider(Slider target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIAmbienceVolumeSlider(Slider target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIUIVolumeSlider(Slider target) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIResolutionDropDown(TMP_Dropdown resolutionDropDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIFullscreenToggle(Toggle fullscreenToggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIVSyncToggle(Toggle vsyncToggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupEnableCloudsToggle(Toggle enableCloudsToggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIReflectionsEnabledToggle(Toggle reflectionsEnabledToggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIReflectionsQualityDropDown(TMP_Dropdown reflectionQualityDropDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIAntiAliasingDropDown(TMP_Dropdown antiAliasingDropDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUITextureQualityDropDown(TMP_Dropdown textureQualityDropDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIConicPatchDrawModeDropDown(TMP_Dropdown conicPatchDrawModeDropDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIConicPatchLimiterSlider(Slider conicPatchLimitSlider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIPartHighlighterBrightnessFactorSlider(
      Slider partHighlighterBrightnessFactorSlider)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIPartHighlighterEnabledInFlightToggle(
      Toggle partHighlighterEnabledInFlightToggle)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUILanguageDropDown(TMP_Dropdown languageDropDown) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIThermalHighlightsToggle(Toggle thermalHighlightsToggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUITemperatureGaugesToggle(Toggle temperatureGaugesToggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIEvasAutoRotateToCameraToggle(Toggle evasAutoRotateToCameraToggle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIScaleSlider(Slider uiScaleSlider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float UIScaleConvertCanvasToSlider(float canvasScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float UIScaleConvertSliderToCanvas(float sliderValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupUIDefaultThrottleInPrelaunchSlider(Slider defaultThrottleInPrelaunchSlider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupAutosavesEnabled(Toggle tog) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupMaxAutosaves(Slider slid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupAutosaveTimeMinutes(Slider slid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsResolutionSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetResolution() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetResolution(string newResolution, bool isFullscreenOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyResolutionChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsFullscreenSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetFullscreenOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFullscreen(bool isFullscreenOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyFullscreenChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsVSyncSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetVSync() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVSync(bool isVSyncOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyVSyncChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEnableCloudsSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetEnableClouds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnableClouds(bool isEnableCloudsOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyEnableCloudsChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyEnableAntiTile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionsEnabled(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyReflectionsEnabledChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionsQuality(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyReflectionsQualityChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SuspendScatterSystem(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyScatterSettingsChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAntiAliasingSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetAntiAliasing() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAntiAliasing(int newAntiAliasing) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAntiAliasingChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAnisotropicFilteringChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetAnisotropicFiltering() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAnisotropicFiltering(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsTextureQualitySelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetTextureQuality() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTextureQuality(int newTextureQuality) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyTextureQuality() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsConicPathDrawModeSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetConicPatchDrawMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetConicPatchDrawMode(int newConicPatchDrawMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyConicPatchDrawMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsConicPatchLimitSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetConicPatchLimit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetConicPatchLimit(float newConicPatchLimit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyConicPatchLimitChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPartHighlighterBrightnessFactorChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetPartHighlighterBrightnessFactor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPartHighlighterBrightnessFactor(float newPartHighlighterBrightnessFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyPartHighlighterBrightnessFactorChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPartHighlighterEnabledInFlightSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetPartHighlighterEnabledInFlight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPartHighlighterEnabledInFlight(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyPartHighlighterEnabledInFlightChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsLanguageSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetLanguageKey() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLanguageKey(string newLanguageKey) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyLanguageChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetThermalHighlights(bool isThermalHighlightsOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyThermalHighltsChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsTemperatureGaugesSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTemperatureGauges(bool isTemperatureGaugesOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyTemperatureGaugesChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEvasAutoRotateToCameraSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEvasAutoRotateToCamera(bool isEvasAutoRotateToCameraOn) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyEvasAutoRotateToCameraChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsUIScaleFactorChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetUIScaleFactor() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUIScaleFactor(float newUIScaleFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyUIScaleFactorChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDefaultThrottleInPrelaunchChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDefaultThrottleInPrelaunch(float newDefaultThrottleInPrelaunch) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyDefaultThrottleInPrelaunchChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetEnableAutosaves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnableAutosaves(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyEnableAutosaves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetMaxNumAutosaves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMaxNumAutosaves(float num) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyMaxNumAutosaves() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetAutosaveTimeInMinutes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAutoSaveTimeInMinutes(float num) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyAutoSaveTimeInMinutes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMasterVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMasterVolume(float newMasterVolume) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyMasterVolumeChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMusicVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMusicVolume(float newMusicVolume) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyMusicVolumeChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSFXVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSFXVolume(float newSfxVolume) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplySFXVolumeChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetVoiceoverVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVoiceoverVolume(float newVoiceoverVolume) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyVoiceoverVolumeChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetKerbalCommVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetKerbalCommVolume(float newVolume) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyKerbalCommVolumeChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetAmbienceVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAmbienceVolume(float newVolume) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAmbienceVolumeChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetUIVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUIVolume(float newVolume) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyUIVolumeChange() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnApply() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnRevert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ApplySettings() => throw null;
  }
}
