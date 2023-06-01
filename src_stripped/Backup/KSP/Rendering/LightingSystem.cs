// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.LightingSystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering.Planets;
using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class LightingSystem : KerbalMonoBehaviour
  {
    public GraphicsManager GraphicsManager;
    public CelestialBodyStarManager CelestialBodyStarManager;
    public AtmosphereScatterManager AtmosphereScatterManager;
    public VolumeCloudManager VolumeCloudManager;
    public CelestialBodyGIProbeManager CelestialBodyGIProbeManager;
    public CelestialBodyLensFlareSystem LensFlareSystem;
    public CelestialBodyMapLighting CelestialBodyMapLighting;
    public CubemapReflectionSystem CubemapReflectionSystem;
    public DynamicAmbientLight DynamicAmbientLight;
    private bool _currentSOIIsStar;
    private string _currentSOIName;
    private string _currentStarName;
    private Light _currentStarLocalLight;
    private Light _currentStarScaledLight;
    private const float SHADOW_STRENGTH = 1f;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSOIEntered(string bodyEntered, bool isStar, CelestialBodyRingGroup ringGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGameStateChanged(GameState previousState, GameState currentState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPrevisSceneStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateLightingSystem() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSOIBodyName(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetSOIStarStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetSOIBodyName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetCurrentStarName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Light GetCurrentStarLocalLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Light GetCurrentStarScaledLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float CalculateObserverIntensity(
      string body,
      Position observerPos,
      float falloff,
      CelestialBodyLightingData lightData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateOverrideIntensity(
      string soiBody,
      string overrideBody,
      Position observerPos,
      float potentialIntensity,
      LightData soiLightData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color CalculatePotentialColor(
      string body,
      Position observerPos,
      CelestialBodyLightingData lightData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color CalculateOverrideColor(
      string soiBody,
      string overrideBody,
      Position observerPos,
      Color potentialColor,
      LightData soiLightData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFlightStarLights(string body, bool isStar) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Divide(float num, float denom) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Light CreateLocalSpaceLight(string name, bool isStar, CelestialBodyLightingData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Light CreateScaledSpaceLight(string name, CelestialBodyLightingData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Light CreateMapViewLight(string name, CelestialBodyLightingData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LightingSystem.LayeredLight CreateOABEnvLight(
      string name,
      CelestialBodyLightingData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion GetRotatationOfLightToOABObserver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LightingSystem() => throw null;

    public struct LayeredLight
    {
      public GameObject lightParent;
      public Light lightPrimary;
      public Light lightAccent;
    }
  }
}
