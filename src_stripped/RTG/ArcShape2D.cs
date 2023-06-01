// Decompiled with JetBrains decompiler
// Type: RTG.ArcShape2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class ArcShape2D : Shape2D
  {
    private ArcShape2D.BorderRenderDescriptor _borderRenderDesc;
    private Rect _rect;
    private bool _forceShortestArc;
    private float _radius;
    private Vector2 _origin;
    private Vector2 _startPoint;
    private Vector2 _endPoint;
    private List<Vector2> _borderPoints;
    private float _degreeAngleFromStart;
    private int _numBorderPoints;
    private bool _areBorderPointsDirty;
    private ArcEpsilon _epsilon;

    public float Radius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool ForceShortestArc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float DegreeAngleFromStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float AbsDegreeAngleFromStart
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 Origin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int NumBorderPoints
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2 StartPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 EndPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ArcEpsilon Epsilon
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float AreaEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ArcShape2D.BorderRenderDescriptor BorderRenderDesc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderArea(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderBorder(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetArcData(Vector2 startPoint, float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Rect GetEncapsulatingRect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ContainsPoint(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnBorderPointsFoundDirty() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CalculateEndPoint() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArcShape2D() => throw null;

    public enum BorderRenderFlags
    {
      None,
      ExtremitiesBorder,
      ArcBorder,
      All,
    }

    public class BorderRenderDescriptor
    {
      private ArcShape2D.BorderRenderFlags _borderFlags;

      public ArcShape2D.BorderRenderFlags BorderFlags
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BorderRenderDescriptor() => throw null;
    }
  }
}
