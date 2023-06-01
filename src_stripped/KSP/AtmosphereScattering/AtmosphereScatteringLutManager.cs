// Decompiled with JetBrains decompiler
// Type: KSP.AtmosphereScattering.AtmosphereScatteringLutManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.AtmosphereScattering
{
  [ExecuteInEditMode]
  public class AtmosphereScatteringLutManager : MonoBehaviour, ProgressiveLutUpdater.ITimeLogger
  {
    private static AtmosphereScatteringLutManager _instance;
    public bool progressiveUpdate;
    [SerializeField]
    private ComputeShader computeShader;
    [SerializeField]
    private bool outputDebug;
    public AtmLutGenerateConfig lutConfig;
    public AtmosphereConfig atmosphereConfig;
    [NonSerialized]
    public Material skyboxMaterial;
    private ProgressiveLutUpdater[] pingPongUpdaters;
    private float lerpValue;

    public static AtmosphereScatteringLutManager instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ProgressiveLutUpdater newestLut
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ProgressiveLutUpdater oldLut
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RotatePingpongUpdater() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void KickOffUpdater(ProgressiveLutUpdater updater) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateLerpValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateComputeShaderValueForLerpedAp(ComputeShader shader, int kernelId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSkyboxMaterial(
      ProgressiveLutUpdater updater,
      ProgressiveLutUpdater oldUpdater)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Log(string itemName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetRadianceAt(float mu_s, Vector3 basePosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AtmosphereScatteringLutManager() => throw null;
  }
}
