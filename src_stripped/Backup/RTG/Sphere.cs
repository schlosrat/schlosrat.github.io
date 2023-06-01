// Decompiled with JetBrains decompiler
// Type: RTG.Sphere
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public struct Sphere
  {
    private Vector3 _center;
    private float _radius;

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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Sphere(Vector3 center, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Sphere(AABB aabb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Sphere(IEnumerable<Vector3> pointCloud) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsPoint(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetRightUpExtents(Vector3 right, Vector3 up) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Encapsulate(Sphere sphere) => throw null;
  }
}
