// Decompiled with JetBrains decompiler
// Type: RTG.RotationGizmoLookAndFeel3D
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
  public class RotationGizmoLookAndFeel3D : Settings
  {
    [SerializeField]
    private bool _isMidCapVisible;
    [SerializeField]
    private GizmoCap3DLookAndFeel _midCapLookAndFeel;
    [SerializeField]
    private bool[] _axesVis;
    [SerializeField]
    private GizmoPlaneSlider3DLookAndFeel[] _axesLookAndFeel;
    [SerializeField]
    private bool _isCamLookSliderVisible;
    [SerializeField]
    private float _camLookSliderRadiusOffset;
    [SerializeField]
    private GizmoPlaneSlider2DLookAndFeel _camLookSliderLookAndFeel;

    public float Scale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float Radius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool UseZoomFactor
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

    public Color ZBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color HoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisTorusThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisCylTorusWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisCylTorusHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisCullAlphaScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoShadeMode ShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCircle3DBorderType AxisBorderType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoFillMode3D AxisBorderFillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumAxisTorusWireAxialSlices
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RotationArcColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color RotationArcBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool UseShortestRotationArc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsRotationArcVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MidCapColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color MidCapBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color HoveredMidCapColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMidCapVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsMidCapBorderVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CamLookSliderRadiusOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color CamLookSliderBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color CamLookSliderHoveredBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoPolygon2DBorderType CamLookSliderPolyBorderType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CamLookSliderPolyBorderThickness
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsCamLookSliderVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RotationGizmoLookAndFeel3D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAxisVisible(int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisVisible(int axisIndex, bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisBorderFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNumAxisTorusWireAxialSlices(int numSlices) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUseZoomFactor(bool useZoomFactor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRadius(float radius) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisBorderCullAlphaScale(float scale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisBorderType(GizmoCircle3DBorderType borderType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisTorusThickness(float thickness) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisCylTorusWidth(float width) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisCylTorusHeight(float height) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoveredMidCapColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapBorderVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisBorderColor(int axisIndex, Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoveredColor(Color hoveredColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotationArcColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotationArcBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUseShortestRotationArc(bool useShortest) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRotationArcVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamLookSliderRadiusOffset(float offset) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamLookSliderBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamLookSliderHoveredBorderColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamLookSliderVisible(bool isVisible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamLookSliderPolyBorderType(GizmoPolygon2DBorderType polyBorderType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamLookSliderPolyBorderThickness(float thickness) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectSliderLookAndFeel(GizmoPlaneSlider3D slider, int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMidCapLookAndFeel(GizmoCap3D cap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectCamLookSliderLookAndFeel(GizmoPlaneSlider2D slider) => throw null;
  }
}
