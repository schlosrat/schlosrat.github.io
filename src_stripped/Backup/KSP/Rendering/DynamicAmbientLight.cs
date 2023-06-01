// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.DynamicAmbientLight
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class DynamicAmbientLight : MonoBehaviour
  {
    [Header("Galaxy Skybox")]
    public Material skyboxGalaxy;
    [Header("VAB Skybox")]
    public Material skyboxVab;
    [Header("VAB Ambient")]
    public Color fogColorVAB;
    public FogMode fogModeVAB;
    public float fogDensityVAB;
    [Header("Colonial VAB Ambient")]
    public Material skyboxColonialVAB;
    public Color fogColorColonialVAB;
    public FogMode fogModeColonialVAB;
    public float fogDensityColonialVAB;
    [Header("Galaxy Ambient")]
    public Color ambientColorGalaxy;
    [Range(0.0f, 8f)]
    public float flightAmbientIntensity;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(bool usePrevis = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnOABUnloaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnvironmentLightingProfile(EnvironmentLightingProfile profile) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EnvironmentLightingProfile GetEnvironmentLightingProfile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DynamicAmbientLight() => throw null;
  }
}
