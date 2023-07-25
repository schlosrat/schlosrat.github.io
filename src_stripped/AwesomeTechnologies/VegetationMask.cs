// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.VegetationMask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies
{
  [ExecuteInEditMode]
  public class VegetationMask : MonoBehaviour
  {
    public bool RemoveGrass;
    public bool RemovePlants;
    public bool RemoveTrees;
    public bool RemoveObjects;
    public bool RemoveLargeObjects;
    public float AdditionalGrassPerimiter;
    public float AdditionalPlantPerimiter;
    public float AdditionalTreePerimiter;
    public float AdditionalObjectPerimiter;
    public float AdditionalLargeObjectPerimiter;
    public float AdditionalGrassPerimiterMax;
    public float AdditionalPlantPerimiterMax;
    public float AdditionalTreePerimiterMax;
    public float AdditionalObjectPerimiterMax;
    public float AdditionalLargeObjectPerimiterMax;
    public float NoiseScaleGrass;
    public float NoiseScalePlant;
    public float NoiseScaleTree;
    public float NoiseScaleObject;
    public float NoiseScaleLargeObject;
    public string Id;
    public bool IncludeVegetationType;
    public List<Node> Nodes;
    public bool ClosedArea;
    public bool ShowArea;
    public bool ShowHandles;
    public string MaskName;
    public LayerMask GroundLayerMask;
    public List<VegetationTypeSettings> VegetationTypeList;
    private Vector3 _lastPosition;
    private Quaternion _lastRotation;
    private bool _needInit;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddVegetationTypes(BaseMaskArea maskArea) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateDefaultNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PositionNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetWorldSpaceNodePositions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateVegetationMask() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DeleteNode(Node node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodesToEnd(Vector3[] worldPositions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodesToEnd(Vector3[] worldPositions, float[] customWidth, bool[] active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodeToEnd(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNodeToEnd(Vector3 worldPosition, float customWidth, bool active) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNode(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNodeIndex(Node node) => throw null;

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
    private Vector3 GetMaskCenter() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Vector3 GetMeanVector(Vector3[] positions) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationMask() => throw null;
  }
}
