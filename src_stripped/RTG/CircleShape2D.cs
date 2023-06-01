// Decompiled with JetBrains decompiler
// Type: RTG.CircleShape2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class CircleShape2D : Shape2D
  {
    private Vector2 _center;
    private float _radius;
    private float _rotationDegrees;
    private int _numBorderPoints;
    private List<Vector2> _modelBorderPoints;
    private bool _areModelBorderPointsDirty;
    private CircleEpsilon _epsilon;
    private Shape2DPtContainMode _ptContainMode;

    public Vector2 Center
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Radius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float RotationDegrees
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

    public float WireEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int NumBorderPoints
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Shape2DPtContainMode PtContainMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static Vector2 ModelRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector2 ModelUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector2 ModelCenter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderBorder(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderArea(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ContainsPoint(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector2> GetExtentPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Rect GetEncapsulatingRect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalcModelBorderPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CircleShape2D() => throw null;
  }
}
