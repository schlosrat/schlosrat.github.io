// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyMapLighting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Map;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class CelestialBodyMapLighting : MonoBehaviour, ILateUpdate
  {
    private GameInstance Game;
    private PrevisGameInstance PrevisGame;
    private bool previsScene;
    public LightingSystem LightingSystem;
    private GraphicsManager GraphicsManager;
    private MapProvider MapProvider;
    private Dictionary<string, LightData> _mapBodyToLightData;
    private MapCore mapCore;
    private bool inMap;
    private static readonly int MAPDIST_ID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Light GetCurrentLight() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveEvents() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapInitialized() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapEntered() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnMapExited() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    void ILateUpdate.OnLateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateMapSourceLights(LightData bodyMapData, Map3DFocusItem bodyMapItem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Quaternion RotateLight(Vector3d lightDir) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateIntensity(
      double invMapScale,
      double distanceBodyCamera,
      CelestialBodyLightingData data)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLensFlare(LightData mapData, double invMapScale, double distanceBodyCamera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyMapLighting() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static CelestialBodyMapLighting() => throw null;
  }
}
