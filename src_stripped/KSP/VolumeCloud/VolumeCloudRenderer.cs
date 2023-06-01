// Decompiled with JetBrains decompiler
// Type: KSP.VolumeCloud.VolumeCloudRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.VolumeCloud
{
  [ImageEffectOpaque]
  [RequireComponent(typeof (Camera))]
  [ExecuteInEditMode]
  [ImageEffectAllowedInSceneView]
  public class VolumeCloudRenderer : EffectBase
  {
    public static bool enableClouds;
    private static int raymarchStepSize;
    [Header("Config")]
    private VolumeCloudConfiguration configuration;
    private VolumeCloudConfiguration.CumulusData firstCumulusData;
    [Range(0.0f, 7f)]
    [Header("Render Settings")]
    public float downSample;
    [Range(1f, 7f)]
    public int downSampleShadow;
    public bool enableTAA;
    private bool enableUpSample;
    [Range(0.1f, 10f)]
    private float dynamicResolutionLevel;
    public float blendAlpha;
    public bool trilinearSample;
    private float multipler;
    private Vector2 allCloudsLayersRange;
    private Material cumulusMat;
    private Material cumulusPostProcessMat;
    private Material cumulusCloudDepthMat;
    private Material cumulusCloudShadowMat;
    private Material currentMat;
    private Material cloudShadowBlurMat;
    private Material cloudGodRayBlurMat;
    private Material[] currentCloudsMat;
    private Material[] SecondPassCloudsMat;
    private Material[] cloudsShadowMaterialArray;
    private Material[] scaledCloudsShadowMaterialArray;
    private RenderTargetIdentifier[] resultColorAndDistance;
    private RenderTexture checkTileIndexBuffer;
    private RenderTexture formerCloudLayerBuffer;
    private RenderTexture sceneCloudDepth;
    private RenderTexture sceneCloudDepthTemp;
    private RenderTexture raySampleCountBuffer;
    private RenderTexture raySampleCountBufferTemp;
    private RenderTexture raySampleCountBufferMipmap;
    private RenderTexture historyBuffer;
    private RenderTexture finalSceneColor;
    private RenderTexture finalSceneColor2;
    private RenderTexture tAAResultBuffer;
    private RenderTexture undersampleBuffer;
    private RenderTexture downsampledDepth;
    private RenderTexture godrayBuffer;
    private RenderTexture shadowBuffer;
    private RenderTexture shadowBufferInput;
    private RenderTexture godrayBlurBuffer;
    private RenderTexture shadowBlurBuffer;
    private GameManager gameManager;
    private Light currentLocalLight;
    private Light currentScaledLight;
    private PrevisGameInstance previsGame;
    private Matrix4x4 prevV;
    private Camera mCamera;
    private HaltonSequence sequence;
    private bool firstFrame;
    [Header("Shader references(DONT EDIT)")]
    [SerializeField]
    private Shader cumulusCloudShader;
    [SerializeField]
    private Shader cumulusCloudPostProcessShader;
    [SerializeField]
    private Shader cumulusCloudDepthShader;
    [SerializeField]
    private Shader cumulusCloudShadowShader;
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
    private bool readIsComplete;
    private List<VolumeCloudConfiguration.CloudsData> cloudsDataList;
    private List<VolumeCloudConfiguration.BoxCloudData> boxCloudDataList;
    private List<List<int>> cloudsLayerDrawIndex;
    private List<List<int>> secondPassCloudsLayerDrawIndex;
    private GraphicsManager graphicsManager;
    private float dynamicResolutionRatioMax;
    private float dynamicResolutionRatioMin;
    private float minimumResolutionUnit;
    private float resolutionScale;
    private int renderWidth;
    private int renderHeight;
    private int originalWidth;
    private int originalHeight;
    private Dictionary<VolumeCloudConfiguration, GameObject> configAndCelestial;
    private CommandBuffer _setGlobalShadowMapCommand;
    private Light _lightPre;
    private CommandBuffer cloudsCommandBuffer;
    private CommandBuffer cloudsShadowCommandBuffer;
    private CommandBuffer scaledCloudsShadowCommandBuffer;
    private CommandBuffer clearShadowCommandBuffer;
    private Mesh fullScreenQuad;
    private const int maxCloudsCount = 4;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnsureMaterial(bool force = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateFullscreenQuad() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAddCloudRenderHelper(CloudRenderHelper renderHelper) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRemoveCloudRenderHelper(CloudRenderHelper renderHelper) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnConfigIniteComplete(VolumeCloudConfiguration config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool IsEnabledClouds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void EnableClouds(bool enableClouds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetRaymarchStepSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetRaymarchStepSize(int stepSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetCloudsQualityLevel(int level, GraphicsManager graphicsManager) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetLightInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private PrevisGameInstance GetPrevisGameInstance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnConfigChanged(VolumeCloudConfiguration configuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnCloudLayerChanged(VolumeCloudConfiguration configuration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RenderClouds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int[] GetUpperLayerIndex(List<int> CurrentIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int GetUpperLayerIndex(int layerindex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector2 GetOverlapRange(Vector2 a, Vector2 b) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateWind(VolumeCloudConfiguration config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateCloudsLayerList(VolumeCloudConfiguration config, GameObject cloudsObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CheckOverlaped(Vector2 rangeLower, Vector2 rangeUpper) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateCloudsLayerDrawIndex(VolumeCloudConfiguration config) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AsyncGPUReadbackCallBack(AsyncGPUReadbackRequest request) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VolumeCloudRenderer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VolumeCloudRenderer() => throw null;

    private class AABB
    {
      public Vector3 Min;
      public Vector3 Max;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AABB() => throw null;
    }

    private class CloudBoundingBox
    {
      public Matrix4x4 boxMatrices;
      public VolumeCloudRenderer.AABB boxAABB;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public CloudBoundingBox() => throw null;
    }
  }
}
