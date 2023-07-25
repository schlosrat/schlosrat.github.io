// Decompiled with JetBrains decompiler
// Type: RTG.GizmoPlaneSlider3DLookAndFeel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class GizmoPlaneSlider3DLookAndFeel
  {
    [SerializeField]
    private GizmoPlane3DType _planeType;
    [SerializeField]
    private float _scale;
    [SerializeField]
    private bool _useZoomFactor;
    [SerializeField]
    private float _quadWidth;
    [SerializeField]
    private float _quadHeight;
    [SerializeField]
    private float _raTriangleXLength;
    [SerializeField]
    private float _raTriangleYLength;
    [SerializeField]
    private float _circleRadius;
    [SerializeField]
    private float _borderBoxHeight;
    [SerializeField]
    private float _borderBoxDepth;
    [SerializeField]
    private float _borderTorusThickness;
    [SerializeField]
    private int _numBorderTorusWireAxialSlices;
    [SerializeField]
    private float _borderCylTorusWidth;
    [SerializeField]
    private float _borderCylTorusHeight;
    [SerializeField]
    private GizmoShadeMode _shadeMode;
    [SerializeField]
    private Color _color;
    [SerializeField]
    private Color _hoveredColor;
    [SerializeField]
    private Color _borderColor;
    [SerializeField]
    private Color _hoveredBorderColor;
    [SerializeField]
    private float _borderCircleCullAlphaScale;
    [SerializeField]
    private GizmoShadeMode _borderShadeMode;
    [SerializeField]
    private GizmoFillMode3D _borderFillMode;
    [SerializeField]
    private GizmoQuad3DBorderType _quadBorderType;
    [SerializeField]
    private GizmoRATriangle3DBorderType _raTriangleBorderType;
    [SerializeField]
    private GizmoCircle3DBorderType _circleBorderType;
    [SerializeField]
    private bool _isRotationArcVisible;
    [SerializeField]
    private GizmoRotationArc3DLookAndFeel _rotationArcLookAndFeel;

    public GizmoShadeMode ShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoPlane3DType PlaneType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Scale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool UseZoomFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float QuadWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float QuadHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float RATriangleXLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float RATriangleYLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float CircleRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float BorderCircleCullAlphaScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float BorderBoxHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float BorderBoxDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float BorderTorusThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float BorderCylTorusWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float BorderCylTorusHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int NumBorderTorusWireAxialSlices
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color HoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color BorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color HoveredBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoShadeMode BorderShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoFillMode3D BorderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoQuad3DBorderType QuadBorderType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoCircle3DBorderType CircleBorderType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoRATriangle3DBorderType RATriangleBorderType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsRotationArcVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoRotationArc3DLookAndFeel RotationArcLookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoPlaneSlider3DLookAndFeel() => throw null;
  }
}
