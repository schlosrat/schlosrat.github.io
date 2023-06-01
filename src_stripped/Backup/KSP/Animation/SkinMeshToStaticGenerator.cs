// Decompiled with JetBrains decompiler
// Type: KSP.Animation.SkinMeshToStaticGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Animation
{
  public class SkinMeshToStaticGenerator : MonoBehaviour
  {
    private const string STATIC_ROOT_SUFFIX = "_staticroot";
    private const string STATIC_VISUALMESH_SUFFIX = "_staticVisual";
    private const string STATIC_COLLISION_SUFFIX = "_staticCollision";
    private const string STATIC_TRANSFORM_SUFFIX = "_staticTransform";
    private static RuntimeMeshTracker runtimeMeshTracker;
    public SkinMeshToStaticGenerator.StaticSetData[] NamedMeshBonePairs;
    public Dictionary<string, Transform> ManagedPivots;
    public Dictionary<string, Vector3> VisualSkinnedMeshShaderData;
    private List<GameObject> skinnedMeshesCurrentlyManaged;
    private List<Collider> managedColliders;
    private List<GameObject> staticMeshesCurrentlyManaged;
    private List<StackObjectsBetweenTwoPoints> stackGeneratorsCurrentlyManaged;
    private List<Vector3> _verticesScratch;
    private List<Vector3> _normalScratch;
    private List<int> _triangleScratch;
    private bool _doFlipTriangles;
    private SkinMeshToStaticGenerator.VectorFlipMode _flipVerticesMode;
    private SkinMeshToStaticGenerator.VectorFlipMode _flipNormalsMode;

    public GameObject StaticRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ConfigureMeshFlippingSettings(
      SkinMeshToStaticGenerator.VectorFlipMode verticesFlipMode,
      SkinMeshToStaticGenerator.VectorFlipMode normalsFlipMode,
      bool flipTriangles)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static Vector3 FlipNormal(Vector3 normal, SkinMeshToStaticGenerator.VectorFlipMode mode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GenerateStaticMeshesAndCollision(int visualLayerIndex = -1) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static void TrackMesh(Mesh mesh, GameObject owner) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BakeAllVisualSkinnedMeshes(
      SkinMeshToStaticGenerator.StaticSetData staticSetData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LabelGameObjectWithDragMeshTag(GameObject GO) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BakeAllCollisionSkinnedMeshes(
      SkinMeshToStaticGenerator.StaticSetData staticSetData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DuplicateAllManagedStaticMeshes(
      SkinMeshToStaticGenerator.StaticSetData staticSetData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BakeAllManagedStaticTransforms(
      SkinMeshToStaticGenerator.StaticSetData staticSetData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DuplicateAllGeneratedStacks(
      SkinMeshToStaticGenerator.StaticSetData staticSetData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Mesh TryFlipNormalsAndTriangles(Mesh inputMesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject CreateFreshGameObjectWithName(string newName, Transform posRotTarget) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject CreateInstancedGameObjectWithName(
      GameObject toInstance,
      string newName,
      Transform posRotTarget)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetStaticInstancesParent(Transform staticInstanceTransform, Transform targetParent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FlipMeshVertices(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FlipMeshNormals(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FlipMeshTriangles(Mesh mesh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Collider[] GetBakedColliders() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AlignTo(Transform child, Transform transformToAlignTo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Transform FindOrAddPivot(Transform targetPivotToDuplicate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleAllManagedMeshes(bool showOriginalSkinnedMeshes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleManagedSkinnedMeshes(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleManagedStaticMeshes(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleManagedStackGenerators(bool showOriginalSkinnedMeshes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject TransferStaticRootOwnership(Transform newParent, bool worldPositionStays = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetManagedMeshes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetManagedStaticObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SkinMeshToStaticGenerator() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SkinMeshToStaticGenerator() => throw null;

    [Serializable]
    public class AttachNodeData : INullable
    {
      public string NodeName;
      public Transform TargetBone;

      public bool IsNull
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public AttachNodeData() => throw null;
    }

    [Serializable]
    public class StaticSetData
    {
      public string Name;
      public Transform TargetAttachTransform;
      [Tooltip("If hiding this set of meshes would reveal an attach node in the VAB, put the node name and transform the node should sit at here.")]
      public SkinMeshToStaticGenerator.AttachNodeData NodeData;
      [FormerlySerializedAs("VisualMeshes")]
      public SkinnedMeshRenderer[] VisualSkinnedMeshes;
      public SkinnedMeshRenderer[] CollisionMeshes;
      public MeshRenderer[] VisualStaticMeshes;
      public StackObjectsBetweenTwoPoints[] StackGenerators;
      public Transform[] StaticTransforms;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void ToggleVisibility(bool isVisible) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public StaticSetData() => throw null;
    }

    public enum VectorFlipMode
    {
      NoFlip,
      FlipX,
      FlipXY,
      FlipXZ,
      FlipY,
      FlipYZ,
      FlipZ,
      FlipXYZ,
    }
  }
}
