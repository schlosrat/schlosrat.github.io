// Decompiled with JetBrains decompiler
// Type: RTG.Sphere
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
