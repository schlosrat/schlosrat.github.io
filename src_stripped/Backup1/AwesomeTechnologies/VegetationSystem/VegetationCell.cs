// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationCell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Utility.Quadtree;
using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem.Biomes;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class VegetationCell : IHasRect
  {
    public Bounds VegetationCellBounds;
    public readonly List<VegetationPackageInstances> VegetationPackageInstancesList;
    public readonly List<VegetationInstanceData> VegetationInstanceDataList;
    public VegetationCellType VegetationCellType;
    public bool Loaded;
    public bool Prepared;
    public int Index;
    public int xIndex;
    public int yIndex;
    public List<PolygonBiomeMask> BiomeMaskList;
    public List<BaseMaskArea> VegetationMaskList;
    public bool FlagForRemoval;
    public bool HasBiomeData;
    public Color32 BiomeData;
    private float _lastRadius;
    private Vector3 _lastPolarSpherePosition;
    private BoundingSphere _polarBoundingSphereCached;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsFullySpawned() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasBiome(int biomeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasBiome(Vector4 selectedChannels) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationCell(Rect rectangle) => throw null;

    public Rect Rectangle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundingSphere GetBoundingSphere() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundingSphere GetPolarBoundingSphere(float radius, Vector3 polarSpherePosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearInstanceMemory() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearCache(int vegetationPackageIndex, int vegetationItemIndex) => throw null;

    public bool Enabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int EnabledInt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddBiomeMask(PolygonBiomeMask maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationMask(BaseMaskArea maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationMask(
      BaseMaskArea maskArea,
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVegetationMaskDelete(BaseMaskArea maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SortBiomeList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBiomeMaskDelete(PolygonBiomeMask maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateInstanceListFromGPU(
      NativeArray<ScatterInstance> scatterInstanceNativeArray,
      int vegetationPackageIndex,
      int vegetationItemIndex)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasBiome(BiomeType biomeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void DrawPolarVegetationCellGizmo(
      VegetationCell vegetationCell,
      float sphereRadius,
      Vector3 spherePosition)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float2 ClampPosition(float2 position) => throw null;
  }
}
