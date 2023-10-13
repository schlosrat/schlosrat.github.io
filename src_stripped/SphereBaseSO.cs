// Decompiled with JetBrains decompiler
// Type: SphereBaseSO
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SphereBaseSO : ScriptableObject
{
  public int recursionLevel;
  public bool isCompiled;
  [HideInInspector]
  public List<SphereBaseSO.Vertex> verts;
  public int vCount;
  [HideInInspector]
  public List<SphereBaseSO.Triangle> tris;
  public int tCount;
  public int size;
  private Dictionary<long, int> middlePointIndexCache;
  private int index;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Create() => throw null;

  public string SizeString
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateSphere() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int AddVertex(Vector3 p) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int AddVertex(Vector3 p, int subdivision) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private int GetMidPoint(int p1, int p2, int subdivision) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CalculateSize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LinkSphere() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LinkTriangles() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LinkVerts() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void LinkEdges() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public Mesh CreateMesh(float[] vertexLengths, Color[] vertexColors, bool createUV) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private Vector3[] CalculateNormals(Vector3[] verts) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SphereBaseSO() => throw null;

  [Serializable]
  public class Vertex
  {
    public Vector3 position;
    public int subdivision;
    public List<int> triangles;
    public List<int> edges;
    public List<float> edgeLengths;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vertex(Vector3 position, int subdivision) => throw null;
  }

  [Serializable]
  public class Triangle
  {
    public int a;
    public int b;
    public int c;
    public int ab;
    public int bc;
    public int ca;
    public Vector3 midpoint;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Triangle(int a, int b, int c) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasVertex(int v) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool LinkTriangle(SphereBaseSO.Triangle t, int tIndex) => throw null;
  }
}
