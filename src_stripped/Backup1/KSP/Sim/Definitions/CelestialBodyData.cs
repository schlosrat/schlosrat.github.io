// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.CelestialBodyData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Sim.Definitions
{
  [Serializable]
  public class CelestialBodyData
  {
    [Header("Meta data")]
    public string bodyName;
    public string assetKeyScaled;
    public string assetKeySimulation;
    [Header("Decoration")]
    public string bodyDisplayName;
    public string bodyDescription;
    [Header("Descriptors")]
    public bool isStar;
    public bool isHomeWorld;
    [Tooltip("The altitude (Above Sea Level) when the navball will auto switch to Orbit Mode when the altitude gets above this")]
    public double navballSwitchAltitudeHigh;
    [Tooltip("The altitude Above Sea Level when the navball will auto switch to Surface Mode when the altitude gets below this")]
    public double navballSwitchAltitudeLow;
    [Header("Properties - General")]
    public bool hasSolidSurface;
    public bool hasOcean;
    public bool HasLocalSpace;
    public double radius;
    public double gravityASL;
    public double oceanAltitude;
    public double oceanDensity;
    public double MinTerrainHeight;
    public double MaxTerrainHeight;
    public double TerrainHeightScale;
    [Tooltip("The offset above Atmo/TerrainHeight when we can engage time warp higher than 4x")]
    public double TimeWarpAltitudeOffset;
    public int SphereOfInfluenceCalculationType;
    [Header("Properties - Movement")]
    public bool hasSolarRotationPeriod;
    public bool hasInverseRotationThresholdClamp;
    public bool hasInverseRotation;
    public bool isRotating;
    public bool isTidallyLocked;
    public double inverseRotThresholdAltitude;
    public double initialRotation;
    public double rotationPeriod;
    public Vector3d axialTilt;
    [Header("Properties - Atmosphere")]
    public bool hasAtmosphere;
    public bool atmosphereContainsOxygen;
    public double atmosphereDepth;
    public double atmosphereTemperatureSeaLevel;
    public double atmospherePressureSeaLevel;
    public double atmosphereMolarMass;
    public double atmosphereAdiabaticIndex;
    public bool useAtmospherePressureCurve;
    public bool useAtmosphereTemperatureCurve;
    public bool useAtmosphereHumidityCurve;
    public FloatCurve atmospherePressureCurve;
    [FormerlySerializedAs("atmosphereTemperatureCurve")]
    public FloatCurve BodyAltitudeTemperatureCurve;
    [FormerlySerializedAs("surfaceTemperatureFluxCurve")]
    public FloatCurve BodyAltitudeSurfaceFluxCurve;
    [FormerlySerializedAs("altitudeTemperatureFluxCurve")]
    public FloatCurve BodyAltitudeFluxCurve;
    public FloatCurve BodyAltitudeRelativeHumidityCurve;
    [Header("Properties - Thermals")]
    public string BodySurfaceFluxMapPath;
    public double BodySurfaceFluxScale;
    [Header("Properties - Star")]
    public double StarLuminosity;
    [Header("Properties - Rings")]
    [SerializeField]
    [NonReorderable]
    public List<CelestialBodyRingData> ringGroupData;
    [Header("Local SimObjects")]
    [HideInInspector]
    [SerializeField]
    public List<SerializedPredefinedSimObject> LocalSimObjectsData;
    [JsonIgnore]
    public List<PredefinedSimObject> LocalSimObjects;
    [SerializeField]
    [HideInInspector]
    public List<SerializedPredefinedColonyObject> LocalColonyObjectsData;
    [JsonIgnore]
    public List<PredefinedColonyObject> LocalColonyObjects;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void SerializeScriptableObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CelestialBodyData FromCelestialBodyProperties(CelestialBodyProperties old) => throw null;

    [Obsolete("2021-01-10: This is a translation function, and should not be used except where ABSOLUTELY necessary.")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyProperties ToOldBodyProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyData() => throw null;
  }
}
