// Decompiled with JetBrains decompiler
// Type: BVH_.BVHNode
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BVH_
{
  public class BVHNode
  {
    public BVHBox mBox;
    public BVHNode mParent;
    public BVHNode mLeft;
    public BVHNode mRight;
    public int mDepth;
    public int mNodeNumber;
    public List<BVHBox> mObjects;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Axis PickSplitAxis() => throw null;

    public bool IsLeaf
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Axis NextAxis(Axis Cur) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refit_ObjectChanged(BVHNodeAdaptor adaptor, BVHBox obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExpandVolume(BVHNodeAdaptor adaptor, Vector3 ObjectPos, float Radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AssignVolume(Vector3 ObjectPos, float Radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ComputeVolume(BVHNodeAdaptor adaptor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool RefitVolume(BVHNodeAdaptor adaptor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static float SA(BVHBox box) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static float SA(ref BVHBox box) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static float SA(BVHNode Node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static float SA(BVHNodeAdaptor adaptor, BVHBox obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static BVHBox AABBofPair(BVHNode Node_A, BVHNode Node_B) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal float SAofPair(BVHNode Node_A, BVHNode Node_B) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal float SAofPair(BVHBox Box_A, BVHBox Box_B) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static BVHBox AABBofOBJ(BVHNodeAdaptor adaptor, BVHBox Obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal float SAofList(BVHNodeAdaptor adaptor, List<BVHBox> list) => throw null;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static List<BVHNode.Rot> EachRot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void TryRotate(BVH bvh) => throw null;

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private static List<Axis> eachAxis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void splitNode(BVHNodeAdaptor nAda) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void splitIfNecessary(BVHNodeAdaptor nAda) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void AddObject(
      BVHNodeAdaptor nAda,
      BVHBox newOb,
      ref BVHBox newObBox,
      float newObSAH)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void AddObject_Pushdown(BVHNodeAdaptor nAda, BVHNode curNode, BVHBox newOb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void AddObject(
      BVHNodeAdaptor nAda,
      BVHNode curNode,
      BVHBox newOb,
      ref BVHBox newObBox,
      float newObSAH)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal int CountBVHNodes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void removeObject(BVHNodeAdaptor nAda, BVHBox newOb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetDepth(BVHNodeAdaptor nAda, int newdepth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void RemoveLeaf(BVHNodeAdaptor nAda, BVHNode removeLeaf) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BVHNode rootNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void FindOverlappingLeaves(
      BVHNodeAdaptor nAda,
      Vector3 origin,
      float radius,
      List<BVHNode> overlapList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void FindOverlappingLeaves(
      BVHNodeAdaptor nAda,
      BVHBox aabb,
      List<BVHNode> overlapList)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BVHBox ToAABB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ChildExpanded(BVHNodeAdaptor nAda, BVHNode child) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void ChildRefit(BVHNodeAdaptor nAda, bool propagate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal static void ChildRefit(BVHNodeAdaptor nAda, BVHNode curNode, bool propagate = true) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BVHNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BVHNode(BVH bvh) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal BVHNode(BVH bvh, List<BVHBox> gobjectlist) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private BVHNode(
      BVH bvh,
      BVHNode lparent,
      List<BVHBox> gobjectlist,
      Axis lastSplitAxis,
      int curdepth)
    {
      throw null;
    }

    internal enum Rot
    {
      NONE,
      L_RL,
      L_RR,
      R_LL,
      R_LR,
      LL_RR,
      LL_RL,
    }

    internal class rotOpt : IComparable<BVHNode.rotOpt>
    {
      public float mSAH;
      public BVHNode.Rot rot;

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal rotOpt(float SAH, BVHNode.Rot rot) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int CompareTo(BVHNode.rotOpt other) => throw null;
    }

    internal class SplitAxisOpt : IComparable<BVHNode.SplitAxisOpt>
    {
      public float SAH;
      public Axis axis;
      public List<BVHBox> left;
      public List<BVHBox> right;

      [MethodImpl(MethodImplOptions.NoInlining)]
      internal SplitAxisOpt(float SAH, Axis axis, List<BVHBox> left, List<BVHBox> right) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public int CompareTo(BVHNode.SplitAxisOpt other) => throw null;
    }
  }
}
