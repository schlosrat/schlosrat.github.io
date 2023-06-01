// Decompiled with JetBrains decompiler
// Type: KSP.VFX.Sun
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  public class Sun : KerbalMonoBehaviour
  {
    private IUniverseModel universeModel;
    private CelestialBodyComponent sunModel;
    private CelestialBodyBehavior sunView;
    [Header("Lens Flares")]
    public Flare currentFlare;
    public Flare sunFlareKerbol;
    public Flare sunFlareDebdeb;
    protected LensFlare physicsLensFlare;
    protected LensFlare scaledLensFlare;
    [Header("Intensity & Color")]
    public Color sunColorKerbol;
    public Color sunColorDebdeb;
    public float sunIntensity;
    [Header("Sun Stuff")]
    public Vector3d sunDirection;
    protected Light scaledSunLight;
    protected Light physicsSunLight;
    public float localTime;
    public float fadeStart;
    public float fadeEnd;
    public float shadowBiasSpaceCentre;
    public float shadowBiasFlight;
    public int sunRotationPrecision;
    [Header("Debug (Editor Only)")]
    public bool debugRaycasts;
    public bool debugHitGameObjects;
    public float attenuationValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static Sun Create(
      GameObject prefab,
      IUniverseModel universeModel,
      IUniverseView universeView,
      CelestialBodyComponent celestialBodyModel,
      CelestialBodyBehavior celesitalBodyView)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Sun() => throw null;
  }
}
