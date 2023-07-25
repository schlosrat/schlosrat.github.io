// Decompiled with JetBrains decompiler
// Type: RTG.UniversalGizmoSettings3D
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
  public class UniversalGizmoSettings3D : Settings
  {
    [SerializeField]
    private UniversalGizmoSettingsCategory _displayCategory;
    [SerializeField]
    private GizmoObjectVertexSnapSettings _mvVertexSnapSettings;
    [SerializeField]
    private GizmoLineSlider3DSettings[] _mvSglSliderSettings;
    [SerializeField]
    private GizmoPlaneSlider3DSettings[] _mvDblSliderSettings;
    [SerializeField]
    private float _rtCamRightSnapStep;
    [SerializeField]
    private float _rtCamUpSnapStep;
    [SerializeField]
    private GizmoPlaneSlider3DSettings[] _rtSliderSettings;
    [SerializeField]
    private GizmoPlaneSlider2DSettings _rtCamLookSliderSettings;
    [SerializeField]
    private float _scUniformSnapStep;
    [SerializeField]
    private GizmoLineSlider3DSettings[] _scSglSliderSettings;
    [SerializeField]
    private GizmoPlaneSlider3DSettings[] _scDblSliderSettings;

    public GizmoObjectVertexSnapSettings VertexSnapSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvLineSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvBoxSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvCylinderSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvXSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvYSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvZSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvDragSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtAxisLineHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtAxisTorusHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtCamLookLineHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtCamLookThickHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool RtCanHoverCulledPixels
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoSnapMode RtSnapMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtXSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtYSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtZSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtCamRightSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtCamUpSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtCamLookSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float RtDragSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScLineSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScBoxSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScCylinderSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScXSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScYSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScZSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScXYSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScYZSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScZXSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScUniformSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ScDragSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoSettingsCategory DisplayCategory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniversalGizmoSettings3D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvLineSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvBoxSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvCylinderSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvXSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvYSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvZSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDragSensitivity(float sensitivity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMvSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMvDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inherit(MoveGizmoSettings3D settings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoLineSlider3DSettings GetMvSglSliderSettings(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoPlaneSlider3DSettings GetMvDblSliderSettings(PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCanHoverCulledPixels(bool canHover) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisLineHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisTorusHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamLookLineHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamLookThickHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtAxisSnapStep(int axisIndex, float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamRightSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamUpSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtCamLookSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtSnapMode(GizmoSnapMode snapMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtDragSensitivity(float sensitivity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectRtSliderSettings(GizmoPlaneSlider3D slider, int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectRtCamLookSliderSettings(GizmoPlaneSlider2D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inherit(RotationGizmoSettings3D settings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScLineSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScBoxSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScCylinderSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScXSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScYSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScZSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScXYSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScYZSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScZXSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScUniformScaleSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScDragSensitivity(float sensitivity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectScSliderSettings(GizmoLineSlider3D slider, int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectScDblSliderSettings(GizmoPlaneSlider3D dblSlider, PlaneId planeId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inherit(ScaleGizmoSettings3D settings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoLineSlider3DSettings GetScSglSliderSettings(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoPlaneSlider3DSettings GetScDblSliderSettings(PlaneId planeId) => throw null;
  }
}
