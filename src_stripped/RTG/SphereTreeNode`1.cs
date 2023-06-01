// Decompiled with JetBrains decompiler
// Type: RTG.SphereTreeNode`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class SphereTreeNode<T>
  {
    private SphereTreeNode<T> _stackTop;
    private SphereTreeNode<T> _stackPrevious;
    private Sphere _sphere;
    private T _data;
    private SphereTreeNode<T> _parent;
    private SphereTreeNode<T>[] _children;
    private int _numChildren;

    public SphereTreeNode<T>[] Children
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumChildren
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsLeaf
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphereTreeNode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphereTreeNode(T data, Sphere sphere) => throw null;

    public Sphere Sphere
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Center
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Radius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SphereTreeNode<T> Parent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public T Data
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public SphereTreeNode<T> StackTop
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StackPush(SphereTreeNode<T> node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphereTreeNode<T> StackPop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsOutsideParent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphereTreeNode<T> ClosestChild(SphereTreeNode<T> node) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParent(SphereTreeNode<T> newParent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EncapsulateChildrenBottomUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugDraw() => throw null;
  }
}
