// Decompiled with JetBrains decompiler
// Type: RTG.RightAngTriangle2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class RightAngTriangle2D : Shape2D
  {
    private Vector2 _rightAngleCorner;
    private float _XLength;
    private float _YLength;
    private float _rotationDegrees;
    private TriangleEpsilon _epsilon;

    public Vector2 RightAngleCorner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float XLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float YLength
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

    public static Vector2 ModelRight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector2 ModelUp
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static Vector2 ModelRightAngleCorner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderArea(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void RenderBorder(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Vector2> GetPoints() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ContainsPoint(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Rect GetEncapsulatingRect() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RightAngTriangle2D() => throw null;
  }
}
