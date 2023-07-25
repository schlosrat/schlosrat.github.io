// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyLightingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Rendering
{
  [Serializable]
  public class CelestialBodyLightingData
  {
    [Header("Time of Day")]
    [Range(-0.25f, 0.25f)]
    public float horizonOffset;
    [Range(0.01f, 1f)]
    public float dayBlendRange;
    [Range(0.01f, 1f)]
    public float nightBlendRange;
    [SerializeField]
    public float dotProduct;
    [Header("Ambient")]
    public bool useAmbient;
    public double ambientInnerAltitude;
    public double ambientOuterAltitude;
    public Color ambientDay;
    public Color ambientNight;
    public Color ambientScaled;
    [FormerlySerializedAs("innerAltitude")]
    [Header("Directional")]
    public double directionalInnerAltitude;
    [FormerlySerializedAs("outerAltitude")]
    public double directionalOuterAltitude;
    [NonReorderable]
    public List<OverrideLightingData> lightingOverrides;
    public Dictionary<string, OverrideLightingData> lightingOverridesDict;
    [Header("Bounce Light")]
    public bool enabled;
    public SphericalGaussianSettings sphericalGaussianSettings;
    [ColorUsage(true, true)]
    public Color color;
    public float intensityAtPeriapsis;
    public float intensityAtApoapsis;
    public double lightFalloffDistance;
    public AnimationCurve lightFalloffCurve;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyLightingData() => throw null;
  }
}
