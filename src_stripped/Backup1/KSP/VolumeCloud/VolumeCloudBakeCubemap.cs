// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.VolumeCloudBakeCubemap
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace KSP.VolumeCloud
{
  [ImageEffectAllowedInSceneView]
  [RequireComponent(typeof (Camera))]
  [ImageEffectOpaque]
  [ExecuteInEditMode]
  public class VolumeCloudBakeCubemap : EffectBase
  {
    public bool enableClouds;
    private int raymarchStepSize;
    [Header("Config")]
    private GameObject configprefeb;
    private VolumeCloudConfiguration configuration;
    private VolumeCloudConfiguration.CumulusData firstCumulusData;
    private VolumeCloudConfiguration.CumulusData refCumulusData;
    [Header("Render Settings")]
    [Range(0.0f, 7f)]
    public int downSample;
    [Range(1f, 7f)]
    public int downSampleShadow;
    public bool enableTAA;
    public float blendAlpha;
    public bool trilinearSample;
    private float multipler;
    private Vector2 allCloudsLayersRange;
    private Material cumulusMat;
    private Material currentMat;
    private RenderBuffer[] resultColorAndDistance;
    private RenderTexture[] raymarchedDistance;
    private RenderTexture normalRenderTarget;
    private RenderTexture shadowRenderTarget;
    private RenderTexture undersampleBuffer;
    private RenderTexture downsampledDepth;
    private GameManager gameManager;
    private PrevisGameInstance previsGame;
    private Camera mCamera;
    [SerializeField]
    [Header("Shader references(DONT EDIT)")]
    private Shader cumulusCloudShader;
    [SerializeField]
    private ComputeShader cloudsComputeShader;
    [SerializeField]
    private ComputeShader rayCheckGetTile;
    [SerializeField]
    private Shader listCreationShader;
    [SerializeField]
    private Shader listRenderingShader;
    [SerializeField]
    private Shader listDepthShader;
    private Material listCreationMat;
    private Material listRenderingMat;
    private Material listDepthMat;
    private CubemapFace currentShadowFace;
    private int requestMipmapIndex;
    private int bakeMipmapLevelCount;
    private int bakeMipmap;
    private int faceWidth;
    private int faceHeight;
    private int faceWidthOri;
    private int faceHeightOri;
    private Dictionary<VolumeCloudConfiguration, GameObject> configAndCelestial;
    private bool EnableBakeCubemap;
    private Cubemap cloudsCubemap;
    private Cubemap cloudsBottomCubemap;
    private Cubemap cloudsNormalCubemap;
    private bool isBakeCloudBottom;
    private bool isBakeCloudBottomComplete;
    private CubemapFace currentFace;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnsureMaterial(bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnConfigIniteComplete(VolumeCloudConfiguration config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBakeCubemap(
      VolumeCloudConfiguration.CumulusData cumulusData,
      VolumeCloudConfiguration config)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsEnabledClouds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnableClouds(bool enableClouds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetRaymarchStepSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRaymarchStepSize(int stepSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLoadedCompleted(AsyncOperationHandle<GameObject> obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PrevisGameInstance GetPrevisGameInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnConfigChanged(VolumeCloudConfiguration configuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BakeCubemap(VolumeCloudConfiguration.CloudsData cloudsLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AsyncMipmapFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AsyncNormalCallBack(AsyncGPUReadbackRequest request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BakeNormalCubeMap() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderClouds(VolumeCloudConfiguration.CloudsData cloudsLayer) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GenerateMipmapFile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AsyncGPUReadbackCallBack(AsyncGPUReadbackRequest request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRenderImage(RenderTexture source, RenderTexture destination) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateCloudsLayerList(VolumeCloudConfiguration.CumulusData cumulusData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawCloudsLayer(
      Material mat,
      RenderTexture cloudsResult,
      VolumeCloudConfiguration.CloudsData cloudsData,
      Vector3 ralatedPostion)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VolumeCloudBakeCubemap() => throw null;
  }
}
