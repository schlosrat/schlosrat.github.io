// Decompiled with JetBrains decompiler
// Type: ThreeEyedGames.Decal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace ThreeEyedGames
{
  [ExecuteAlways]
  [RequireComponent(typeof (MeshRenderer))]
  [RequireComponent(typeof (MeshFilter))]
  public class Decal : KerbalMonoBehaviour
  {
    private const string DEFERRED_SHADER_NAME = "DecaliciousDeferredDecal.shader";
    private const string UNLIT_SHADER_NAME = "DecaliciousUnlitDecal.shader";
    private const string MESH_NAME = "DecalCube.asset";
    private Shader _deferredShader;
    private Shader _unlitShader;
    private MeshRenderer _meshRenderer;
    private Transform _meshRendererTransform;
    private bool Culled;
    public Decal.DecalRenderMode RenderMode;
    [Tooltip("Set a Material with a Decalicious shader.")]
    public Material Material;
    [Tooltip("Should this decal be drawn early (low number) or late (high number)?")]
    public int RenderOrder;
    [Tooltip("To which degree should the Decal be drawn? At 1, the Decal will be drawn with full effect. At 0, the Decal will not be drawn. Experiment with values greater than one.")]
    public float Fade;
    [FormerlySerializedAs("LimitTo")]
    [Tooltip("Set a GameObject here to only draw this Decal on the MeshRenderer of the GO or any of its children.")]
    public GameObject MaskObj;
    [HideInInspector]
    public int MaskObjID;
    public bool BlendWithPQS;
    [Tooltip("Enable to draw the Albedo / Emission pass of the Decal.")]
    public bool DrawAlbedo;
    [Tooltip("Use an interpolated light probe for this decal for indirect light. This breaks instancing for the decal and thus comes with a performance impact, so use with caution.")]
    public bool UseLightProbes;
    [Tooltip("Enable to draw the Normal / SpecGloss pass of the Decal.")]
    public bool DrawNormalAndGloss;
    [Tooltip("Enable perfect Normal / SpecGloss blending between decals. Costly and has no effect when decals don't overlap, so use with caution.")]
    public bool HighQualityBlending;
    [Tooltip("Enable to use the override cull distance.")]
    public bool UseOverrideCullDistance;
    [Tooltip("Override Cull Distance to use for this decal. Ignores the Decalicious Renderer cull distance.")]
    public float OverrideCullDistance;
    private bool hasRegistered;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCullingStatus(bool isCulled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetCullingStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshRenderer GetMeshRenderer() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Transform GetMeshRendererTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeferredShaderLoaded(Shader result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnlitShaderLoaded(Shader result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CheckAllAssetsLoaded() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EditorRemove() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RegisterDecal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDecalMask(GameObject maskObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemoveDecal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDrawGizmosSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Decal() => throw null;

    public enum DecalRenderMode
    {
      Deferred,
      Unlit,
      Invalid,
    }
  }
}
