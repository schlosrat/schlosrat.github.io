// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.BVHTree.LBVHNODE
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
