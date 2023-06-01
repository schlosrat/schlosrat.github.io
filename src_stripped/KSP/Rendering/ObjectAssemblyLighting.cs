// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ObjectAssemblyLighting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering
{
  public class ObjectAssemblyLighting : KerbalMonoBehaviour
  {
    [Header("Lightmap Data Objects")]
    public PrefabLightmapDataObject dayData;
    public PrefabLightmapDataObject eveningData;
    public PrefabLightmapDataObject nightData;
    [Header("Deferred Fog")]
    public FogMode fogMode;
    public float fogDensity;
    public Color dayFogColor;
    public Color eveningFogColor;
    public Color nightFogColor;
    [Header("Reflections")]
    public ReflectionProbe reflectionProbe;
    public Cubemap dayCubemap;
    public Cubemap eveningCubemap;
    public Cubemap nightCubemap;
    [Header("Light Shafts")]
    public GameObject[] lightShafts;
    [Header("Directional Light")]
    public Light nightLight;
    public float nightLightMinIntensity;
    public float nightLightMaxIntensity;
    public float timeOfDayMinDot;
    public float timeOfDayMaxDot;
    private GraphicsManager GraphicsManager;
    private LightingSystem LightingSystem;
    private Color _fogColorA;
    private Color _fogColorB;
    private RendererInfo[] _rendererInfo;
    private bool _blendLightmapData;
    private SphericalHarmonicsL2 _probeA;
    private SphericalHarmonicsL2 _probeB;
    private Cubemap _cubemapA;
    private Cubemap _cubemapB;
    private const string CUBEMAP_BLEND = "ObjectAssemblyLighting_CubemapBlend";
    private RenderTexture _cubemapBlend;
    private bool _blendCubemaps;
    private bool _dayDataSet;
    private bool _nightDataSet;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLightShafts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeActiveLightmapData(
      PrefabLightmapDataObject dataA,
      PrefabLightmapDataObject dataB)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugEnableTimeZoom(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyLighting() => throw null;
  }
}
