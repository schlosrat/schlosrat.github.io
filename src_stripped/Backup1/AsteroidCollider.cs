// Decompiled with JetBrains decompiler
// Type: AsteroidCollider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AsteroidCollider : MonoBehaviour
{
  private Mesh refMesh;
  private Vector3 center;
  private Transform trf;
  private AsteroidCollider.Chunk[] chunks;
  private List<AsteroidCollider.CompositeSolid> solids;
  private List<AsteroidCollider.MarchStep> marchList;
  private bool setup;
  [SerializeField]
  private bool clustering;
  [SerializeField]
  private bool drawSolids;
  [SerializeField]
  private int marchStepsPerFrame;
  [SerializeField]
  private int meshGensPerFrame;
  [SerializeField]
  private int colliderGensPerFrame;
  private Func<Transform, float> rangefinder;
  private float maxRange;
  private float minRange;
  private float rangeScale;
  private Callback onGenComplete;
  [SerializeField]
  private float minScore;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Setup(
    PAsteroid pa,
    Mesh refMesh,
    Vector3 center,
    Func<Transform, float> rangefinder,
    float maxRange,
    float minRange,
    Callback onGenComplete)
  {
    throw null;
  }

  [ContextMenu("Clear Colliders")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Clear() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateGenRange(float range) => throw null;

  [ContextMenu("Generate")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Generate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator GenCoroutine() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void MarchNext(AsteroidCollider.MarchStep step) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void MarchEdge(AsteroidCollider.Chunk n, AsteroidCollider.MarchStep step) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private AsteroidCollider.TestResult TestEdge(
    AsteroidCollider.Chunk c,
    AsteroidCollider.Chunk n,
    AsteroidCollider.CompositeSolid solid,
    ref float score)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool TestWedge(AsteroidCollider.Chunk n, AsteroidCollider.CompositeSolid solid) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LateUpdate() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Color RandomColor(Vector3 unitVector, float a = 1f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private AsteroidCollider.Chunk[] CreateChunks(Vector3[] verts, int[] triangles, Vector3 center) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LinkChunks(AsteroidCollider.Chunk[] chunks) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AsteroidCollider() => throw null;

  public enum TestResult
  {
    Include,
    Exclude,
    Ignore,
  }

  public class MarchStep
  {
    public AsteroidCollider.CompositeSolid solid;
    public AsteroidCollider.Chunk c;
    public float slopeScore;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MarchStep(AsteroidCollider.CompositeSolid solid, AsteroidCollider.Chunk c, float slope) => throw null;
  }

  public class CompositeSolid
  {
    public List<AsteroidCollider.Chunk> chunks;
    private Vector3[] verts;
    private Vector3[] normals;
    private int[] tris;
    public Color color;
    public Mesh mesh;
    public MeshCollider collider;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompositeSolid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddChunk(AsteroidCollider.Chunk c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveChunk(AsteroidCollider.Chunk c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsChunk(AsteroidCollider.Chunk c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BuildCompositeMesh(Vector3[] srcVerts, Vector3[] srcNormals, Color c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawSolid(Color c, float duration) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateCollider(string name, Transform parent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetSrfRadial() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetSrfCenter() => throw null;
  }

  public class Chunk
  {
    public Vector3 p0;
    public Vector3 p1;
    public Vector3 p2;
    public int i0;
    public int i1;
    public int i2;
    public Vector3 srfCenter;
    public Vector3 srfRadial;
    public Vector3 srfNormal;
    public float radiusSqr;
    public AsteroidCollider.Chunk n01;
    public AsteroidCollider.Chunk n12;
    public AsteroidCollider.Chunk n02;
    public AsteroidCollider.CompositeSolid solid;
    public AsteroidCollider.MarchStep step;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Chunk(int i0, int i1, int i2, Vector3[] verts, Vector3 origin) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSlope(AsteroidCollider.Chunk t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearNeighbours() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SetNeighbour(int eA, int eB, AsteroidCollider.Chunk n) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AsteroidCollider.Chunk GetNeighbour(int i) => throw null;
  }
}
