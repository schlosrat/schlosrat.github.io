// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.LightingSettingsLua
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.ScriptInterop;
using System.Runtime.CompilerServices;

namespace KSP.Rendering
{
  public class LightingSettingsLua
  {
    public const string ATMOSPHERIC_SCATTERING_ENABLED_NAME = "AtmosphericScatteringEnabled";
    public const string GLOBAL_ILLUMINATION_ENABLED_NAME = "GlobalIlluminationEnabled";
    public const string GLOBAL_ILLUMINATION_OBSERVER_ENABLED_NAME = "GlobalIlluminationObserverEnabled";
    public const string REFLECTIONS_ENABLED_NAME = "ReflectionsEnabled";
    private IScriptEnvironment scriptEnvironment;
    private GraphicsSettings graphicsSettings;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LightingSettingsLua(GraphicsSettings settings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEnvironment(IScriptEnvironment scriptEnvironment) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SetAtmosphericScatteringEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetAtmosphericScatteringEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SetGlobalIlluminationEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetGlobalIlluminationEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SetGlobalIlluminationObserverEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetGlobalIlluminationObserverEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int SetReflectionsEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetReflectionsEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetReflectionIntensity(int intensity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetReflectionIntensity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetReflectionMipBiasMaxSteps(int maxSteps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetReflectionMipBiasMaxSteps() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetReflectionMipBiasGrowthRate(int rate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetReflectionMipBiasGrowthRate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int SetReflectionMipBiasOffset(int offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetReflectionMipBiasOffset() => throw null;
  }
}
