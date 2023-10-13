// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.PQSData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Rendering.Planets
{
  [CreateAssetMenu(fileName = "planet", menuName = "Uber/PQSData")]
  public class PQSData : ScriptableObject
  {
    [HideInInspector]
    public static string[] BiomeIndexToTag;
    public PQSData.HeightMapInfo heightMapInfo;
    public PQSData.MaterialSettings materialSettings;
    public PQSData.BiomeData PlanetBiomeData;
    public BiomeLookupHashTable PlanetBiomeHashTable;
    public BiomeTextureColorLookupTable BiomeColorLookupTable;
    [Tooltip("Setting for non-spherical planets, to push the view frustrum of the planet beyond the normal radius")]
    [Range(1f, 2f)]
    public float viewBoundsMultiplier;
    [Tooltip("Setting for non-spherical planets, to push the view plane beyond that of the normal values, handle with care")]
    [Range(0.1f, 3f)]
    public float[] viewPlaneCutoffMultipliers;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PQSData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PQSData() => throw null;

    [Serializable]
    public class HeightRegion
    {
      public Texture2D heightMap;
      [Tooltip("Side Projection scale and offset values")]
      public int uvScale;
      [Tooltip("Height displacement for local height map")]
      public float heightScale;
      [HideInInspector]
      [Tooltip("Subzone filter values for the R/G/B/A channels of the sub-zone mask")]
      public Vector4 subZoneFilter;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector4 GetSubZoneFilter() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public HeightRegion() => throw null;
    }

    public enum FilteringMode
    {
      NoFiltering,
      Biquadratic,
      Bilinear,
    }

    [Serializable]
    public class PoleDecalParameters
    {
      [Tooltip("Radius near the pole to apply procedural smoothing")]
      [Range(0.0f, 3f)]
      public float Radius;
      public float BlendFalloff;
      public float HeightOffset;
      public float NoiseScale;
      public float NoiseFrequency;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PoleDecalParameters() => throw null;
    }

    [Serializable]
    public class PoleHeightSettings
    {
      public PQSData.PoleDecalParameters North;
      public PQSData.PoleDecalParameters South;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public PoleHeightSettings() => throw null;
    }

    [Serializable]
    public class HeightMapInfo
    {
      [Tooltip("HeightMap16 used for entire planet")]
      public Texture2D globalHeightMap;
      [Tooltip("Scale of displacement from height map")]
      public float heightMapScale;
      [Tooltip("Transition distance to change from scaled to local")]
      public float scaledToLocalTransition;
      [Tooltip("Blend Value to transition scaled to local")]
      public float scaledToLocalBlend;
      [Range(0.001f, 10f)]
      [Tooltip("Dithering Scale")]
      public float DitheringScale;
      [Tooltip("Offsets for direction value used for UV calculation")]
      [Header("Pole Distortion Settings")]
      public Vector2 PoleDirectionOffset;
      [Tooltip("Offset for the v parameter to fix distortion near the poles")]
      public float UVOffsetV;
      [Tooltip("Settings for the pole decals to fix pole distortion issues")]
      public PQSData.PoleHeightSettings PoleHeightDecalSettings;
      [Header("Local Heightmaps")]
      [Tooltip("Biome Mask")]
      public Texture2D mask;
      public bool subZonesEnabled;
      public Texture2D subZoneMask;
      public PQSData.HeightRegion largeR;
      public PQSData.HeightRegion largeG;
      public PQSData.HeightRegion largeB;
      public PQSData.HeightRegion largeA;
      public PQSData.HeightRegion mediumR;
      public PQSData.HeightRegion mediumG;
      public PQSData.HeightRegion mediumB;
      public PQSData.HeightRegion mediumA;
      public PQSData.HeightRegion subzone3R;
      public PQSData.HeightRegion subzone4R;
      public PQSData.HeightRegion subzone3G;
      public PQSData.HeightRegion subzone4G;
      public PQSData.HeightRegion subzone3B;
      public PQSData.HeightRegion subzone4B;
      public PQSData.HeightRegion subzone3A;
      public PQSData.HeightRegion subzone4A;
      public float heightMapContrast;
      public PQSData.FilteringMode mediumTextureFilteringMode;
      public PQSData.FilteringMode largeTextureFilteringMode;
      public PQSData.FilteringMode globalTextureFilteringMode;
      public PQSData.FilteringMode decalHeightFilteringMode;
      public PQSData.FilteringMode decalAlphaFilteringMode;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float GetHeightScale() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float GetHeightScaleLargeR() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float GetHeightScaleLargeG() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float GetHeightScaleLargeB() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float GetHeightScaleLargeA() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float GetHeightScaleMediumR() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float GetHeightScaleMediumG() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float GetHeightScaleMediumB() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public float GetHeightScaleMediumA() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public HeightMapInfo() => throw null;
    }

    [Serializable]
    public class MaterialSettings
    {
      public Material surfaceMaterial;
      public Material scaledSpaceMaterial;
      public Shader VSPQueryShader;
      public bool meshCastShadows;
      public bool meshRecieveShadows;
      public float worldSpaceTile;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public MaterialSettings() => throw null;
    }

    public enum KSP2BiomeType
    {
      NONE,
      DIRT,
      DUST,
      GRASS,
      GRASS_DRIED,
      ICE,
      MARSH,
      METAL,
      ROCK,
      SAND,
      SNOW,
      WET,
      CONCRETE,
      OCEAN,
      LAVA,
      METAL_PLANET,
      GAS_GIANT,
    }

    [Serializable]
    public class BiomeMappingData
    {
      public int TextureIndex;
      public PQSData.KSP2BiomeType BiomeType;
      public int BiomeColorIndex;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Copy(PQSData.BiomeMappingData other) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BiomeMappingData(PQSData.KSP2BiomeType type, int colorIndex) => throw null;
    }

    [Serializable]
    public struct BiomeSurfaceData
    {
      public PQSData.KSP2BiomeType type;
      public Color color;
    }

    [Serializable]
    public class BiomeData
    {
      public PQSData.BiomeMappingData[] Red;
      public PQSData.BiomeMappingData[] Green;
      public PQSData.BiomeMappingData[] Blue;
      public PQSData.BiomeMappingData[] Alpha;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BiomeData() => throw null;
    }
  }
}
