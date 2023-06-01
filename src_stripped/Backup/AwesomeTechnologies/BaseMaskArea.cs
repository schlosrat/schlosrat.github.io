// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.BaseMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.Vegetation;
using AwesomeTechnologies.VegetationSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Jobs;
using UnityEngine;

namespace AwesomeTechnologies
{
  public class BaseMaskArea
  {
    public Bounds MaskBounds;
    public bool RemoveGrass;
    public bool RemovePlants;
    public bool RemoveTrees;
    public bool RemoveObjects;
    public bool RemoveLargeObjects;
    public float AdditionalGrassWidth;
    public float AdditionalPlantWidth;
    public float AdditionalTreeWidth;
    public float AdditionalObjectWidth;
    public float AdditionalLargeObjectWidth;
    public float AdditionalGrassWidthMax;
    public float AdditionalPlantWidthMax;
    public float AdditionalTreeWidthMax;
    public float AdditionalObjectWidthMax;
    public float AdditionalLargeObjectWidthMax;
    public float NoiseScaleGrass;
    public float NoiseScalePlant;
    public float NoiseScaleTree;
    public float NoiseScaleObject;
    public float NoiseScaleLargeObject;
    public string VegetationItemID;
    public List<VegetationTypeSettings> VegetationTypeList;
    public BaseMaskArea.MultionMaskDeleteDelegate OnMaskDeleteDelegate;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual JobHandle SampleMask(
      VegetationInstanceData instanceData,
      VegetationType vegetationType,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual JobHandle SampleIncludeVegetationMask(
      VegetationInstanceData instanceData,
      VegetationTypeIndex vegetationTypeIndex,
      JobHandle dependsOn)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool HasVegetationTypeIndex(VegetationTypeIndex vegetationTypeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetAdditionalWidth(VegetationType vegetationType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationTypeSettings GetVegetationTypeSettings(VegetationTypeIndex vegetationTypeIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ExcludeVegetationType(VegetationType vegetationType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetAdditionalWidthMax(VegetationType vegetationType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetPerlinScale(VegetationType vegetationType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CallDeleteEvent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMaxAdditionalDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float SamplePerlinNoise(Vector3 point, float perlinNoiceScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BaseMaskArea() => throw null;

    public delegate void MultionMaskDeleteDelegate(BaseMaskArea baseMaskArea);
  }
}
