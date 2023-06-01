// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.Octree.BoundsOctree`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.External.Octree
{
  public class BoundsOctree<T>
  {
    private BoundsOctreeNode<T> rootNode;
    private readonly float looseness;
    private readonly float initialSize;
    private readonly float minSize;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundsOctree(
      float initialWorldSize,
      Vector3 initialWorldPos,
      float minNodeSize,
      float loosenessVal)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(T obj, Bounds objBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T obj, Bounds objBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsColliding(Bounds checkBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsColliding(Ray checkRay, float maxDistance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetColliding(List<T> collidingWith, Bounds checkBounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetColliding(List<T> collidingWith, Ray checkRay, float maxDistance = float.PositiveInfinity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bounds GetMaxBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawAllBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawAllObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Grow(Vector3 direction) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Shrink() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int GetRootPosIndex(int xDir, int yDir, int zDir) => throw null;
  }
}
