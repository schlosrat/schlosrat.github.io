// Decompiled with JetBrains decompiler
// Type: OceanWaveSpectrum
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

[CreateAssetMenu(fileName = "OceanWaves", menuName = "Ocean/Ocean Wave Spectrum", order = 10000)]
public class OceanWaveSpectrum : ScriptableObject
{
  public const int NUM_OCTAVES = 14;
  public static readonly float SMALLEST_WL_POW_2;
  [HideInInspector]
  public float _windSpeed;
  [HideInInspector]
  public float _fetch;
  public static readonly float MIN_POWER_LOG;
  public static readonly float MAX_POWER_LOG;
  [Tooltip("Variance of wave directions, in degrees")]
  [Range(0.0f, 180f)]
  public float _waveDirectionVariance;
  [Header("Gravity")]
  [Tooltip("Gravity")]
  [Range(0.0f, 100f)]
  public float _gravity;
  [Range(0.0f, 25f)]
  [Tooltip("More gravity means faster waves.")]
  public float _gravityScale;
  [SerializeField]
  [HideInInspector]
  private float[] _powerLog;
  [HideInInspector]
  [SerializeField]
  public bool[] _powerDisabled;
  [HideInInspector]
  public float[] _chopScales;
  [HideInInspector]
  public float[] _gravityScales;
  [HideInInspector]
  public float _smallWavelengthMultiplier;
  [Range(0.0f, 10f)]
  [Tooltip("Multiplier")]
  [SerializeField]
  [HideInInspector]
  private float _multiplier;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static float SmallWavelength(float octaveIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float GetAmplitude(float wavelength, float componentsPerOctave) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float ComputeWaveSpeed(float wavelength, float gravityMultiplier = 1f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void GenerateWaveData(
    int componentsPerOctave,
    ref float[] wavelengths,
    ref float[] anglesDeg,
    ref float[] anglesDeg_variance180)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ApplyPhillipsSpectrum(float windSpeed, float smallWavelengthMultiplier) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ApplyPiersonMoskowitzSpectrum(float windSpeed, float smallWavelengthMultiplier) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ApplyJONSWAPSpectrum(float windSpeed, float fetch, float smallWavelengthMultiplier) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static float PhillipsSpectrum(
    float windSpeed,
    Vector2 windDir,
    float gravity,
    float wavelength,
    float angle)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static float PhilSpectrum(float gravity, float wavelength) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static float PhilSpectrum(float gravity, float alpha, float wavelength) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static float PiersonMoskowitzSpectrum(float gravity, float windspeed, float wavelength) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static float PiersonMoskowitzSpectrum(
    float gravity,
    float windspeed,
    float frequency_peak,
    float alpha,
    float wavelength)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static float JONSWAPSpectrum(
    float gravity,
    float windspeed,
    float wavelength,
    float fetch)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OceanWaveSpectrum() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static OceanWaveSpectrum() => throw null;
}
