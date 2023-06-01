// Decompiled with JetBrains decompiler
// Type: KSP.UI.GraphicsSettingsMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering;
using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace KSP.UI
{
  public class GraphicsSettingsMenu : SettingsSubMenu, IMenu, IDisposable
  {
    private const int PATCH_CONIC_PATCHES_MIN = 2;
    private const int PATCH_CONIC_PATCHES_MAX = 6;
    private const float PART_HIGHLIGHT_BRIGHTNESS_SCALAR = 100f;
    [SerializeField]
    private TMP_Dropdown qualityPresetDropdown;
    [SerializeField]
    private TMP_Dropdown resolutionDropDown;
    [SerializeField]
    private Toggle vsyncToggle;
    [SerializeField]
    private TMP_Dropdown windowModeDropDown;
    [SerializeField]
    private TMP_Dropdown antiAliasingDropDown;
    [SerializeField]
    private Toggle anisotropicFilteringToggle;
    [SerializeField]
    private TMP_Dropdown textureQualityDropDown;
    [SerializeField]
    private TMP_Dropdown shadowQualityDropDown;
    [SerializeField]
    private TMP_Dropdown shadowResolutionDropDown;
    [SerializeField]
    private Toggle enableCloudsToggle;
    [SerializeField]
    private TMP_Dropdown cloudQualityDropDown;
    [SerializeField]
    private Toggle enableCloudLightingToggle;
    [SerializeField]
    private TMP_Dropdown waterQualityDropDown;
    [SerializeField]
    private Toggle enableWaterLightingToggle;
    [SerializeField]
    private TMP_Dropdown ringFXQualityDropDown;
    [SerializeField]
    private Toggle reflectionsEnabledToggle;
    [SerializeField]
    private TMP_Dropdown reflectionsQualityDropDown;
    [SerializeField]
    private SliderExtended conicPatchLimitSlider;
    [SerializeField]
    private SliderExtended partHighlighterBrightnessFactorSlider;
    public GraphicsSettings graphicsSettings;
    private bool _firstOpenInit;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupCVar(bool hasPreset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyQualityPresetUIChanges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RevertUIChanges() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnQualityPresetChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResolutionChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnFullscreenChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWindowModeChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVSyncChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAntiAliasingChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAnisotropicFilteringChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTextureQualityChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShadowQualityChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShadowResolutionChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnableCloudChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCloudQualityChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWaterQualityChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnReflectionEnabledChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnReflectionQualityChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnConicPatchLimitChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPartHighlightBrightnessFactorChanged(float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyQualityPreset(CVar presetValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyResolution(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyWindowMode(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyVSync(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAntialiasing(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAnisotropicFiltering(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyTextureQuality(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyShadowQuality(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyShadowResolution(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyEnableClouds(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyCloudQuality(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyEnableCloudLighting(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyWaterQuality(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyEnableWaterLighting(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyEnableReflection(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyReflectionQuality(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyConicPatchLimit(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyPartHighlighterBrightnessFactor(CVar selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetResolutionIndex(string res) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetQualityPresetIndex(string presetName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWindowMode(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private FullScreenMode GetWindowMode(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetWindowModeDropdownValue(FullScreenMode fullScreenMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ShadowQuality GetShadowQuality(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ShadowResolution GetShadowResolution(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void IsActive(bool isActive) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GraphicsSettingsMenu() => throw null;
  }
}
