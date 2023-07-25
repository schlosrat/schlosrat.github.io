// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyGIProbeManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering.Planets;
using KSP.Sim;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering
{
  public class CelestialBodyGIProbeManager : MonoBehaviour, IUpdate
  {
    private GameInstance Game;
    private PrevisGameInstance PrevisGame;
    [SerializeField]
    private bool previsScene;
    public LightingSystem LightingSystem;
    public LightProbeGroup lightProbeGroup;
    private GraphicsManager GraphicsManager;
    private UniverseView UniverseView;
    private PrevisCameraManager PrevisCameraManager;
    private IPhysicsSpaceProvider PhysicsSpace;
    public CelestialBodyProvider CelestialBodyProvider;
    private PrevisCelestialBodyProvider PrevisCelestialBodyProvider;
    private GameStateMachine GameStateMachine;
    private GraphicsSettings GraphicsSettings;
    public Dictionary<string, double> visibleBodies;
    public Dictionary<string, LightData> localBodies;
    private bool _isInOAB;
    [ColorUsage(true, true)]
    [SerializeField]
    private Color _ambientGalaxy;
    [ColorUsage(true, true)]
    [SerializeField]
    private Color _ambientVAB;
    [ColorUsage(true, true)]
    [SerializeField]
    private Color _ambientColonyVAB;
    public Color currentAmbientColor;
    public Color debugAmbientColor;
    public bool useDebugAmbient;
    public bool enableObserverGI;
    public bool enableCelestialBodyGI;
    public bool enableGlobalIllumination;
    private bool _currentBodyHasRings;
    private CelestialBodyRingGroup _currentBodyRingGroup;
    private CelestialBodyGIProbeData _observerProbe;
    private CelestialBodyGIProbeData _oabSH;
    private CelestialBodyGIProbeData _mapSH;
    private static int[] SHA;
    private static int[] SHB;
    private static int SHC;
    public int debugSelectionIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(LightingSystem lightingSystem, bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckGraphicsSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearGIProbe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABUnloaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSettingChanged(Setting setting) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnSOIEntered(CelestialBodyRingGroup ringGroup) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void IUpdate.OnUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateObserverGI(Dictionary<string, double> visibleBodies, Position observerPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCelestialBodyGI(
      Dictionary<string, double> visibleBodies,
      Position observerPos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddAmbientGI(
      ref SphericalHarmonicsL2 sh,
      string ambientBody,
      Position observerPos,
      bool isCelestialBodyGI = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddRingGI(ref CelestialBodyGIProbeData probeData, Position observerPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddObserverDirectionalGI(
      ref CelestialBodyGIProbeData probeData,
      Dictionary<string, double> visibleBodies,
      Position observerPos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddCelestialDirectionalGI(
      ref CelestialBodyGIProbeData sh,
      Dictionary<string, OverrideLightingData> visibleBodies,
      string observerBody,
      Position observerPos)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateGIIntensityObserver(
      string body,
      Position observerPos,
      Position sourcePos,
      double visibility,
      CelestialBodyLightingData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color CalculateGIColorObserver(
      string body,
      Position observerPos,
      double visibility,
      CelestialBodyLightingData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyGIProbeManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CelestialBodyGIProbeManager() => throw null;
  }
}
