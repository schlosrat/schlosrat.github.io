// Decompiled with JetBrains decompiler
// Type: KSP.UI.GraphicsSettingsMenuManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Rendering;
using KSP.UI.Binding;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace KSP.UI
{
  public class GraphicsSettingsMenuManager : SettingsSubMenu
  {
    public bool IncludeUWResolutions;
    private GraphicsSettings _graphicsSettings;
    private const string GAME_SCREEN_MODE_PROPERTY_KEY = "GameScreenMode";
    private const string V_SYNC_PROPERTY_KEY = "VSync";
    private const string RESOLUTION_PROPERTY_KEY = "Resolution";
    private const string ANTI_ALIASING_PROPERTY_KEY = "AntiAliasing";
    private const string ANISOTROPIC_FILTERING_PROPERTY_KEY = "AnisotropicFiltering";
    private const string PC_PROPERTY_KEY = "PC";
    private const string ENVIRONMENT_PROP_PROPERTY_KEY = "EnvironmentProp";
    private const string SCATTER_DENSITY_PROPERTY_KEY = "ScatterDensity";
    private const string SCATTER_CLUTTER_DRAW_DISTANCE_PROPERTY_KEY = "ScatterClutterDrawDistance";
    private const string WATER_QUALITY_PROPERTY_KEY = "WaterQuality";
    private const string SHADOW_DETAILS_PROPERTY_KEY = "ShadowDetails";
    private const string SHADOW_QUALITY_PROPERTY_KEY = "ShadowQuality";
    private const string CLOUD_QUALITY_PROPERTY_KEY = "CloudQuality";
    private const string GROUND_SHADING_QUALITY_PROPERTY_KEY = "GroundShadingQuality";
    private const string TEXTURE_QUALITY_PROPERTY_KEY = "TextureQuality";
    private const string REENTRY_FX_QUALITY_PROPERTY_KEY = "ReentryQuality";
    private const string IS_REENTRY_ENABLED = "IsReentryEnabled";
    private const float WIDESCREEN_ASPECT_RATIO = 1.77777779f;
    private const float ULTRA_WIDE_ASPECT_RATIO = 2.38888884f;
    [SerializeField]
    private TMP_Dropdown _resolutionDropDown;
    private List<Resolution> _availableResolutions;
    [SerializeField]
    private GameObject _environmentPropOffLayer;
    public Property<bool> IsReentryEnabled;
    [SerializeField]
    private ContextBindRoot _bindRoot;
    private DataContext _dataContext;
    private Property<GraphicsSettingsMenuManager.GameScreenModeEnum> _gameScreenMode;
    private Property<bool> _vSync;
    private Property<string> _resolution;
    private Property<GraphicsSettingsMenuManager.AntiAliasingMode> _antiAliasing;
    private Property<bool> _anisotropicFiltering;
    private static GraphicsSettingsMenuManager.QualityMode defaultQualityPreset;
    private Property<GraphicsSettingsMenuManager.QualityMode> _qualityPreset;
    private Property<bool> _environmentProp;
    private Property<GraphicsSettingsMenuManager.QualityMode> _scatterDensity;
    private Property<GraphicsSettingsMenuManager.QualityMode> _scatterClutterDrawDistance;
    private Property<GraphicsSettingsMenuManager.QualityMode> _waterQuality;
    private Property<GraphicsSettingsMenuManager.QualityMode> _shadowDetails;
    private Property<GraphicsSettingsMenuManager.QualityMode> _shadowQuality;
    private Property<GraphicsSettingsMenuManager.QualityMode> _cloudQuality;
    private Property<GraphicsSettingsMenuManager.QualityMode> _groundShadingQuality;
    private Property<GraphicsSettingsMenuManager.QualityMode> _textureQuality;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeContextBinding() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeResolutionDropdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Revert() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnScreenModeChanged(
      GraphicsSettingsMenuManager.GameScreenModeEnum value)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnResolutionChanged(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVSyncChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAnisotropicFilteringChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAntiAliasingChanged(GraphicsSettingsMenuManager.AntiAliasingMode value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnQualityPresetChanged(GraphicsSettingsMenuManager.QualityMode value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnvironmentPropChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnScatterDensityChanged(GraphicsSettingsMenuManager.QualityMode value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnScatterClutterDrawDistanceChanged(GraphicsSettingsMenuManager.QualityMode value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWaterQualityChanged(GraphicsSettingsMenuManager.QualityMode value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShadowQualityChanged(GraphicsSettingsMenuManager.QualityMode value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnShadowDetailChanged(GraphicsSettingsMenuManager.QualityMode value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCloudQualityChanged(GraphicsSettingsMenuManager.QualityMode value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGroundShadingQualityChanged(GraphicsSettingsMenuManager.QualityMode quality) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTextureQualityChanged(GraphicsSettingsMenuManager.QualityMode quality) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyScreenMode(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyResolution(string resolution) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyVSync(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAnisotropicFiltering(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyAntialiasing(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyQualityPreset(string presetValue, bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyEnvironmentProp(bool selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyScatterDensity(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyScatterClutterDrawDistance(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyWaterQuality(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyShadowQuality(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyShadowDetail(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyCloudQuality(int selectionValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyGroundShadingQuality(int qualitySelection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ApplyTextureQuality(int qualityLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWindowMode(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetResolutionIndex(string res) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetTextureQualityLevelForUnity(int settingsValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MatchUIToSettingsValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GraphicsSettingsMenuManager.QualityMode GetQualityPreset(string presetName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static GraphicsSettingsMenuManager.GameScreenModeEnum GetScreenModeEnumFromInt(
      int screenMode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static GraphicsSettingsMenuManager.GameScreenModeEnum GetScreenModeFromFullScreenMode(
      FullScreenMode mode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static FullScreenMode GetFullScreenModeFromScreenMode(
      GraphicsSettingsMenuManager.GameScreenModeEnum mode)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int GetIntFromFullScreenMode(FullScreenMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static FullScreenMode GetGetIntFromFullScreenModeFromInt(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GraphicsSettingsMenuManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static GraphicsSettingsMenuManager() => throw null;

    private enum GameScreenModeEnum
    {
      [Description("Menu/Graphics/Fullscreen")] Fullscreen,
      [Description("Menu/Graphics/Borderless Windowed")] Borderless,
      [Description("Menu/Graphics/Window Mode")] Windowed,
    }

    private enum AntiAliasingMode
    {
      Off,
      On4x,
      On8x,
    }

    private enum QualityMode
    {
      [Description("low")] Low,
      [Description("medium")] Medium,
      [Description("high")] High,
    }
  }
}
