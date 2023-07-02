// Decompiled with JetBrains decompiler
// Type: RTG.SphereTree`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class SphereTree<T>
  {
    private SphereTreeNode<T> _root;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphereTree() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugDraw() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphereTreeNode<T> AddNode(T nodeData, Sphere sphere) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveNode(SphereTreeNode<T> node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnNodeSphereUpdated(SphereTreeNode<T> node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RaycastAll(Ray ray, List<SphereTreeNodeRayHit<T>> hits) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OverlapBox(OBB box, List<SphereTreeNode<T>> nodes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InsertNode(SphereTreeNode<T> node) => throw null;
  }
}
