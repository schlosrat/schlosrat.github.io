// Decompiled with JetBrains decompiler
// Type: RTG.CircleShape3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class CircleShape3D : Shape3D
  {
    private Vector3 _center;
    private float _radius;
    private Quaternion _rotation;
    private CircleEpsilon _epsilon;
    private Shape3DRaycastMode _raycastMode;

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

    public Quaternion Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Right
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Up
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Look
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Normal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public CircleEpsilon Epsilon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float RadiusEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float ExtrudeEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float WireEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Shape3DRaycastMode RaycastMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static Vector3 ModelRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector3 ModelUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector3 ModelLook
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector3 ModelCenter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector3 ModelNormal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignNormal(Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignRight(Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignUp(Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderSolid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderWire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Raycast(Ray ray, out float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool RaycastWire(Ray ray, out float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsPoint(Vector3 point, bool checkOnPlane) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetExtentPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AABB GetAABB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CircleShape3D() => throw null;
  }
}
