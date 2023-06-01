// Decompiled with JetBrains decompiler
// Type: VFXGlobalSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.VFX;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "VFXGlobalSettings", menuName = "ScriptableObjects/VFXGlobalSettings")]
[Serializable]
public class VFXGlobalSettings : ScriptableObject
{
  [Tooltip("VFX settings for high quality")]
  public VFXQualitySetting HighQualitySettings;
  [Tooltip("VFX settings for Medium quality")]
  public VFXQualitySetting MedQualitySettings;
  [Tooltip("VFX settings for Low quality")]
  public VFXQualitySetting LowQualitySettings;
  [Tooltip("Default fuel type for parts that do not have a fuel resource")]
  public string DefaultVFXFuelType;
  [Tooltip("Amount of time to allow a contextual event particle system to fade out after stopping, before the object is destroyed")]
  public float DefaultParticleSystemLingerTime;
  [Tooltip("Atmospheric pressure below which is considered a vacuum")]
  public float VacuumThresholdDensity;
  [Tooltip("Value to normalize the VesselNormalizedThrust parameter against (kilonewtons of thrust forces on vessel)")]
  public float MaxThrustForceForNormalizedParameterkN;
  [Tooltip("Value to normalize the VesselNormalizedThrustDistance parameter against (Meters from spawnpoint where value should be 0")]
  public float MaxThrustForceDistanceForNormalizedParameterM;
  [Tooltip("Distance that a ground blast effect can be produced from the thrust transform of an engine")]
  public float GroundBlastRaycastLength;
  [Tooltip("Humidity percentage threshold a planet needs to have for vapor FX to occur")]
  public float VaporHumidityThresholdPercentage;
  [Tooltip("In Kelvin. Contrails tend to form in the cold temperature below −36.5 °C (−34 °F)")]
  public float VaporContrailsTemperatureThreshold;
  [Tooltip("How far below the local dewpoint we need to be to spawn vapor vortices, K")]
  public float VaporVorticesTemperatureThreshold;
  [Tooltip("How far below the local dewpoint we need to be before vortices will appear at full alpha, K")]
  public float VaporVorticesTemperatureMax;
  [Tooltip("Maximum dynamic pressure in kPa")]
  public float VaporVorticesDynamicPressureClamp;
  [Tooltip("Maximum dynamic pressure in kPa")]
  public float VaporVorticesDynamicPressureMaxIntensity;
  [Tooltip("Gamma factor for determining temperature drop in a vapor vortex. Higher values drop the temperature more")]
  public float VaporVorticesGammaParameter;
  [Tooltip("Mixture definitions in engines that will trigger vapor contrails ")]
  public List<string> ContrailsMixtures;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public VFXGlobalSettings() => throw null;
}
