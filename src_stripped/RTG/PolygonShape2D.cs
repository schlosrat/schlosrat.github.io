// Decompiled with JetBrains decompiler
// Type: RTG.PolygonShape2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class PolygonShape2D : Shape2D
  {
    private Rect _rect;
    private bool _isRectDirty;
    private bool _isClosed;
    private List<Vector2> _cwPolyPoints;
    private List<Vector2> _thickCwBorderPoints;
    private bool _isThickBorderDirty;
    private PolygonEpsilon _epsilon;
    private Shape2DPtContainMode _ptContainMode;
    private PolygonShape2D.BorderRenderDescriptor _borderRenderDesc;

    public int NumPoints
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PolygonEpsilon Epsilon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float AreaEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float WireEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float ThickWireEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsClosed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Shape2DPtContainMode PtContainMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PolygonShape2D.BorderRenderDescriptor BorderRenderDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetExtentPoint(Shape2DExtentPoint extentPt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderArea(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderBorder(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector2> GetPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Rect GetEncapsulatingRect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyPoints(PolygonShape2D sourcePoly) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetClockwisePoints(List<Vector2> cwBorderPoints, bool isClosed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeSphereBorder(
      Vector3 sphereCenter,
      float sphereRadius,
      int numPoints,
      Camera camera)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ContainsPoint(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateRect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateThickBorderPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PolygonShape2D() => throw null;

    public enum ThickBorderFillMode
    {
      Filled,
      Border,
    }

    public class BorderRenderDescriptor
    {
      private Shape2DBorderType _borderType;
      private float _thickness;
      private Shape2DBorderDirection _direction;
      private PolygonShape2D.ThickBorderFillMode _fillMode;

      public Shape2DBorderType BorderType
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public float Thickness
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Shape2DBorderDirection Direction
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public PolygonShape2D.ThickBorderFillMode FillMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BorderRenderDescriptor() => throw null;
    }
  }
}
