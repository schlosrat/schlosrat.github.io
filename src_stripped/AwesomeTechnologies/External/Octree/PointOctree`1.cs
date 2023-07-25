// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.External.Octree.PointOctree`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.External.Octree
{
  public class PointOctree<T> where T : class
  {
    private PointOctreeNode<T> rootNode;
    private readonly float initialSize;
    private readonly float minSize;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointOctree(float initialWorldSize, Vector3 initialWorldPos, float minNodeSize) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(T obj, Vector3 objPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T obj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Remove(T obj, Vector3 objPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetNearbyNonAlloc(Ray ray, float maxDistance, List<T> nearBy) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T[] GetNearby(Ray ray, float maxDistance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T[] GetNearby(Vector3 position, float maxDistance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ICollection<T> GetAll() => throw null;

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
