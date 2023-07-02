// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Light
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Light : PartBehaviourModule
  {
    [FormerlySerializedAs("data")]
    [SerializeField]
    protected Data_Light dataLight;
    public List<KSPLight> kspLights;
    public Renderer lightMeshRenderer;
    public float emissionHDRIntensity;
    public float maxLightIntensity;
    public Transform rotationTransform;
    private bool _blinkState;
    private float _remainingBlinkDuration;
    private Color _lightColor;
    private Color _currentLightColor;
    private float _elapsedTransitionTime;
    private float _currentIntensity;
    private bool _isBrightening;
    private bool _isDimming;
    private const string EMISSION_COLOR_MATERIAL_PROPERTY = "_EmissionColor";
    private KSPPartAudioManager _kspPartAudioManager;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool IsTransitioningToDisabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLight(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLightStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLightStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLightState(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLightColors() => throw null;

    private Color CurrentHDREmissionColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private bool IsIlluminated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateHDRColorIntensity(float intensity, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetLightIntensity(float brightValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBlinkEnabled(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeBlink() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBlinkState(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateBlinkingLight(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void InitProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBlinkMode(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetCastLight(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLightEnabledChanged(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLightColorChanged(float cValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBlinkEnabledChanged(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCastLightChanged(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotationAngleChanged(float cValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnIsAdvancedSettingsShownChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdatePAMControlVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Light() => throw null;
  }
}
