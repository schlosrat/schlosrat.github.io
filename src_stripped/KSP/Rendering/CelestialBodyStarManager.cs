// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyStarManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.OAB;
using KSP.Rendering.Planets;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class CelestialBodyStarManager : MonoBehaviour, IUpdate
  {
    private GameInstance Game;
    private PrevisCameraManager PrevisCameraManager;
    private PrevisGameInstance PrevisGame;
    private bool previsScene;
    [SerializeField]
    private LightingSystem LightingSystem;
    private GraphicsManager GraphicsManager;
    private UniverseView UniverseView;
    private IPhysicsSpaceProvider PhysicsSpace;
    private IScaledSpaceProvider ScaledSpace;
    private CelestialBodyProvider CelestialBodyProvider;
    private PrevisCelestialBodyProvider PrevisCelestialBodyProvider;
    private GameStateMachine GameStateMachine;
    private Dictionary<string, LightData> _flightLightingData;
    private bool _isInOAB;
    private bool _isInMenu;
    private OABEnvironmentType _currentOABEnvType;
    private LightingSystem.LayeredLight _oabEnvLight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(LightingSystem lightingSystem, bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABLoaded(OABEnvironmentType oabType, LightingSystem.LayeredLight oabEnvLight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABUnloaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOverlayMenuEntered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOverlayMenuExited() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateSourceLightIntensity(
      string body,
      Position observerPos,
      Position bodyPos,
      double visibility,
      CelestialBodyLightingData data,
      bool isScaled = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color CalculateSourceLightColor(
      string body,
      Position observerPos,
      double visibility,
      CelestialBodyLightingData data,
      bool isScaled = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLensFlare(
      ProFlare flare,
      Position bodyPos,
      Position observerPos,
      CelestialBodyLensFlare data,
      float percentVisible)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Quaternion RotateLightToObserver(
      Position bodyPos,
      Position observerPos,
      bool useScaledProvider = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion RotateLightToOABObserver() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleAllFlightLensFlares(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleStarVisibility(Light light, ProFlare flare, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleLightVisibility(Light light, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleFlareVisibility(ProFlare flare, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyStarManager() => throw null;
  }
}
