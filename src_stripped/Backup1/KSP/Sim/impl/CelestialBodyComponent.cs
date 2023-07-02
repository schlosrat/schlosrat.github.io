// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.CelestialBodyComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api;
using KSP.Game;
using KSP.Rendering.Planets;
using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using KSP.Sim.State;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class CelestialBodyComponent : 
    ObjectComponent,
    IRigidbodyDriver,
    IPositionDriver,
    IRotationDriver,
    ILinearMotionDriver,
    IAngularMotionDriver
  {
    [TypeConverterIgnore]
    private CelestialDataProvider _celestialDataProvider;
    public List<CelestialBodyRingData> ringGroupData;
    public double RotationOffset;
    public double solarDayLength;
    public double rotationAngle;
    public Vector3d AngularVelocityYup;
    public Vector3d zUpAngularVelocity;
    public double angularV;
    public CelestialFrame BodyFrame;
    [TypeConverterIgnore]
    private List<CelestialBodyComponent> _orbitingBodies;

    [TypeConverterIgnore]
    public CelestialBodyState State
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override System.Type ViewObjectComponentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public new string Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string assetKeySimulation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string assetKeyScaled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public CelestialDataProvider API
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string bodyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string bodyDisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string bodyDescription
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double gravityASL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double radius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double MinTerrainHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double MaxTerrainHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double TimeWarpAltitudeOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int SphereOfInfluenceCalculationType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool HasLocalSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double TerrainHeightScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool isHomeWorld
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double navballSwitchAltitudeHigh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double navballSwitchAltitudeLow
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool hasOcean
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double oceanAltitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool oceanUseFog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double oceanFogPQSDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanFogPQSDepthRecip
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanFogDensityStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanFogDensityEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanFogDensityPQSMult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanFogDensityAltScalar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanFogDensityExponent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Color oceanFogColorStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Color oceanFogColorEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanFogDawnFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanSkyColorMult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanSkyColorOpacityBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanSkyColorOpacityAltMult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double oceanDensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanAFGBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanAFGAltMult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanAFGMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanSunBase
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanSunAltMult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanSunMin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool oceanAFGLerp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanMinAlphaFogDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanMaxAlbedoFog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanMaxAlphaFog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanAlbedoDistanceScalar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float oceanAlphaDistanceScalar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double minOrbitalDistance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool hasAtmosphere
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public QuaternionD axialTilt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool atmosphereContainsOxygen
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double atmosphereDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double atmosphereTemperatureSeaLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double atmospherePressureSeaLevel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double atmosphereMolarMass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double atmosphereAdiabaticIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double atmosphereTemperatureLapseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double atmosphereGasMassLapseRate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool useAtmosphereTemperatureCurve
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool isAtmosphereTemperatureCurveNormalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FloatCurve BodyAltitudeTemperatureCurve
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool useAtmosphereHumidityCurve
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FloatCurve BodyAltitudeRelativeHumidityCurve
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FloatCurve BodyAltitudeSurfaceFluxCurve
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FloatCurve BodyAltitudeFluxCurve
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string BodySurfaceFluxMapPath
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double BodySurfaceFluxScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double StarLuminosity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double albedo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double emissivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double coreTemperatureOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double convectionMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double shockTemperatureMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool useAtmospherePressureCurve
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool isAtmospherePressureCurveNormalized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public FloatCurve atmospherePressureCurve
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool hasSolidSurface
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Vector3d scaledElipRadMult
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double scaledRadiusHorizMultiplier
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool rotates
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double rotationPeriod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool hasSolarRotationPeriod
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public double initialRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool isTidallyLocked
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool clampInverseRotThreshold
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public bool hasInverseRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float inverseRotThresholdAltitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public string sunlightPrefab
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool IsStar
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double Mass
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double gravParameter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double gMagnitudeAtCenter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double sphereOfInfluence
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double hillSphere
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double rotPeriodRecip
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double directRotAngle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double radiusAtmosphereFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double atmosphereDensityASL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double density
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double surfaceArea
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public double maxAxialDot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public List<CelestialBodyComponent> orbitingBodies
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public IUniverseModel universeModel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public CelestialBodyComponent referenceBody
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public OrbiterComponent Orbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public PatchedConicsOrbit Orbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public ISurfaceProvider SurfaceProvider
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddChild(CelestialBodyComponent childBody) => throw null;

    [TypeConverterIgnore]
    public IMotionFrame bodyMotionFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public IMotionFrame celestialMotionFrame
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public ICoordinateSystem coordinateSystem
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public QuaternionD localRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public Vector3d localPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public IMotion relativeToMotion
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public Vector relativeAngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public Vector relativeVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public Rotation Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public bool CanAcceptRotationUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateRotation(Rotation newRotation) => throw null;

    public event Action<Rotation> RotationUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [TypeConverterIgnore]
    public Position Position
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdatePosition(Position newPosition) => throw null;

    public event Action<Position> PositionUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [TypeConverterIgnore]
    public AngularVelocity AngularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateAngularVelocity(AngularVelocity newAngularVelocity) => throw null;

    public event Action<AngularVelocity> AngularVelocityUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [TypeConverterIgnore]
    public Velocity Velocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateVelocity(Velocity newVelocity) => throw null;

    public event Action<Velocity> VelocityUpdated
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent(CelestialBodyDefinition definition, IUniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetDefinition(object definitionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object state, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RevealSpeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double RevealAltitude() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float RevealMass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAdded(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OrbitalStateUpdated(IKeplerOrbit orbit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static double CalculateSphereOfInfluence(
      CelestialBodyComponent cb,
      KSP.Sim.Definitions.SphereOfInfluenceCalculationType calculationType)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupConstants() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFixedUpdate(double universalTime, double universalTimeDelta) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CelestialBodyOrderedUpdate(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetFrameVelZup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetFrameVelAtUTZup(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetTruePositionAtUT(double UT, ICoordinateSystem coordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position GetTruePositionAtUT(double UT) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetTruePositionAtT(double T, ICoordinateSystem coordinateSystem) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Position GetTruePositionAtT(double T) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelSurfaceNVector(double lat, double lon) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetSurfaceNVector(double lat, double lon) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelSurfacePosition(double lat, double lon, double altFromRadius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelSurfacePosition(
      double lat,
      double lon,
      double radiusAlt,
      out Vector3d normal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetLatLonAltFromRadius(
      Position pos,
      out double lat,
      out double lon,
      out double altFromRadius)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetLatLonAltFromRadius(
      ICoordinateSystem coordinateSystem,
      Vector3d localPosition,
      out double lat,
      out double lon,
      out double altFromRadius)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAltitudeFromRadius(
      Vector3d position,
      ICoordinateSystem positionCoordinateSystem)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetAltitudeFromRadius(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelSurfacePosition(
      ICoordinateSystem coordinateSystem,
      Vector3d localPosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetRelSurfaceDirection(Vector3d worldDirection) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3d GetWorldSurfacePosition(
      double lat,
      double lon,
      double altFromRadius,
      ICoordinateSystem coordinateSystem)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetPressure(double altitudeFromSeaLevel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetTemperature(double altitude) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetAltitudeFromTerrain(
      Position position,
      out double terrainAltitude,
      out double sceneryOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.KSP2BiomeType GetBiomeTypeAtPosition(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.KSP2BiomeType GetBiomeTypeAtPosition(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.BiomeSurfaceData GetBiomeDataAtPosition(Position position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData.BiomeSurfaceData GetBiomeDataAtPosition(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTerrainPhysicsAtCachedPosition(PQSData.KSP2BiomeType biomeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSolarPowerFactor(double density) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetSolarAtmosphericEffects(
      double sunDot,
      double density,
      out double solarAirMass,
      out double solarFluxMultiplier)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDensity(double pressure, double temperature) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDensityRecip() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDynamicPressurekPa(
      double pressure,
      double temperature,
      ITransformFrame bodyReferenceFrame,
      ITransformModel targetTransform)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetRelativeHumidityPercentage(double altitude) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasParent(CelestialBodyComponent body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasChild(CelestialBodyComponent body) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent GetRelevantStar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateGeosyncDistFromCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double CalculateGeosyncAltitudeFromRadius() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryGetSurfaceObjectPosition(
      string surfaceObjectName,
      out Position position,
      out Rotation rotation)
    {
      throw null;
    }
  }
}
