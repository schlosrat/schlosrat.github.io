// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.BVH
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility.BVHTree
{
  public class BVH
  {
    public static int MaxPrimsCountPerNode;
    public static BVHNode Bvh;
    public static List<ObjectData> Objects;
    public static float Progress;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Build(
      ref List<ObjectData> allObjects,
      out List<BVHNode> nodes,
      out List<BVHTriangle> tris,
      out List<BVHTriangle> finalPrims)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void BuildLbvhData(
      List<BVHNode> nodes,
      List<BVHTriangle> prims,
      out List<LBVHNODE> lNodes,
      out List<LBVHTriangle> lPrims)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool OverlapBbox(Vector3 aMin, Vector3 aMax, Vector3 bMin, Vector3 bMax) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CalculateCellSize(
      int nodeID,
      List<LBVHNODE> nodes,
      ref Vector3 cellMinExtended,
      ref Vector3 cellMaxExtended,
      ref Vector3 cellMin,
      ref Vector3 cellMax)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVH() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static BVH() => throw null;
  }
}
