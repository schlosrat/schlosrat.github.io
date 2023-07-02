// Decompiled with JetBrains decompiler
// Type: RTG.CylinderShape3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class CylinderShape3D : Shape3D
  {
    private Vector3 _baseCenter;
    private float _radius;
    private float _height;
    private Quaternion _rotation;
    private CylinderEpsilon _epsilon;

    public Vector3 BaseCenter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 TopCenter
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

    public float Height
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public CylinderEpsilon Epsilon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float RadiusEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float VertEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 CentralAxis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
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

    public static Vector3 ModelBaseCenter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignCentralAxis(Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderSolid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderWire() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Raycast(Ray ray, out float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsPoint(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetBottomCapExtentPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetTopCapExtentPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AABB GetModelAABB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override AABB GetAABB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CylinderShape3D() => throw null;
  }
}
