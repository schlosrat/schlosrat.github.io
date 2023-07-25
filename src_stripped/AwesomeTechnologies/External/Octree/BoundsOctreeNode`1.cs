// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.Octree.BoundsOctreeNode`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.External.Octree
{
  public class BoundsOctreeNode<T>
  {
    private float looseness;
    private float minSize;
    private float adjLength;
    private Bounds bounds;
    private readonly List<BoundsOctreeNode<T>.OctreeObject> objects;
    private BoundsOctreeNode<T>[] children;
    private Bounds[] childBounds;
    private const int numObjectsAllowed = 8;

    public Vector3 Center
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float BaseLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundsOctreeNode(
      float baseLengthVal,
      float minSizeVal,
      float loosenessVal,
      Vector3 centerVal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Add(T obj, Bounds objBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T obj, Bounds objBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsColliding(ref Bounds checkBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsColliding(ref Ray checkRay, float maxDistance = float.PositiveInfinity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetColliding(ref Bounds checkBounds, List<T> result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetColliding(ref Ray checkRay, List<T> result, float maxDistance = float.PositiveInfinity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetChildren(BoundsOctreeNode<T>[] childOctrees) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bounds GetBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawAllBounds(float depth = 0.0f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawAllObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundsOctreeNode<T> ShrinkIfPossible(float minLength) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetValues(
      float baseLengthVal,
      float minSizeVal,
      float loosenessVal,
      Vector3 centerVal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SubAdd(T obj, Bounds objBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SubRemove(T obj, Bounds objBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Split() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Merge() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool Encapsulates(Bounds outerBounds, Bounds innerBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int BestFitChild(Bounds objBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ShouldMerge() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool HasAnyObjects() => throw null;

    private class OctreeObject
    {
      public T Obj;
      public Bounds Bounds;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public OctreeObject() => throw null;
    }
  }
}
