// Decompiled with JetBrains decompiler
// Type: BVH_.BVH
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BVH_
{
  public class BVH
  {
    public BVHNode mRootBVH;
    public BVHNodeAdaptor mAdaptor;
    public readonly int LEAF_OBJ_MAX;
    public int mNodeCount;
    public int mMaxDepth;
    public HashSet<BVHNode> mRefitNodes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void _Traverse(BVHNode CurNode, BVH.NodeTest HitTest, List<BVHNode> Hitlist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<BVHNode> Traverse(BVH.NodeTest HitTest) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<BVHNode> Traverse(BVHBox box) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Optimize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddObjects(BVHBox obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveObject(BVHBox newObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int countBVHNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BVH(BVHNodeAdaptor nodeAdaptor, List<BVHBox> objects, int LEAF_OBJ_MAX = 1) => throw null;

    public delegate bool NodeTest(BVHBox Box);
  }
}
