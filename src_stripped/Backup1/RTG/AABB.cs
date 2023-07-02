// Decompiled with JetBrains decompiler
// Type: RTG.AABB
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public struct AABB
  {
    private Vector3 _size;
    private Vector3 _center;
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

    public Vector3 Min
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 Max
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AABB(Vector3 center, Vector3 size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AABB(Bounds bounds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AABB(IEnumerable<Vector3> pointCloud) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AABB(IEnumerable<Vector2> pointCloud) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static AABB GetInvalid() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inflate(float amount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inflate(Vector3 amount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Encapsulate(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Encapsulate(IEnumerable<Vector3> points) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Encapsulate(AABB aabb) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Transform(Matrix4x4 transformMatrix) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsPoint(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetCornerPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector3> GetCenterAndCornerPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector2> GetScreenCornerPoints(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector2> GetScreenCenterAndCornerPoints(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Rect GetScreenRectangle(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Matrix4x4 GetUnitBoxTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Bounds ToBounds() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecalculateCenterAndSize(Vector3 min, Vector3 max) => throw null;
  }
}
