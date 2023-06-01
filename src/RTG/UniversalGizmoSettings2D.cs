// Decompiled with JetBrains decompiler
// Type: RTG.UniversalGizmoSettings2D
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
  public class UniversalGizmoSettings2D : Settings
  {
    [SerializeField]
    private UniversalGizmoSettingsCategory _displayCategory;
    [SerializeField]
    private GizmoPlaneSlider2DSettings _mvDblSliderSettings;
    [SerializeField]
    private GizmoLineSlider2DSettings[] _mvSglSliderSettings;

    public float MvLineSliderHoverEps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MvBoxSliderHoverEps
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

    public float MvDragSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoSettingsCategory DisplayCategory
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniversalGizmoSettings2D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvLineSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvBoxSliderHoverEps(float eps) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvXSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvYSnapStep(float snapStep) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvDragSensitivity(float sensitivity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMvSliderSettings(GizmoLineSlider2D slider, int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMvDblSliderSettings(GizmoPlaneSlider2D slider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Inherit(MoveGizmoSettings2D settings) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoLineSlider2DSettings GetMvSliderSettings(int axisIndex, AxisSign axisSign) => throw null;
  }
}
