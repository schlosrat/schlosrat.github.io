// Decompiled with JetBrains decompiler
// Type: RTG.SphereTreeNodeRayHit`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class SphereTreeNodeRayHit<T>
  {
    private SphereTreeNode<T> _hitNode;
    private Vector3 _hitPoint;
    private float _hitEnter;

    public SphereTreeNode<T> HitNode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 HitPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float HitEnter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SphereTreeNodeRayHit(Ray ray, SphereTreeNode<T> hitNode, float hitEnter) => throw null;
  }
}
