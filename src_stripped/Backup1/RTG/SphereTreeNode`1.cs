// Decompiled with JetBrains decompiler
// Type: RTG.SphereTreeNode`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
