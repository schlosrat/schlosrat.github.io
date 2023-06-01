// Decompiled with JetBrains decompiler
// Type: BuildingLightsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering;
using KSP.Sim.impl;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BuildingLightsManager : UniverseCameraManager
{
  [SerializeField]
  private List<Light> _lights;
  [SerializeField]
  private int _maxDistance;
  private List<float> _maxIntensities;
  [SerializeField]
  private Renderer _emissiveWindows;
  private float _windowStartValue;
  private Material _cachedWindowMaterial;
  private TimeOfDayManager _TODManager;
  private Transform _camera;
  private bool _lightsEnabled;
  private bool _initialized;
  private const string _materialAlpha = "_AlphaMax";

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleLights(bool value) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ToggleWindows(bool _on) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public BuildingLightsManager() => throw null;
}
