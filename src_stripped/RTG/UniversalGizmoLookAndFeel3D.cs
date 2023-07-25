// Decompiled with JetBrains decompiler
// Type: RTG.UniversalGizmoLookAndFeel3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class UniversalGizmoLookAndFeel3D : Settings
  {
    [SerializeField]
    private UniversalGizmoSettingsCategory _displayCategory;
    [SerializeField]
    private GizmoCap2DLookAndFeel _mvVertSnapCapLookAndFeel;
    [SerializeField]
    private bool[] _mvSglSliderVis;
    [SerializeField]
    private bool[] _mvSglSliderCapVis;
    [SerializeField]
    private bool[] _mvDblSliderVis;
    [SerializeField]
    private GizmoLineSlider3DLookAndFeel[] _mvSglSlidersLookAndFeel;
    [SerializeField]
    private GizmoPlaneSlider3DLookAndFeel[] _mvDblSlidersLookAndFeel;
    [SerializeField]
    private bool _isRtMidCapVisible;
    [SerializeField]
    private GizmoCap3DLookAndFeel _rtMidCapLookAndFeel;
    [SerializeField]
    private bool[] _rtAxesVis;
    [SerializeField]
    private GizmoPlaneSlider3DLookAndFeel[] _rtAxesLookAndFeel;
    [SerializeField]
    private bool _isRtCamLookSliderVisible;
    [SerializeField]
    private float _rtCamLookSliderRadiusOffset;
    [SerializeField]
    private GizmoPlaneSlider2DLookAndFeel _rtCamLookSliderLookAndFeel;
    [SerializeField]
    private GizmoCap3DLookAndFeel _scMidCapLookAndFeel;
    [SerializeField]
    private bool[] _scSglSliderVis;
    [SerializeField]
    private bool[] _scSglSliderCapVis;
    [SerializeField]
    private bool[] _scDblSliderVis;
    [SerializeField]
    private bool _isScMidCapVisible;
    [SerializeField]
    private GizmoScaleGuideLookAndFeel _scScaleGuideLookAndFeel;
    [SerializeField]
    private bool _isScScaleGuideVisible;
    [SerializeField]
    private GizmoLineSlider3DLookAndFeel[] _scSglSlidersLookAndFeel;
    [SerializeField]
    private GizmoPlaneSlider3DLookAndFeel[] _scDblSlidersLookAndFeel;

    public float MvScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool MvUseZoomFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvBoxSliderHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvBoxSliderDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvCylinderSliderRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderBoxCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderBoxCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderBoxCapDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderConeCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderConeCapBaseRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderPyramidCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderPyramidCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderPyramidCapDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderTriPrismCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderTriPrismCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderTriPrismCapDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvSliderSphereCapRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D MvSliderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D MvSliderCapFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap3DType MvSliderCapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode MvSliderShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode MvSliderCapShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLine3DType MvSliderLineType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvPXColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvNXColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvPYColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvNYColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvPZColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvNZColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvDblSliderSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvDblSliderBorderBoxHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvDblSliderBorderBoxDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvDblSliderFillAlpha
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode MvDblSliderBorderShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoQuad3DBorderType MvDblSliderBorderType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D MvDblSliderBorderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvVertSnapCapQuadWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvVertSnapCapQuadHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvVertSnapCapCircleRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvVertSnapCapColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvVertSnapCapBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvVertSnapCapHoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvVertSnapCapHoveredBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode2D MvVertSnapCapFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap2DType MvVertSnapCapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MvHoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool RtUseZoomFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RtXBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RtYBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RtZBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RtHoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtAxisTorusThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtAxisCylTorusWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtAxisCylTorusHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtAxisCullAlphaScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode RtShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCircle3DBorderType RtAxisBorderType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D RtAxisBorderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int RtNumAxisTorusWireAxialSlices
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RtRotationArcColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RtRotationArcBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool RtUseShortestRotationArc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsRtRotationArcVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RtMidCapColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RtHoveredMidCapColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsRtMidCapVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsRtMidCapBorderVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtCamLookSliderRadiusOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RtCamLookSliderBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RtCamLookSliderHoveredBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoPolygon2DBorderType RtCamLookSliderPolyBorderType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtCamLookSliderPolyBorderThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsRtCamLookSliderVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool ScUseZoomFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScBoxSliderHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScBoxSliderDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScCylinderSliderRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderBoxCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderBoxCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderBoxCapDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderConeCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderConeCapBaseRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderPyramidCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderPyramidCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderPyramidCapDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderTriPrismCapWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderTriPrismCapHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderTriPrismCapDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScSliderSphereCapRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D ScSliderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D ScSliderCapFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap3DType ScSliderCapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode ScSliderShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode ScSliderCapShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoLine3DType ScSliderLineType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color ScPXColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color ScNXColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color ScPYColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color ScNYColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color ScPZColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color ScNZColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScDblSliderSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScDblSliderFillAlpha
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScMidCapBoxWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScMidCapBoxHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScMidCapBoxDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScMidCapSphereRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap3DType ScMidCapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode ScMidCapShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D ScMidCapFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsScMidCapVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color ScMidCapColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color ScHoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsScScaleGuideVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScScaleGuideAxisLength
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoSettingsCategory DisplayCategory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniversalGizmoLookAndFeel3D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvVertSnapCapTypeAllowed(GizmoCap2DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Enum> GetAllowedMvVertSnapCapTypes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertSnapCapType(GizmoCap2DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertSnapCapQuadWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertSnapCapQuadHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertSnapCapCircleRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertSnapCapFillMode(GizmoFillMode2D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertSnapCapColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertSnapCapBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertSnapCapHoveredColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertSnapCapHoveredBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvSliderVisible(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvDblSliderVisible(PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvSliderCapVisible(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvPositiveSliderVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvPositiveSliderCapVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvNegativeSliderVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMvNegativeSliderCapVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderVisible(PlaneId planeId, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvPositiveSliderVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvPositiveSliderCapVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvNegativeSliderVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvNegativeSliderCapVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderLength(float axisLength) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderLineType(GizmoLine3DType lineType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderBorderType(GizmoQuad3DBorderType borderType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderBorderBoxHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderBorderBoxDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvBoxSliderHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvBoxSliderDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvCylinderSliderRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderSize(float size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvUseZoomFactor(bool useZoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvAxisColor(int axisIndex, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderFillAlpha(float alpha) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvHoveredColor(Color hoveredColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderCapShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderBorderShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderCapType(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderCapFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDblSliderBorderFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderBoxCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderBoxCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderBoxCapDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderConeCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderConeCapBaseRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderPyramidCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderPyramidCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderPyramidCapDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderTriPrismCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderTriPrismCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderTriPrismCapDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvSliderSphereCapRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMvSliderLookAndFeel(
      GizmoLineSlider3D slider,
      int axisIndex,
      AxisSign axisSign)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMvDblSliderLookAndFeel(GizmoPlaneSlider3D dblSlider, PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMvVertSnapCapLookAndFeel(GizmoCap2D vertSnapCap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inherit(MoveGizmoLookAndFeel3D lookAndFeel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoLineSlider3DLookAndFeel GetMvSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoPlaneSlider3DLookAndFeel GetMvDblSliderLookAndFeel(PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRtAxisVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisBorderFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtNumAxisTorusWireAxialSlices(int numSlices) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtUseZoomFactor(bool useZoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisBorderCullAlphaScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisBorderType(GizmoCircle3DBorderType borderType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisTorusThickness(float thickness) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisCylTorusWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisCylTorusHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtMidCapVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtMidCapColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtHoveredMidCapColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtMidCapBorderVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtMidCapBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisBorderColor(int axisIndex, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtHoveredColor(Color hoveredColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtRotationArcColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtRotationArcBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtUseShortestRotationArc(bool useShortest) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtRotationArcVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamLookSliderRadiusOffset(float offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamLookSliderBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamLookSliderHoveredBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamLookSliderVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamLookSliderPolyBorderThickness(float thickness) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectRtSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectRtMidCapLookAndFeel(GizmoCap3D cap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectRtCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inherit(RotationGizmoLookAndFeel3D lookAndFeel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScScaleGuideVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScDblSliderVisible(PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScDblSliderVisible(PlaneId planeId, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScSliderVisible(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScSliderCapVisible(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScPositiveSliderVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScPositiveSliderCapVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScNegativeSliderVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScNegativeSliderCapVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderVisible(int axisIndex, AxisSign axisSign, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderCapVisible(int axisIndex, AxisSign axisSign, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScPositiveSliderVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScPositiveSliderCapVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScNegativeSliderVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScNegativeSliderCapVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderLength(float axisLength) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderLineType(GizmoLine3DType lineType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScBoxSliderHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScBoxSliderDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScCylinderSliderRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScUseZoomFactor(bool useZoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScScaleGuideAxisLength(float length) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScAxisColor(int axisIndex, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScDblSliderFillAlpha(float alpha) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScMidCapColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScMidCapVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScHoveredColor(Color hoveredColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderCapShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScMidCapShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderCapType(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScMidCapType(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScMidCapTypeAllowed(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Enum> GetAllowedScMidCapTypes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderCapFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScMidCapFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderBoxCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderBoxCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderBoxCapDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderConeCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderConeCapBaseRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderPyramidCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderPyramidCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderPyramidCapDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderTriPrismCapWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderTriPrismCapHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderTriPrismCapDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScSliderSphereCapRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScMidCapBoxWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScMidCapBoxHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScMidCapBoxDepth(float depth) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScMidCapSphereRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScDblSliderSize(float size) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectScSliderLookAndFeel(
      GizmoLineSlider3D slider,
      int axisIndex,
      AxisSign axisSign)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectScMidCapLookAndFeel(GizmoCap3D cap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectScDblSliderLookAndFeel(GizmoPlaneSlider3D slider, PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectScGizmoScaleGuideLookAndFeel(GizmoScaleGuide scaleGuide) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inherit(ScaleGizmoLookAndFeel3D lookAndFeel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoLineSlider3DLookAndFeel GetScSglSliderLookAndFeel(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoPlaneSlider3DLookAndFeel GetScDblSliderLookAndFeel(PlaneId planeId) => throw null;
  }
}
