// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.CelestialBodyProperties
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Converters;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Definitions
{
  [Obsolete("(2020-12-10) Migrate to Celestial Body Data. This will be reduced then removed in 2021. If that class doesn't have the data you need, add it or ask an engineer where else to put it.")]
  public struct CelestialBodyProperties
  {
    private const string ASSET_PREFIX = "celestial";
    private const string ASSET_SUFFIX_SCALED = "scaled";
    private const string ASSET_SUFFIX_SIMULATION = "simulation";
    private const string ASSET_SEPARATOR = ".";
    public string assetKeySimulation;
    public string assetKeyScaled;
    public string bodyName;
    public string bodyDisplayName;
    public string bodyDescription;
    public double gravityASL;
    public double radius;
    public bool isHomeWorld;
    public double oceanAltitude;
    public double oceanDensity;
    public double MinTerrainHeight;
    public double MaxTerrainHeight;
    public double TerrainHeightScale;
    public double TimeWarpAltitudeOffset;
    public int SphereOfInfluenceCalculationType;
    public double navballSwitchAltitudeHigh;
    public double navballSwitchAltitudeLow;
    public bool hasOcean;
    public bool HasLocalSpace;
    public bool oceanUseFog;
    public double oceanFogPQSDepth;
    public float oceanFogPQSDepthRecip;
    public float oceanFogDensityStart;
    public float oceanFogDensityEnd;
    public float oceanFogDensityPQSMult;
    public float oceanFogDensityAltScalar;
    public float oceanFogDensityExponent;
    public Color oceanFogColorStart;
    public Color oceanFogColorEnd;
    public float oceanFogDawnFactor;
    public float oceanSkyColorMult;
    public float oceanSkyColorOpacityBase;
    public float oceanSkyColorOpacityAltMult;
    public float oceanAFGBase;
    public float oceanAFGAltMult;
    public float oceanAFGMin;
    public float oceanSunBase;
    public float oceanSunAltMult;
    public float oceanSunMin;
    public bool oceanAFGLerp;
    public float oceanMinAlphaFogDistance;
    public float oceanMaxAlbedoFog;
    public float oceanMaxAlphaFog;
    public float oceanAlbedoDistanceScalar;
    public float oceanAlphaDistanceScalar;
    public double minOrbitalDistance;
    public bool hasAtmosphere;
    public bool atmosphereContainsOxygen;
    public double atmosphereDepth;
    public double atmosphereTemperatureSeaLevel;
    public double atmospherePressureSeaLevel;
    public double atmosphereMolarMass;
    public double atmosphereAdiabaticIndex;
    public double atmosphereTemperatureLapseRate;
    public double atmosphereGasMassLapseRate;
    public bool useAtmosphereTemperatureCurve;
    public bool isAtmosphereTemperatureCurveNormalized;
    public bool useAtmosphereHumidityCurve;
    public FloatCurve BodyAltitudeTemperatureCurve;
    public FloatCurve BodyAltitudeSurfaceFluxCurve;
    public FloatCurve BodyAltitudeFluxCurve;
    public FloatCurve BodyAltitudeRelativeHumidityCurve;
    public double BodySurfaceFluxScale;
    public string BodySurfaceFluxMapPath;
    public double StarLuminosity;
    public double albedo;
    public double emissivity;
    public double coreTemperatureOffset;
    public double convectionMultiplier;
    public double shockTemperatureMultiplier;
    public bool useAtmospherePressureCurve;
    public bool isAtmospherePressureCurveNormalized;
    public FloatCurve atmospherePressureCurve;
    public bool hasSolidSurface;
    public List<CelestialBodyRingData> ringGroupData;
    public Vector3d scaledElipRadMult;
    public double scaledRadiusHorizMultiplier;
    public bool rotates;
    public double rotationPeriod;
    public bool hasSolarRotationPeriod;
    public double initialRotation;
    public QuaternionD axialTilt;
    public bool isTidallyLocked;
    public bool clampInverseRotThreshold;
    public bool hasInverseRotation;
    public float inverseRotThresholdAltitude;
    public float scaledShaderFadeFar;
    public float scaledShaderFadeNear;
    [TypeConverterIgnore]
    public CelestialBodyProperties.ScienceParams scienceValues;
    [TypeConverterIgnore]
    public bool IsStar;
    [TypeConverterIgnore]
    public string sunlightPrefab;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Defaults(out CelestialBodyProperties definition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FromCelestialBodyComponent(
      CelestialBodyComponent celestialBody,
      out CelestialBodyProperties definition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetScaledSpaceAssetKeyFromBody(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string GetSimulationSpaceAssetKeyFromBody(string name) => throw null;

    public struct ScienceParams
    {
      public float landedDataValue;
      public float splashedDataValue;
      public float flyingLowDataValue;
      public float flyingHighDataValue;
      public float inSpaceLowDataValue;
      public float inSpaceHighDataValue;
      public float recoveryValue;
      public float flyingAltitudeThreshold;
      public float spaceAltitudeThreshold;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void Defaults(
        out CelestialBodyProperties.ScienceParams definition)
      {
        throw null;
      }
    }
  }
}
