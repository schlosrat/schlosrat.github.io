// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.BVHNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility.BVHTree
{
  public struct BVHNode
  {
    public int IsLeaf;
    public int NodeType;
    public Vector3 Centroid;
    public Vector3 Min;
    public Vector3 Max;
    public int PrimID;
    public int PrimitivesCount;
    public int PrimitivesOffset;
    public int NodeID;
    public int ParentID;
    public int LChildID;
    public int RChildID;
    public int SplitAxis;
    public float SplitValue;
    public int NearNodeID;
    public int FarNodeID;
    public int SplitMethod;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BVHNode CreateBVHNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVHNode(List<BVHTriangle> tris, List<BVHNode> nodes, ref List<BVHTriangle> finalPrims) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Build(
      int nodeID,
      List<BVHTriangle> tris,
      ref List<BVHNode> nodes,
      ref List<BVHTriangle> finalPrims)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetLongestAxisAndValue() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameObject CalculateBBox(List<BVHTriangle> tris) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CompareX(BVHTriangle h1, BVHTriangle h2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CompareY(BVHTriangle h1, BVHTriangle h2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int CompareZ(BVHTriangle h1, BVHTriangle h2) => throw null;
  }
}
