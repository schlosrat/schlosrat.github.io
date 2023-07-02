// Decompiled with JetBrains decompiler
// Type: RTG.ScaleGizmoLookAndFeel3D
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
  public class ScaleGizmoLookAndFeel3D : Settings
  {
    [SerializeField]
    private GizmoCap3DLookAndFeel _midCapLookAndFeel;
    [SerializeField]
    private bool[] _sglSliderVis;
    [SerializeField]
    private bool[] _sglSliderCapVis;
    [SerializeField]
    private bool[] _dblSliderVis;
    [SerializeField]
    private GizmoScaleGuideLookAndFeel _scaleGuideLookAndFeel;
    [SerializeField]
    private bool _isScaleGuideVisible;
    [SerializeField]
    private GizmoLineSlider3DLookAndFeel[] _sglSlidersLookAndFeel;
    [SerializeField]
    private GizmoPlaneSlider3DLookAndFeel[] _dblSlidersLookAndFeel;

    public float Scale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool UseZoomFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float BoxSliderHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float BoxSliderDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CylinderSliderRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderBoxCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderBoxCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderBoxCapDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderConeCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderConeCapBaseRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderPyramidCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderPyramidCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderPyramidCapDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderTriPrismCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderTriPrismCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderTriPrismCapDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float SliderSphereCapRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D SliderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D SliderCapFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap3DType SliderCapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode SliderShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode SliderCapShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLine3DType SliderLineType
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

    public Color ZColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float DblSliderSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float DblSliderFillAlpha
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MidCapBoxWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MidCapBoxHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MidCapBoxDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MidCapSphereRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap3DType MidCapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode MidCapShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D MidCapFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MidCapColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color HoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsScaleGuideVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScaleGuideAxisLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaleGizmoLookAndFeel3D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScaleGuideVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDblSliderVisible(PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderVisible(PlaneId planeId, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSliderVisible(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsSliderCapVisible(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPositiveSliderVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsPositiveSliderCapVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsNegativeSliderVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsNegativeSliderCapVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPositiveSliderVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPositiveCapVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNegativeSliderVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNegativeCapVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderLength(float axisLength) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderLineType(GizmoLine3DType lineType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBoxSliderHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBoxSliderDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCylinderSliderRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUseZoomFactor(bool useZoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScaleGuideAxisLength(float length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisColor(int axisIndex, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderFillAlpha(float alpha) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoveredColor(Color hoveredColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderCapShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderCapType(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapType(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMidCapTypeAllowed(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Enum> GetAllowedMidCapTypes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderCapFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderBoxCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderBoxCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderBoxCapDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderConeCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderConeCapBaseRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderPyramidCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderPyramidCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderPyramidCapDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderTriPrismCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderTriPrismCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderTriPrismCapDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSliderSphereCapRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapBoxWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapBoxHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapBoxDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapSphereRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDblSliderSize(float size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectSliderLookAndFeel(
      GizmoLineSlider3D slider,
      int axisIndex,
      AxisSign axisSign)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMidCapLookAndFeel(GizmoCap3D cap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoLineSlider3DLookAndFeel GetSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoPlaneSlider3DLookAndFeel GetDblSliderLookAndFeel(PlaneId planeId) => throw null;
  }
}
