// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationStudio;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace AwesomeTechnologies.VegetationSystem
{
  [Serializable]
  public class VegetationSettings
  {
    public float PlantDistance;
    public float AdditionalTreeMeshDistance;
    public float AdditionalBillboardDistance;
    public float HeroObjectDistance;
    public int Seed;
    public float LODDistanceFactor;
    public bool GrassShadows;
    public bool PlantShadows;
    public bool TreeShadows;
    public bool ObjectShadows;
    public bool MediumObjectShadows;
    public bool LargeObjectShadows;
    public bool BillboardShadows;
    public bool DisableRenderDistanceFactor;
    public bool UseEarlyBiomeCellRejection;
    public LayerMask GrassLayer;
    public LayerMask PlantLayer;
    public LayerMask TreeLayer;
    public LayerMask ObjectLayer;
    public LayerMask MediumObjectLayer;
    public LayerMask LargeObjectLayer;
    public LayerMask BillboardLayer;
    public float GrassDensity;
    public float PlantDensity;
    public float TreeDensity;
    public float ObjectDensity;
    public float MediumObjectDensity;
    public float LargeObjectDensity;
    public float VegetationScale;
    public float GrassDistanceFactor;
    public float PlantDistanceFactor;
    public float TreeDistanceFactor;
    public float ObjectDistanceFactor;
    public float MediumObjectDistanceFactor;
    public float LargeObjectDistanceFactor;
    private QualityManager _qualityManager;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowCastingMode GetBillboardShadowCastingMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShadowCastingMode GetShadowCastingMode(VegetationType vegetationType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LayerMask GetLayer(VegetationType vegetationType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LayerMask GetBillboardLayer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetVegetationItemDensity(VegetationType vegetationType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRenderDistanceFactor(VegetationType vegetationType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetVegetationDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetBillboardDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetTreeDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetHeroDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetQualityManager(QualityManager manager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationSettings() => throw null;
  }
}
