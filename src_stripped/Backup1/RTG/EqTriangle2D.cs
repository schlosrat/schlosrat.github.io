// Decompiled with JetBrains decompiler
// Type: RTG.EqTriangle2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class EqTriangle2D : Shape2D
  {
    private float _sideLength;
    private float _rotationDegrees;
    private TriangleEpsilon _epsilon;
    private Vector2[] _points;
    private Vector2 _centroid;
    private bool _arePointsDirty;

    public float SideLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2 Centroid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Altitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CentroidAltitude
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RotationDegrees
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion Rotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public TriangleEpsilon Epsilon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float AreaEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2 Right
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 Up
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector2 ModelRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector2 ModelUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector2 ModelCentroid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetPoint(EqTrianglePoint point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPoint(EqTrianglePoint point, Vector2 pointValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetEdgeMidPoint(EqTriangleEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetEdge(EqTriangleEdge edge) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderArea(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderBorder(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ContainsPoint(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Rect GetEncapsulatingRect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPointsFoundDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EqTriangle2D() => throw null;
  }
}
