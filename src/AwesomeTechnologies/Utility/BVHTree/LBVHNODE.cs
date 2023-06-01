// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.LBVHNODE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using AwesomeTechnologies.MeshTerrains;
using System;
using System.Runtime.CompilerServices;
using Unity.Mathematics;

namespace AwesomeTechnologies.Utility.BVHTree
{
  [Serializable]
  public struct LBVHNODE
  {
    public float3 BMin;
    public float3 BMax;
    public int NodeID;
    public int PrimitivesCount;
    public int PrimitivesOffset;
    public int ParentID;
    public int LChildID;
    public int RChildID;
    public int IsLeaf;
    public int NearNodeID;
    public int FarNodeID;
    public int SplitAxis;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LBVHNODE(BVHNode node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetChildrenIDsAndSplitAxis(out int lChildID, out int rChildID, out int splitAxis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IntersectRay(BVHRay r) => throw null;
  }
}
