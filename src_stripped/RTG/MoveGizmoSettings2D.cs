// Decompiled with JetBrains decompiler
// Type: RTG.MoveGizmoSettings2D
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
  public class MoveGizmoSettings2D : Settings
  {
    [SerializeField]
    private GizmoPlaneSlider2DSettings _dblSliderSettings;
    [SerializeField]
    private GizmoLineSlider2DSettings[] _sglSliderSettings;

    public float LineSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float BoxSliderHoverEps
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

    public float DragSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoveGizmoSettings2D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetLineSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBoxSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetXSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetYSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDragSensitivity(float sensitivity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectDblSliderSettings(GizmoPlaneSlider2D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoLineSlider2DSettings GetSliderSettings(int axisIndex, AxisSign axisSign) => throw null;
  }
}
