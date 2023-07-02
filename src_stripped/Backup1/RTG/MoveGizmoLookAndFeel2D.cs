// Decompiled with JetBrains decompiler
// Type: RTG.MoveGizmoLookAndFeel2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class MoveGizmoLookAndFeel2D : Settings
  {
    [SerializeField]
    private GizmoPlaneSlider2DLookAndFeel _dblSliderLookAndFeel;
    [SerializeField]
    private GizmoLineSlider2DLookAndFeel[] _sglSliderLookAndFeel;
    [SerializeField]
    private bool _isDblSliderVisible;
    [SerializeField]
    private bool[] _sglSliderVis;
    [SerializeField]
    private bool[] _sglSliderCapVis;

    public float Scale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float BoxSliderThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderArrowCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderArrowCapBaseRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderQuadCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderQuadCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderCircleCapRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float DblSliderQuadWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float DblSliderQuadHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float DblSliderCircleRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color XColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color YColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color XBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color YBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color DblSliderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color DblSliderBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color DblSliderHoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color DblSliderHoveredBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDblSliderVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color SliderHoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color SliderHoveredBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode2D SliderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode2D SliderCapFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode2D DblSliderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap2DType SliderCapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLine2DType SliderLineType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoPlane2DType DblSliderPlaneType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoveGizmoLookAndFeel2D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDblSliderPlaneTypeAllowed(GizmoPlane2DType planeType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Enum> GetAllowedDblSliderPlaneTypes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSliderVisible(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPositiveSliderVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsNegativeSliderVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPositiveSliderCapVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsNegativeSliderCapVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisColor(int axisIndex, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisBorderColor(int axisIndex, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderHoveredFillColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderHoveredBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderFillMode(GizmoFillMode2D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderFillMode(GizmoFillMode2D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderCapFillMode(GizmoFillMode2D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderLineType(GizmoLine2DType lineType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBoxSliderThickness(float thickness) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderLength(float length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderCapType(GizmoCap2DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderArrowCapBaseRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderArrowCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderQuadCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderQuadCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderCircleCapRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderPlaneType(GizmoPlane2DType sliderType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderQuadWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderQuadHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderCircleRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderHoveredColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderHoveredBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectSliderLookAndFeel(
      GizmoLineSlider2D slider,
      int axisIndex,
      AxisSign axisSign)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider2D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoLineSlider2DLookAndFeel GetSliderLookAndFeel(int axisIndex, AxisSign axisSign) => throw null;
  }
}
