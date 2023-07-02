// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.VegetationItemModelInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.Shaders;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem
{
  public class VegetationItemModelInfo
  {
    public GameObject VegetationModel;
    public Vector3 AdditionalMeshScale;
    public Mesh VegetationMeshLod0;
    public Mesh VegetationMeshLod1;
    public Mesh VegetationMeshLod2;
    public Mesh VegetationMeshLod3;
    public float LOD1Distance;
    public float LOD2Distance;
    public float LOD3Distance;
    public int LODCount;
    public bool LODFadePercentage;
    public bool LODFadeCrossfade;
    public int DistanceBand;
    public Material[] VegetationMaterialsLOD0;
    public Material[] VegetationMaterialsLOD1;
    public Material[] VegetationMaterialsLOD2;
    public Material[] VegetationMaterialsLOD3;
    public MeshRenderer VegetationRendererLOD0;
    public MeshRenderer VegetationRendererLOD1;
    public MeshRenderer VegetationRendererLOD2;
    public MeshRenderer VegetationRendererLOD3;
    public MaterialPropertyBlock VegetationMaterialPropertyBlockLOD0;
    public MaterialPropertyBlock VegetationMaterialPropertyBlockLOD1;
    public MaterialPropertyBlock VegetationMaterialPropertyBlockLOD2;
    public MaterialPropertyBlock VegetationMaterialPropertyBlockLOD3;
    public MaterialPropertyBlock VegetationMaterialPropertyBlockShadowsLOD0;
    public MaterialPropertyBlock VegetationMaterialPropertyBlockShadowsLOD1;
    public MaterialPropertyBlock VegetationMaterialPropertyBlockShadowsLOD2;
    public MaterialPropertyBlock VegetationMaterialPropertyBlockShadowsLOD3;
    public VegetationItemInfoPro VegetationItemInfo;
    public EnvironmentSettings EnvironmentSettings;
    public float BoundingSphereRadius;
    public GameObject SelectedVegetationModelLOD0;
    public GameObject SelectedVegetationModelLOD1;
    public GameObject SelectedVegetationModelLOD2;
    public GameObject SelectedVegetationModelLOD3;
    public Material BillboardMaterial;
    public Mesh CustomBillboardMesh;
    public Material CustomBillboardMaterial;
    public MaterialPropertyBlock CustomBillboardMaterialPropertyBlock;
    public VegetationRenderSettings VegetationRenderSettings;
    public List<MeshRenderer> WindSamplerMeshRendererList;
    public readonly List<CameraComputeBuffers> CameraComputeBufferList;
    public readonly List<MaterialPropertyBlock> CameraBillboardMaterialPropertyBlockList;
    public NativeArray<float> HeightRuleCurveArray;
    public NativeArray<float> SteepnessRuleCurveArray;
    [NonSerialized]
    public IShaderController ShaderControler;
    public bool BillboardLODFadeCrossfade;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationItemModelInfo(
      VegetationItemInfoPro vegetationItemInfo,
      EnvironmentSettings environmentSettings,
      List<GameObject> windSamplerList,
      int cameraCount,
      VegetationRenderSettings vegetationRenderSettings)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateCameraWindSamplerItems(List<GameObject> windSamplerList) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateCameraBuffers(int cameraCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGrassTexture(Material[] materials, Texture2D texture) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateBillboardMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateBillboardMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisposeCameraBuffers() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateHeightRuleCurve() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateSteepnessRuleCurve() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyMaterials(Material[] materials) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void DestroyMaterial(Material material) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Mesh GetVegetationMesh(
      GameObject rootVegetationModel,
      LODLevel lodLevel,
      out Vector3 additionalMeshScale)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float GetLODDistance(GameObject rootVegetationModel, int lodIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Material[] CreateMaterials(Material[] sharedMaterials, int lodIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RefreshMaterial(Material material, int lodIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Color GetLODColor(int lodIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshMaterials() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Mesh GetLODMesh(int lodIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Material[] GetLODMaterials(int lodIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MaterialPropertyBlock GetLODMaterialPropertyBlock(int lodIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GraphicsBuffer GetLODVisibleBuffer(int lodIndex, int cameraIndex, bool shadows) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<GraphicsBuffer> GetLODArgsBufferList(int lodIndex, int cameraIndex, bool shadows) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CleanVegetationObject(GameObject go) => throw null;
  }
}
