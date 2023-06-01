// Decompiled with JetBrains decompiler
// Type: KSP.VFX.FXContextData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.VFX
{
  [Serializable]
  public class FXContextData
  {
    public float AtmosphereDensity;
    public float AtmosphereTemperature;
    public float AtmosphereHumidityPercentage;
    public float AtmosphereDepth;
    public float Gravity;
    public PQSData.KSP2BiomeType Biome;
    public Color BiomeColor;
    public string CelestialBody;
    public float MachNumber;
    public float CameraDistance;
    public Vector3 CameraViewDirection;
    public bool ForceUseSituation;
    public Color EffectTintColor;
    public float TotalExplosionPotential;
    public VFXSituation Situation;
    public float VesselThrustMagnitude;
    public float VesselDistanceFromSpawn;
    public float VesselThrottleSetting;
    public float VesselNormalizedThrust;
    public float VesselNormalizedThrustDistance;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FXContextData() => throw null;
  }
}
