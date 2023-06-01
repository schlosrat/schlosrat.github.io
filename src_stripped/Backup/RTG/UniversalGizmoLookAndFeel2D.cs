// Decompiled with JetBrains decompiler
// Type: RTG.UniversalGizmoLookAndFeel2D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class UniversalGizmoLookAndFeel2D : Settings
  {
    [SerializeField]
    private UniversalGizmoSettingsCategory _displayCategory;
    [SerializeField]
    private GizmoPlaneSlider2DLookAndFeel _mvDblSliderLookAndFeel;
    [SerializeField]
    private GizmoLineSlider2DLookAndFeel[] _mvSglSliderLookAndFeel;
    [SerializeField]
    private bool _isMvDblSliderVisible;
    [SerializeField]
    private bool[] _mvSglSliderVis;
    [SerializeField]
    private bool[] _mvSglSliderCapVis;

    public float MvScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvBoxSliderThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderArrowCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderArrowCapBaseRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderQuadCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderQuadCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderCircleCapRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvDblSliderQuadWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvDblSliderQuadHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvDblSliderCircleRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvXColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvYColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvXBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvYBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvDblSliderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvDblSliderBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvDblSliderHoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvDblSliderHoveredBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMvDblSliderVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvSliderHoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvSliderHoveredBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode2D MvSliderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode2D MvSliderCapFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode2D MvDblSliderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap2DType MvSliderCapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLine2DType MvSliderLineType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoPlane2DType MvDblSliderPlaneType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoSettingsCategory DisplayCategory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniversalGizmoLookAndFeel2D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvSliderVisible(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvPositiveSliderVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvNegativeSliderVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvSliderCapVisible(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvPositiveSliderCapVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvNegativeSliderCapVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvAxisColor(int axisIndex, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvAxisBorderColor(int axisIndex, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderHoveredFillColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderHoveredBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderFillMode(GizmoFillMode2D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderFillMode(GizmoFillMode2D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderCapFillMode(GizmoFillMode2D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderLineType(GizmoLine2DType lineType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvBoxSliderThickness(float thickness) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderLength(float length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderCapType(GizmoCap2DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderArrowCapBaseRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderArrowCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderQuadCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderQuadCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderCircleCapRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderPlaneType(GizmoPlane2DType sliderType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderQuadWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderQuadHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderCircleRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderHoveredColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderHoveredBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMvSliderLookAndFeel(
      GizmoLineSlider2D slider,
      int axisIndex,
      AxisSign axisSign)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMvDblSliderLookAndFeel(GizmoPlaneSlider2D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inherit(MoveGizmoLookAndFeel2D lookAndFeel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoLineSlider2DLookAndFeel GetMvSliderLookAndFeel(int axisIndex, AxisSign axisSign) => throw null;
  }
}
