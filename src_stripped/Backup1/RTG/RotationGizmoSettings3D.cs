// Decompiled with JetBrains decompiler
// Type: RTG.RotationGizmoSettings3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class RotationGizmoSettings3D : Settings
  {
    [SerializeField]
    private float _camRightSnapStep;
    [SerializeField]
    private float _camUpSnapStep;
    [SerializeField]
    private GizmoPlaneSlider3DSettings[] _sliderSettings;
    [SerializeField]
    private GizmoPlaneSlider2DSettings _camLookSliderSettings;

    public float AxisLineHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisTorusHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CamLookLineHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CamLookThickHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool CanHoverCulledPixels
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoSnapMode SnapMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float XSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float YSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float ZSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CamRightSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CamUpSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float CamLookSnapStep
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float DragSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RotationGizmoSettings3D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCanHoverCulledPixels(bool canHover) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisLineHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisTorusHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamLookLineHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamLookThickHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisSnapStep(int axisIndex, float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamRightSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamUpSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCamLookSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSnapMode(GizmoSnapMode snapMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragSensitivity(float sensitivity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectSliderSettings(GizmoPlaneSlider3D slider, int axisIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectCamLookSliderSettings(GizmoPlaneSlider2D slider) => throw null;
  }
}
