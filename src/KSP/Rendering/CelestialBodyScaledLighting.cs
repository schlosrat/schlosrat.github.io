// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyScaledLighting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class CelestialBodyScaledLighting : KerbalMonoBehaviour
  {
    public LightingSystem _lightingSystem;
    private GraphicsManager graphicsManager;
    private Dictionary<string, LightData> scaledBodies;
    private int body1ColorID;
    private int body1IntensityID;
    private int body1DirectionID;
    private int body2ColorID;
    private int body2IntensityID;
    private int body2DirectionID;
    private const int maxGILights = 2;

    private IScaledSpaceProvider ScaledSpace
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
    private void UpdateSourceLights(string bodyName, LightData bodyScaledData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Quaternion RotateLightToObserver(Position bodyPos, Position observerPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateScaledGI(string bodyName, LightData bodyScaledData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetScaledObjPosition(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float CalculateIntensity(float distance, CelestialBodyLightingData data) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyScaledLighting() => throw null;
  }
}
