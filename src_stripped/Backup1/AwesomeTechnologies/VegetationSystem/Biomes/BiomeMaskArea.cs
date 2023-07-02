// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationSystem.Biomes.BiomeMaskArea
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.VegetationSystem.Biomes
{
  [ExecuteInEditMode]
  public class BiomeMaskArea : MonoBehaviour
  {
    public List<Node> Nodes;
    public bool ClosedArea;
    public bool ShowArea;
    public bool ShowHandles;
    public string MaskName;
    private bool _needInit;
    public string Id;
    public BiomeType BiomeType;
    public LayerMask GroundLayerMask;
    public AnimationCurve BlendCurve;
    public AnimationCurve InverseBlendCurve;
    public AnimationCurve TextureBlendCurve;
    public float BlendDistance;
    public float NoiseScale;
    public bool UseNoise;
    private PolygonBiomeMask _currentMaskArea;
    private Vector3 _lastPosition;
    private Quaternion _lastRotation;
    private Vector3 _lastLossyScale;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateBiomeMask() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ValidateAnimationCurve(AnimationCurve curve) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private AnimationCurve CreateResetAnimationCurve() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<bool> GetDisableEdgeList() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateDefaultNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteNode(Node node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodesToEnd(Vector3[] worldPositions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodesToEnd(Vector3[] worldPositions, bool[] disableEdges) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodesToEnd(Vector3[] worldPositions, float[] customWidth, bool[] active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodesToEnd(
      Vector3[] worldPositions,
      float[] customWidth,
      bool[] active,
      bool[] disableEdges)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodeToEnd(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodeToEnd(Vector3 worldPosition, bool disableEdge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodeToEnd(Vector3 worldPosition, float customWidth, bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodeToEnd(
      Vector3 worldPosition,
      float customWidth,
      bool active,
      bool disableEdge)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PositionNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNode(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNodeIndex(Node node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetWorldSpaceNodePositions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Node GetNextNode(Node node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Node GetPreviousNode(Node node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Node FindClosestNode(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDrawGizmosSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDrawGizmos() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetMaskCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetMeanVector(Vector3[] positions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshPostProcessVolume() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BiomeMaskArea() => throw null;
  }
}
