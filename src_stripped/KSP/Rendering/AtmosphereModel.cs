// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.AtmosphereModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering
{
  public class AtmosphereModel : ScriptableObject
  {
    private const float kEarthBottomRadius = 6360f;
    private const float kEarthTopRadius = 6420f;
    private const float kBakingAtmosphereHeightScale = 0.1f;
    private const float kEarthRayleighScaleHeight = 8f;
    private const float kEarthMieScaleHeight = 1.2f;
    private const float kSolarIrradianceScale = 2f;
    private const float kSunAngularRadius = 0.04675f;
    private const float kMaxSunZenithAngle = 120f;
    private static Vector3 kRayleighScatteringRaw;
    private static Vector3 kAbsorptionRaw;
    private const float kLambdaR = 680f;
    private const float kLambdaG = 550f;
    private const float kLambdaB = 440f;
    private const int kLambdaMin = 360;
    private const int kLambdaMax = 830;
    public string PlanetName;
    public bool IsGasGiant;
    [Header("Art Direction")]
    public Vector2 Exposure;
    public float SunAngleRadius;
    public float SunZenithAngle;
    public Vector3 SolarIrradiance;
    public float SunDirectionExposureModifier;
    [Header("Skybox Visibility")]
    public Vector4 VisScaleOffset;
    public float VisBlendDistance;
    public float GroundOrbitVisOffset;
    [Header("Depth Fog")]
    public float AerialFogScaleFactor;
    public Vector4 DepthFogScaleHeightOffset;
    public Vector4 DepthFogParams;
    public Vector4 GlobalFogParams;
    [Header("Height Fog")]
    public float HeightFogScaleFactor;
    public Vector2 HeightFogScaleOffset;
    public Vector2 HeightFogParams;
    public Vector3 HeightFogFadingParams;
    [Header("Atmosphere")]
    public float BottomRadius;
    public float AtmosphereHeight;
    [Tooltip("Ground Color Override, specifies the color the ground/atmosphere will change to as you approach the surface")]
    public Color GroundAlbedo;
    [Tooltip("Altitude from the surface at which the gas giant ground color override begins to take effect")]
    public float GasGiantColorOverrideHeight;
    [Header("Rayleigh")]
    public Vector3 RayleighScattering;
    public float RayleighScatteringScale;
    public float RayleighExponentialDistribution;
    [Header("Mie")]
    public Vector3 MieScattering;
    public float MieScatteringScale;
    public Vector3 MieAbsorption;
    public float MieAbsorptionScale;
    public float MieAnisotropy;
    public float MieExponentialDistribution;
    [Header("Absorption")]
    public float AbsorptionScale;
    public Vector3 Absorption;
    public float AbsorptionMaxDensity;
    public Vector2 AbsorptionHeightMinMax;
    [Header("LUTs")]
    public Texture2D TransmittanceTexture;
    public Texture2D IrradianceTexture;
    public Texture3D ScatteringTexture;
    private bool _realtimeMode;
    private RenderTexture _transmittanceRT;
    private RenderTexture _irradianceRT;
    private RenderTexture _scatteringRT;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AtmosphereModel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BindToMaterial(Material mat) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Release() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SkySunRadianceToLuminance(
      out Vector3 skySpectralRadianceToLuminance,
      out Vector3 sunSpectralRadianceToLuminance)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void ComputeSpectralRadianceToLuminanceFactors(
      Vector3 solar_irradiance,
      double lambda_power,
      out double k_r,
      out double k_g,
      out double k_b)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double CieColorMatchingFunctionTableValue(double wavelength, int column) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float InterpolateRGB(Vector3 wavelengths, Vector3 rgb_value, float wavelength) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static AtmosphereModel() => throw null;
  }
}
