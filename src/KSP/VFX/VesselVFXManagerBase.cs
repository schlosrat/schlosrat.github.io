// Decompiled with JetBrains decompiler
// Type: KSP.VFX.VesselVFXManagerBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Rendering.Planets;
using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace KSP.VFX
{
  [Serializable]
  public class VesselVFXManagerBase
  {
    protected float _vfxIntensity;
    private bool _spawning;
    protected VesselBehavior Vessel;
    protected GameInstance Game;
    public string VfxPrefabPath;
    protected string MaterialPath;
    protected int VfxQuality;
    protected int VfxBufferSize;
    protected float MeshScale;
    protected float MeshScaleFactor;
    protected string CmdBufferName;
    protected float DepthCamNearMult;
    protected float DepthCamBoundsMult;
    protected Vector3 DepthCamScale;
    protected int ComputeThreadSize;
    protected float MeshDepthScale;
    protected string DepthOnlyShaderPath;
    protected string DepthBlurShaderPath;
    protected string JumpFloodAlgoShaderPath;
    protected int VFXCameraLayer;
    private static readonly int BLUR_TEMP_1;
    private static readonly int BLUR_TEMP_2;
    private static readonly int JFA_TEMP_1;
    private static readonly int JFA_TEMP_2;
    private static readonly int _depthMultiplierID;
    private static readonly int _depthTextureID;
    private static readonly int _stepPropertyID;
    private static readonly int _vertexOrigPosBufferID;
    private static readonly int _meshVertexBufferID;
    private static readonly int _depthMapID;
    private static readonly int _vertexBufferWidthID;
    private static readonly int _vertexBufferHeightID;
    private static readonly int _viewProjectionMatrixID;
    [SerializeField]
    protected VesselVFXManagerBase.EffectQuality _currentQuality;
    protected Bounds _vesselBounds;
    protected float _vesselBoundsMaxSize;
    protected float _vesselBoundsMaxExtent;
    protected CommandBuffer _cmdBuffer;
    protected RenderTexture _vfxDepthTexture;
    protected Material _depthOnlyMat;
    protected Material _depthBlurMat;
    private ComputeShader _meshUpdateComputeShader;
    private ComputeBuffer _meshVertBuffer;
    private ComputeBuffer _originalVertBuffer;
    private int _meshUpdateKernelHandle;
    private int _threadGroupX;
    private int _threadGroupY;
    protected Material _jumpFloodMaterial;
    protected Mesh _vfxMesh;
    protected Vector3[] _meshVertices;
    protected GameObject _vfxMeshGO;
    protected Material _vfxMaterial;
    protected Vector3 _vfxMeshScale;
    protected Transform _vfxCamTransform;
    protected ParticleSystem _particleSystem;
    public bool EnableDownscaleBlur;
    public float MeshDepthMuliplier;
    public float MeshDistanceOffset;
    public float MeshScaleMultiplier;
    public float ComputeDepthMult;
    public bool EnableParticleFX;
    [SerializeField]
    protected Vector3 _vesselDir;
    protected GameObject VFXGameObject;
    [SerializeField]
    protected bool _debugFX;
    [SerializeField]
    protected bool _debugResetMesh;

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float VFXIntensity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsSpawning
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselVFXManagerBase(
      VesselVFXManagerBase.EffectQuality effectQuality,
      VesselBehavior vessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SpawnVFX(GameObject particlePrefab) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Bounds CalculateBounds(bool enableEffect) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateVFX(VesselVFXManagerBase.EffectQuality effectQuality, PQS pqs) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void PositionCameraAndMesh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CalculateSetIntensity() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool CheckCondition(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private float GetThermalFlux() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateEvent(FXContextData context) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual FXContextualEvent CreateEvent(
      FXContextualEventParams fxContextualEventParams,
      FXPartContextData fxPartContextData,
      VesselBehavior vessel)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Material CreateShaderMaterial(string shaderPath) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateDepthMapResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateJFA() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void GenerateMesh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateVFXMeshGO() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void CreateComputeResources() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetupParticleSystem(GameObject prefab) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void SetParameters() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMeshVertices(AsyncGPUReadbackRequest req) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GUIDraw() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VesselVFXManagerBase() => throw null;

    public enum EffectQuality
    {
      LOW,
      HIGH,
    }
  }
}
