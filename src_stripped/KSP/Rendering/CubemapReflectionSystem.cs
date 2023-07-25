// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CubemapReflectionSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering.impl;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class CubemapReflectionSystem : MonoBehaviour, IUpdate, ILateUpdate
  {
    private GameInstance Game;
    private PrevisGameInstance PrevisGame;
    private bool _previsScene;
    [SerializeField]
    private LightingSystem LightingSystem;
    private GraphicsManager GraphicsManager;
    private UniverseCameraManager CameraManager;
    private SessionManager SessionManager;
    private ObserverCubemapView ObserverCubemapView;
    private CelestialBodyCubemapView CelestialBodyCubemapView;
    private RenderKitSettings RenderKitSettings;
    private RenderTexture celestialBodyCubemap;
    private ActiveCameraGroup _activeCameraGroup;
    private Camera _observerCubemapCamera;
    [SerializeField]
    private Texture _observerCubemap;
    private bool _reflectionInit;
    private bool _cubemapReflectionsActive;
    private Camera _celestialCubemapCamera;
    [SerializeField]
    private Texture _celestialCubemap;
    [SerializeField]
    private CubemapSettings _reflectionSettings;
    private CubemapConfig _curReflectionConfig;
    [SerializeField]
    private Cubemap _galaxyCubemap;
    [SerializeField]
    private Material _galaxySkybox;
    [SerializeField]
    private Material _oabSkybox;
    [SerializeField]
    private float _oabSkyboxExposure;
    private GraphicsSettings GraphicsSettings;
    private bool _enabledSettingChanged;
    private bool _cachedEnabledSetting;
    private bool _qualitySettingChanged;
    private int _cachedQualitySetting;
    [SerializeField]
    private float _diffuseAmbientIntensity;
    [SerializeField]
    private float _diffuseCubemapIntensity;
    [SerializeField]
    private int _diffuseCubemapMip;
    [SerializeField]
    private float _specularCubemapIntensity;
    [SerializeField]
    private int _mipBiasMaxStep;
    [SerializeField]
    private int _mipBiasGrowthRate;
    [SerializeField]
    private float _mipBiasOffset;
    private bool _inOAB;
    private GameObject _simObjectVAB;
    public int[] cubemapResolutions;
    public int debugCubemapFace;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(LightingSystem lightingSystem, bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSettingChanged(Setting setting) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABUnloaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapExited() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapEntered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnTimeZoomChangeCompleted(int rate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnCameraChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ForceRefreshCubemap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableRendering() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisableRendering() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Texture GetObserverCubemapTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ILateUpdate.OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitCubemapSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool GetEnabledFromSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetResolutionFromSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetResolutionFromQualityValue(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionsEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetReflectionEnabledPrevis(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionsResolution(int value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRenderKitSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetReflectionConfig(CubemapSettings settings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateObserverCubemapView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyObserverCubemapView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateCelestialBodyCubemapView(string body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DestroyCelestialBodyCubemapView() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Camera CreateCelestialBodyCubemapCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CubemapReflectionSystem() => throw null;
  }
}
