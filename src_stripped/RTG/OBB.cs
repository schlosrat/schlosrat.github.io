// Decompiled with JetBrains decompiler
// Type: RTG.OBB
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public struct OBB
  {
    private Vector3 _size;
    private Vector3 _center;
    private Quaternion _rotation;
    private bool _isValid;

    public bool IsValid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Center
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Size
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Extents
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Matrix4x4 RotationMatrix
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

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB(Vector3 center, Vector3 size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB(Vector3 center, Vector3 size, Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB(Vector3 center, Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB(Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB(Bounds bounds, Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB(AABB aabb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB(AABB aabb, Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB(AABB modelSpaceAABB, Transform worldTransform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OBB(OBB copy) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static OBB GetInvalid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inflate(float amount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Matrix4x4 GetUnitBoxTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetCornerPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetCenterAndCornerPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Encapsulate(OBB otherOBB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetPointFaceNormal(Vector3 pointOnFace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IntersectsOBB(OBB otherOBB) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetClosestPoint(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IntersectsSphere(Sphere sphere) => throw null;
  }
}
