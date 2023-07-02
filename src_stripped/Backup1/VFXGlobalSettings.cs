// Decompiled with JetBrains decompiler
// Type: VFXGlobalSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
  [Header("Reentry")]
  [Tooltip("Speed thresholds to start/stop reentry effect")]
  public Vector2 ReentrySpeedThresholds;
  [Tooltip("Base tail length of the reentry effect")]
  public float ReentryTailLength;
  [Tooltip("Light color of interior light for reentry")]
  public Color ReentryLightColor;
  [Tooltip("Max light Intensity for interior light for reentry")]
  public float ReentryMaxLightIntensity;
  [Tooltip("Impact of speed on tail length for reentry")]
  public float ReentrySpeedImpactFactor;
  [Tooltip("Impact of atmosphere height on reentry effect")]
  public float ReentryAtmosphereHeightImpactFactor;
  [Tooltip("Ramp up speed multiplier for reentry")]
  public float ReentryTimeImpactFactor;
  [Tooltip("Ramp down speed multiplier for reentry, effective when threshold is left")]
  public float ReentryCooldownSpeed;
  [Tooltip("Maximum opacity of reentry effect")]
  public float ReentryMaxOpacity;
  [Tooltip("Minimum and maxium brightness for reentry effect")]
  public Vector2 ReentryBrightnessSpectrum;
  [Tooltip("Reentry atmosphere density thresholds, min and max effect values, min represents the value at which any value below would result in the minimum influence")]
  public Vector2 ReentryAtmosphereThresholdCutoffs;
  [Tooltip("Reentry atmosphere minimum density for the effect to begin activating")]
  public float ReentryMinAtmosphereActivationThreshold;
  [Tooltip("Reentry mesh smoothing value, only use very small values")]
  public float ReentrySmoothingVal;
  [Tooltip("Reentry effect ramp up time default")]
  public float ReentryEffectRampDuration;
  [Tooltip("Reentry effect directional offset")]
  public float ReentryVesselDirectionalOffset;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public VFXGlobalSettings() => throw null;
}
