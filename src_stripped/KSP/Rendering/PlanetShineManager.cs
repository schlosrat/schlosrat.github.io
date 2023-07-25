// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.PlanetShineManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class PlanetShineManager : KerbalMonoBehaviour, IUpdate
  {
    public LightingSystem _lightingSystem;
    private GraphicsManager graphicsManager;
    public List<(string name, double visibility)> visibleBodies;
    public Dictionary<string, LightData> localBodies;
    private Position observedPos;
    private bool inOAB;
    private bool inMap;
    private const float lensFlareSizeMult = 3f;
    private const float dotFadeStart = 0.0f;
    private const float dotFadeEnd = -0.7f;

    private IPhysicsSpaceProvider PhysicsSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CelestialBodyProvider CelestialBodyProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABUnloaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapEntered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapExited() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateShineIntensity(
      string body,
      Position observerPos,
      double visibility,
      CelestialBodyLightingData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateFlareIntensity(
      Position bodyPos,
      Position observerPos,
      CelestialBodyLensFlare data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Quaternion RotateLightToObserver(Position bodyPos, Position observerPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleAllLights(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleLightVisibility(Light light, ProFlare flare, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlanetShineManager() => throw null;
  }
}
