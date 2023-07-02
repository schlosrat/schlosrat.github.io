// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.CelestialBodyLightingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
    [Range(-0.25f, 0.25f)]
    [Header("Time of Day")]
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
    [Header("Directional")]
    [FormerlySerializedAs("innerAltitude")]
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
