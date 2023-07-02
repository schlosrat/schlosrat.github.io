// Decompiled with JetBrains decompiler
// Type: RTG.MeshRayHit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class MeshRayHit
  {
    private int _hitTriangleIndex;
    private Vector3 _hitPoint;
    private float _hitEnter;
    private Vector3 _hitNormal;

    public int HitTriangleIndex
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

    public Vector3 HitNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MeshRayHit(Ray ray, int hitTriangleIndex, float hitEnter, Vector3 hitNormal) => throw null;
  }
}
