// Decompiled with JetBrains decompiler
// Type: KSP.Rendering.Planets.WaterManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.Rendering.Planets
{
  public class WaterManager
  {
    private const int TEXTURE_SIZE_LARGE = 1024;
    private const int TEXTURE_SIZE_MEDIUM = 768;
    private const int TEXTURE_SIZE_SMALL = 512;
    private const int FAR_TEXTURE_SIZE = 512;
    private const int TEXTURE_SIZE_TERRAIN = 4096;
    private const int GPU_INT_SIZE = 4;
    private const int GPU_FLOAT2_SIZE = 8;
    private const int GPU_FLOAT3_SIZE = 12;
    private const int GPU_MATRIX_SIZE = 64;
    private const int COMPUTE_THREAD_SIZE = 16;
    private const int UNDERWATER_TEX_DOWN_SCALE = 4;
    private const int LOD_COUNT = 2;
    private readonly string[] OCEAN_QUADMESH_ASSET;
    private readonly float[] OCEAN_LOD_RANGE;
    private const int UNDER_OCEAN_VERT_DENSITY = 32;
    private const int SPHERE_VERT_SLICE = 64;
    private const int MAX_MIPMAP_COUNT = 13;
    public static readonly float MAX_RUNNING_TIME;
    private static WaterManager _singleton;
    private Camera _mainCamera;
    private WaterInitPerFrameAction _waterInitPerFrameAction;
    private OceanUpdateAction _oceanUpdateAction;
    private ClearWaterDepthAction _clearWaterDepthAction;
    private DrawOceanAction _drawOceanAction;
    private DrawLandBasedWaterAction _drawLandBasedWaterAction;
    private WaitWaterDetectionAction _waitWaterDetectionAction;
    private PrevisGameInstance _previsGameInstance;
    private CommandBuffer _setGlobalShadowTextureCommand;
    private Light _lightPre;
    public bool NeedWaterDetect;
    public JobHandle WaterDetectJobHandle;
    public NativeArray<Vector3> DetectObjectPosition;
    public NativeArray<Vector3> WaterSurfacePosition;
    public NativeArray<bool> IsUnderWater;
    private List<WaterManager.WaterDetectEntry> _waterDetectEntries;
    public CommandBuffer DrawOceanCommand;
    public CommandBuffer DrawUnderWaterCommand;
    public CommandBuffer InitWaterDefaultDepthTextureCommand;
    public CommandBuffer GenerateWaterDepthCommand;
    public CommandBuffer GenerateUnderOceanMaskCommand;
    public CommandBuffer GenerateLandbasedWaterMaskCommand;
    public NativeArray<Vector3>[] OceanQuadVerts;
    public NativeArray<Vector3>[] OceanVertsWorldPosition;
    public NativeArray<Vector3>[] OceanVertsOnPlanet;
    public NativeArray<Vector2>[] OceanVertsOnOceanPlane;
    public NativeArray<Vector2>[] OceanVertsSphereUV;
    public NativeArray<Vector3>[] OceanVertsFaceNorthMatrix_X;
    public NativeArray<Vector3>[] OceanVertsFaceNorthMatrix_Y;
    public ComputeBuffer[] OceanVertsIndicesBuffer;
    public ComputeBuffer[] OceanVertsWorldPositionBuffer;
    public ComputeBuffer[] OceanVertsOnPlanetBuffer;
    public ComputeBuffer[] OceanVertsOnOceanPlaneBuffer;
    public ComputeBuffer[] OceanVertsSphereUVBuffer;
    public ComputeBuffer[] OceanVertsFaceNorthMatrixBuffer_X;
    public ComputeBuffer[] OceanVertsFaceNorthMatrixBuffer_Y;
    public NativeArray<Vector3> OceanSphereVerts;
    public NativeArray<Vector3> OceanSphereVertsWorldPosition;
    public NativeArray<Vector3> OceanSphereVertsOnPlanet;
    public NativeArray<Vector3> OceanSphereVertsFaceNorthMatrix_X;
    public NativeArray<Vector3> OceanSphereVertsFaceNorthMatrix_Y;
    public ComputeBuffer OceanSphereVertsIndicesBuffer;
    public ComputeBuffer OceanSphereVertsWorldPositionBuffer;
    public ComputeBuffer OceanSphereVertsOnPlanetBuffer;
    public ComputeBuffer OceanSphereVertsFaceNorthMatrixBuffer_X;
    public ComputeBuffer OceanSphereVertsFaceNorthMatrixBuffer_Y;
    public bool NeedDrawUnderOceanEffect;
    public bool NeedDrawUnderLandBasedWaterEffect;
    public bool IsCameraUnderWater;
    public bool NeedDrawOcean;
    public bool NeedDrawSphereOcean;
    public int CurrentOceanLod;
    public float DeltaTime;
    public float RunningTime;
    public JobHandle GenerateOceanVertsJobHandle;
    public JobHandle GenerateOceanSphereVertsJobHandle;
    public ComputeShader GenerateWaterAnimationShader;
    public ComputeShader GenerateWaterFoamShader;
    public ComputeShader GenerateFoamMipmapShader;
    public ComputeShader GenerateFarFoamCycleTextureShader;
    public ComputeShader GenerateUnderWaterLightingShader;
    private RenderTexture _waterDefaultDepthTexture;
    private bool _oceanActive;
    private bool _hasFoamTexture;
    private bool _needGetLightInfo;
    private Light currentStarForDebugScene;

    public int ComputeThreadSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int RenderTextureSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int FarRenderTextureSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int UnderOceanVertsDensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ComputeShader CreateOceanVertsShader
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int CreateOceanVertsKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int CreateUnderOceanRegionVertsKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int GenerateWaterAnimationKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int GenerateFarWaterAnimationKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int GenerateUnderWaterLightingKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int GenerateLandBasedUnderWaterLightingKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int BlurUnderWaterLightingVerticallyKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int BlurUnderWaterLightingHorizontallyKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int ClearFoamKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int UpdateFoamKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int UpdateFarFoamKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int ClearFoamMipmapKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int GenerateFoamMipmap16x16Kernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int GenerateFoamMipmap2x2Kernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int ClearFoamHalf2MipmapKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int GenerateFoamHalf2Mipmap16x16Kernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int GenerateFoamHalf2Mipmap2x2Kernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int CopyFoamToSubregionKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int MirrorFoamXKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public int MirrorFoamYKernel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public Shader LandBasedWaterBackSurfaceShader
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material OceanWaterSphereModeMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material OceanLavaSphereModeMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material OceanWaterBackSurfaceMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material OceanLavaBackSurfaceMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material GenerateWaterNormalMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material GenerateTerrainDepthMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material GenerateShallowDepthMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material GenerateDepthMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material GenerateSphereDepthMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material GenerateUnderOceanMaskMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material GenerateUnderLandBasedWaterMaskMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material GenerateUnderLandBasedWaterMaskMaterial_1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material UnderWaterEffectMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material UnderLandBasedWaterEffectMaterial
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public RenderTexture TerrainDepthTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture ScreenSpaceShadowTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture WaterAnimationTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture FarWaterAnimationTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture WaterNormalTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture WaterFoamTexture0
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture WaterFoamTexture1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture FarWaterFoamTexture0
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture FarWaterFoamTexture1
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture FarWaterFoamCycleTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture FarWaterFoamCycleTextureTemp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture FarWaterFoamShapeTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture WaterDepthTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture WaterTwoSideDepthTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture ShallowDepthTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture UnderOceanMaskTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture UnderLandBasedWaterMaskTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture UnderWaterLightingTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public RenderTexture BluredUnderWaterLightingTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ComputeBuffer UnderOceanRegionVertsBuffer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ComputeBuffer UnderLandBasedWaterRegionCubeVertsBuffer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ComputeBuffer UnderLandBasedWaterRegionCubeIndicesBuffer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ComputeBuffer UnderLandBasedWaterRegionPlaneVertsBuffer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ComputeBuffer UnderLandBasedWaterRegionPlaneIndicesBuffer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public bool OceanActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static WaterManager Instance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Create(PrevisGameInstance previsGameInstance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Destroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private WaterManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetOceanSphereSlice() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAssetLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetLod(float heightFromWater) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterOceanUpdateAction(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterDrawOceanAction(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterDrawLandBasedWaterAction(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnRegisterDrawLandBasedWaterAction(Action action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint RegisterWaterDetectObject(WaterManager.IWaterDetectObject waterDetectObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterWaterDetectObject(uint waterDetectObjectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WaterManager.WaterDetectEntry GetWaterDetectEntry(uint waterDetectObjectId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyComponent GetDetectObjectBody(int index) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetWaterDetectObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnumerateWaterDetectObjects(Action<WaterManager.WaterDetectEntry> func) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWaterInitPerFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnWaitWaterDetection() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnClearWaterDepth() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateShaderAndMaterial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateOceanSphereVerts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateUnderLandBasedWaterRegionVerts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateBuffer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private RenderTexture CreateRenderTexture(
      string name,
      int width,
      int height,
      int depth,
      RenderTextureFormat format,
      bool useMipMap,
      bool enableRandomWrite = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetOceanActive(bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool UpdateRenderTexture(
      OceanSpectrumPrecision precision,
      int farFoamShapeTextureSize,
      bool hasFoam,
      out bool isFarFoamShapeTexUpdate)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDepthTexture(int cameraPixelWidth, int cameraPixelHeight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WaitForGenerateOceanVertsJob() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WaitForGenerateOceanSphereVertsJob() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetLightInfo(ref Vector3 lightDirection, ref Vector3 lightColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsInDebugScene() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetLightInfoInDebugScene(ref Vector3 lightDirection, ref Vector3 lightColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphericalHarmonicsL2 GetGIProbeInDebugScene(string celestialName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static WaterManager() => throw null;

    public interface IWaterDetectObject
    {
      Vector3 GetPosition();

      CelestialBodyComponent GetBody();

      Vector3 GetHorizonUp();
    }

    [BurstCompile]
    public struct UnderWaterDetectJob : IJobParallelFor
    {
      [ReadOnly]
      public NativeArray<Vector3> ObjectPosition;
      [ReadOnly]
      public Matrix4x4D WorldToLocalMatrix;
      [ReadOnly]
      public Matrix4x4D LocalToWorldMatrix;
      [ReadOnly]
      public float OceanRadius;
      [WriteOnly]
      public NativeArray<Vector3> WaterSurfacePosition;
      public NativeArray<bool> IsUnderWater;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int i) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private double RayTraceSphere(Vector3d position, Vector3d direction, double radius) => throw null;
    }

    [BurstCompile]
    public struct UnderLandBasedWaterDetectJob : IJobParallelFor
    {
      [ReadOnly]
      public NativeArray<Vector3> ObjectPosition;
      [ReadOnly]
      public Matrix4x4 WorldToLocalMatrix;
      [ReadOnly]
      public Matrix4x4 LocalToWorldMatrix;
      [ReadOnly]
      public Vector3 UnderWaterRegionSize;
      [ReadOnly]
      public NativeArray<Vector3> InvalidRegionSize;
      [ReadOnly]
      public NativeArray<Matrix4x4> InvalidRegionWorldToLocalMatrix;
      [WriteOnly]
      public NativeArray<Vector3> WaterSurfacePosition;
      public NativeArray<bool> IsUnderWater;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Execute(int i) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private float RayTracePlane(
        Vector3 linePoint,
        Vector3 lineDirection,
        Vector3 planePoint,
        Vector3 planeNormal)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool IsPositionInBoxCollider(Vector3 position, Vector3 colliderSize, float zOffset = 0.0f) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private bool IsPositionInUnderWaterRegion(Vector3 position) => throw null;
    }

    public class WaterDetectEntry
    {
      public const uint INVALID_WATER_DETECT_ENTRY_ID = 0;
      private const uint FIRST_WATER_DETECT_ENTRY_ID = 1;
      private static uint NextWaterDetectEntryId;
      public uint Id;
      public WaterManager.IWaterDetectObject Object;
      public Vector3 WaterSurfacePosition;
      public bool IsUnderwater;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public WaterDetectEntry(WaterManager.IWaterDetectObject entryObject) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Reset() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      private static uint GenerateWaterDetectEntryId() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static WaterDetectEntry() => throw null;
    }
  }
}
