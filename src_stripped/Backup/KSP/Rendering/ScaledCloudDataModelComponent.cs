// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.ScaledCloudDataModelComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering.Planets;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering
{
  public class ScaledCloudDataModelComponent : KerbalMonoBehaviour
  {
    private static readonly string ScaledCloudGameObjectName;
    private static readonly float kScaledCloudFactor;
    private string _planetName;
    [SerializeField]
    public ScaledCloudConfiguration ScaledCloudConfiguration;
    private VolumeCloudManager _volumeCloudManagerRef;
    private ScaledCloudConfiguration _model;
    private Light _starLight;
    private bool _inMap;
    private MeshRenderer _scaledCloudRenderer;
    private Material _scaledCloudsMaterial;
    public List<Material> ScaledCloudMaterials;
    public List<ScaledClouds> ScaledCloudClass;
    private int CreateCompleteCount;
    private bool IsfinishCreateLayer;
    private AtmosphereDataModelComponent atmosphereDataComp;
    private CoreCelestialBodyData coreCelestialBodyData;

    public string PlanetName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize(VolumeCloudManager manager, bool inMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Material GetMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasModelReference() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetModelReference(ScaledCloudConfiguration model) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTransition(float transition, float ditherScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPreRenderObserverCubemap(float transition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPostRenderObserverCubemap(float transition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPreRenderCelestialBodyCubemap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPostRenderCelestialBodyCubemap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRenderQueue(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLightProbe(SphericalHarmonicsL2 probe, Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FlightViewUpdate(Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MapViewUpdate(Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool IsEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GetScaledCloudRendererReference() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateScaledCloudLayers(Action<ScaledCloudDataModelComponent> callback) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaledCloudDataModelComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ScaledCloudDataModelComponent() => throw null;
  }
}
