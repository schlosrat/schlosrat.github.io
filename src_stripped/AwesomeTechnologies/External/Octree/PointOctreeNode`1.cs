// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.Octree.PointOctreeNode`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.External.Octree
{
  public class PointOctreeNode<T> where T : class
  {
    private float minSize;
    private Bounds bounds;
    private readonly List<PointOctreeNode<T>.OctreeObject> objects;
    private PointOctreeNode<T>[] children;
    private Bounds[] childBounds;
    private const int NUM_OBJECTS_ALLOWED = 8;
    private Vector3 actualBoundsSize;

    public Vector3 Center
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public float SideLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointOctreeNode(float baseLengthVal, float minSizeVal, Vector3 centerVal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Add(T obj, Vector3 objPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T obj, Vector3 objPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetNearby(ref Ray ray, ref float maxDistance, List<T> result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetNearby(ref Vector3 position, ref float maxDistance, List<T> result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetAll(List<T> result) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetChildren(PointOctreeNode<T>[] childOctrees) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawAllBounds(float depth = 0.0f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DrawAllObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointOctreeNode<T> ShrinkIfPossible(float minLength) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetValues(float baseLengthVal, float minSizeVal, Vector3 centerVal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SubAdd(T obj, Vector3 objPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool SubRemove(T obj, Vector3 objPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Split() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Merge() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool Encapsulates(Bounds outerBounds, Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int BestFitChild(Vector3 objPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool ShouldMerge() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool HasAnyObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static float SqrDistanceToRay(Ray ray, Vector3 point) => throw null;

    private class OctreeObject
    {
      public T Obj;
      public Vector3 Pos;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public OctreeObject() => throw null;
    }
  }
}
