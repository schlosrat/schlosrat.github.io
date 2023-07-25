// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ISurfaceProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Rendering.Planets;
using UnityEngine;

namespace KSP.Sim.impl
{
  public interface ISurfaceProvider
  {
    Vector3d GetRelSurfaceNVector(double lat, double lon);

    Vector3d GetSurfaceNVector(double lat, double lon);

    Vector3d GetRelTerrainPosition(double latitude, double longitude, double altitudeFromTerrain);

    void GetLatLonAltFromRadius(
      Vector3d physicsSpacePosition,
      out double lat,
      out double lon,
      out double radiusAlt);

    double GetTerrainAltitudeFromCenter(double lat, double lon);

    void GetAltitudeFromTerrain(
      Position position,
      out double terrainAltitude,
      out double terrainToSceneryOffset);

    PQSData.KSP2BiomeType GetBiomeTypeAtPosition(Position position);

    PQSData.KSP2BiomeType GetBiomeTypeAtPosition(Vector3 position);

    PQSData.BiomeSurfaceData GetBiomeDataAtPosition(Position position);

    PQSData.BiomeSurfaceData GetBiomeDataAtPosition(Vector3 position);

    void SetTerrainPhysicsAtCachedPosition(PQSData.KSP2BiomeType biomeType);

    bool TryGetSurfaceObjectPosition(string name, out Position position, out Rotation rotation);
  }
}
