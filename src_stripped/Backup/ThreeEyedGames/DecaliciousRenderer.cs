// Decompiled with JetBrains decompiler
// Type: ThreeEyedGames.DecaliciousRenderer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace ThreeEyedGames
{
  [ExecuteInEditMode]
  public class DecaliciousRenderer : KerbalMonoBehaviour
  {
    [HideInInspector]
    public bool UseInstancing;
    public float _cullingDistance;
    private bool _dependenciesInit;
    protected CommandBuffer _bufferDeferred;
    protected CommandBuffer _bufferUnlit;
    protected CommandBuffer _bufferMask;
    protected SortedDictionary<int, Dictionary<Material, HashSet<Decal>>> _deferredDecals;
    protected SortedDictionary<int, Dictionary<Material, HashSet<Decal>>> _unlitDecals;
    protected Dictionary<int, DecalMaskObject> _maskGameObjects;
    protected List<MeshRenderer> _maskMeshRenderers;
    protected List<SkinnedMeshRenderer> _maskSkinnedMeshRenderers;
    protected List<Decal> _decalComponent;
    protected List<MeshFilter> _meshFilterComponent;
    protected Dictionary<Decal, GameObject> _decalQueue;
    protected CommandBuffer _bufferDeferredScene;
    protected CommandBuffer _bufferUnlitScene;
    protected CommandBuffer _bufferMaskScene;
    protected const string BUFFER_BASE_NAME = "Decalicious - ";
    protected const string BUFFER_DEFERRED_NAME = "Decalicious - Deferred";
    protected const string BUFFER_UNLIT_NAME = "Decalicious - Unlit";
    protected const string BUFFER_MASK_NAME = "Decalicious - Mask Game Objects";
    protected const CameraEvent CAMEVENT_DEFERRED = CameraEvent.BeforeReflections;
    protected const CameraEvent CAMEVENT_UNLIT = CameraEvent.BeforeImageEffectsOpaque;
    protected const CameraEvent CAMEVENT_MASK = CameraEvent.BeforeReflections;
    private static readonly int MASK_MULTIPLIER_ID;
    private static readonly int MASK_ID;
    private static readonly int MASK_BUFFER_ID;
    private static readonly int MASK_BUFFER_PQS_ID;
    private static readonly int GBUFFER_COPY1_ID;
    private static readonly int GBUFFER_COPY2_ID;
    private static readonly int MASK_ID_ID;
    private static readonly int MASK_TEX_ID;
    protected Camera _camera;
    protected bool _camLastKnownHDR;
    protected static Mesh _cubeMesh;
    protected static string _cubeMeshPath;
    protected Matrix4x4[] _matrices;
    protected float[] _fadeValues;
    protected float[] _maskValues;
    protected MaterialPropertyBlock _instancedBlock;
    protected MaterialPropertyBlock _directBlock;
    protected RenderTargetIdentifier[] _albedoRenderTarget;
    protected RenderTargetIdentifier[] _normalRenderTarget;
    protected Material _materialMaskGameObjects;
    protected static Vector4[] _avCoeff;
    protected const float NO_MASK_VALUE = 0.0f;
    private const string MASK_SHADER_NAME = "DecaliciousGameObjectID.shader";
    private const string MASK_SHADER_PATH = "Assets/Packages/DecaliciousUpload/Shader/DecaliciousGameObjectID.shader";
    private Shader _maskShader;
    protected const string MESH_NAME = "DecalCube.asset";
    private Plane[] _cullingPlanes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPreRender() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupCommandBufferForCamera(
      Camera cam,
      CommandBuffer bufferDeferred,
      CommandBuffer bufferUnlit,
      CommandBuffer bufferMask)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawMaskGameObjects(Camera cam, ref CommandBuffer bufferMask) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void SetLightProbeOnBlock(
      SphericalHarmonicsL2 probe,
      MaterialPropertyBlock block)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DoDecalCulling(ref Decal decal, ref Camera cam, Vector3 camPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawDeferredDecals_Albedo(Camera cam, ref CommandBuffer bufferDeferred) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawDeferredDecals_NormSpecSmooth(Camera cam, ref CommandBuffer bufferDeferred) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawUnlitDecals(Camera cam, ref CommandBuffer bufferUnlit) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void CreateBuffer(
      ref CommandBuffer buffer,
      Camera cam,
      string name,
      CameraEvent evt)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Decal decal, GameObject maskObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDecalMask(Decal decal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddToQueue(Decal decal, GameObject maskObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void AddToDictionary(
      ref SortedDictionary<int, Dictionary<Material, HashSet<Decal>>> decalDict,
      Decal decal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddToMaskDictionary(ref Dictionary<int, DecalMaskObject> decalDict, Decal decal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Remove(Decal decal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void RemoveFromDictionary(
      ref SortedDictionary<int, Dictionary<Material, HashSet<Decal>>> decalDict,
      Decal decal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveFromMaskDictionary(
      ref Dictionary<int, DecalMaskObject> decalDict,
      Decal decal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Cleanup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DecaliciousRenderer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DecaliciousRenderer() => throw null;

    private enum Pass
    {
      MaskID,
      RenderPQS,
    }
  }
}
