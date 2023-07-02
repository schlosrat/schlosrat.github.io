// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.GraphicsSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Rendering
{
  [Serializable]
  public class GraphicsSettings
  {
    private GraphicsManager _graphicsManager;
    private PlanetSettingsLua _debugPlanetSettings;
    private PostProcessingSettingsLua _debugPostProcessSettings;
    private LightingSettingsLua _debugLightingSettings;
    private Dictionary<string, Setting> _settings;
    private const string qualityLevelcommandLineArg = "-qualityLevel";

    public event GraphicsSettings.SettingChangedHandler OnSettingChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GraphicsSettings(GraphicsManager manager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBoolSetting(string name, bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetBoolSetting(string name, ref bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetEnableClouds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableClouds(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QualityLevel GetGroundShadingQuality() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTextureQuality(int qualityLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGroundShadingQuality(int qualityLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCloudQuality(int quality) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetCloudQuality() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnableCloudLighting(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetWaterQuality(int quality) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetWaterQuality() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnableWaterLighting(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAntiAliasing(int quality) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetReflectionsEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionsEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetReflectionResolution() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionsQuality(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScatterSettings(int densityIdx, int drawDistanceIdx) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetReflectionIntensity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionIntensity(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetReflectionMipBiasMaxSteps() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionMipBiasMaxSteps(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetReflectionMipBiasGrowthRate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionMipBiasGrowthRate(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetReflectionMipBiasOffset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionMipBiasOffset(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CheckCommandLineForPreset(out string presetLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CheckCommandLineForPreset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyPreset(string preset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyPreset(PresetQualityLevel preset) => throw null;

    public delegate void SettingChangedHandler(Setting setting);
  }
}
