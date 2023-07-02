// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Utility.Quadtree.QuadTree`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace AwesomeTechnologies.Utility.Quadtree
{
  public class QuadTree<T> where T : IHasRect
  {
    private readonly QuadTreeNode<T> _root;
    private Rect _rect;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public QuadTree(Rect rect) => throw null;

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Insert(T item) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Move(Vector2 offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Query(Rect area, List<T> results) => throw null;
  }
}
