// Decompiled with JetBrains decompiler
// Type: RTG.SceneGizmoLookAndFeel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class SceneGizmoLookAndFeel : Settings
  {
    private static readonly float _baseScreenSize;
    private static readonly float _invBaseScreenSize;
    [SerializeField]
    private GizmoCap3DLookAndFeel _midCapLookAndFeel;
    [SerializeField]
    private GizmoCap3DLookAndFeel[] _axesCapsLookAndFeel;
    [SerializeField]
    private SceneGizmoScreenCorner _screenCorner;
    [SerializeField]
    private Vector2 _screenOffset;
    [SerializeField]
    private float _screenSize;
    [SerializeField]
    private Color _axesLabelTint;
    [SerializeField]
    private Color _camPrjSwitchLabelTint;
    [SerializeField]
    private bool _isCamPrjSwitchLabelVisible;

    private GizmoCap3DLookAndFeel AxisCapLookAndFeel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SceneGizmoScreenCorner ScreenCorner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2 ScreenOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float ScreenSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color AxesLabelTint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color CamPrjSwitchLabelTint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsCamPrjSwitchLabelVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Texture2D CamPerspModeLabelTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture2D CamOrthoModeLabelTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color HoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap3DType AxesCapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoCap3DType MidCapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MidCapBoxSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float MidCapSphereRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisConeHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisConeRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisPyramidWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisPyramidHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisPyramidDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisLabelScreenSize
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisCamAlignFadeOutThreshold
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisCamAlignFadeOutDuration
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float AxisCamAlignFadeOutAlpha
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SceneGizmoLookAndFeel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapColor(Color color) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisCapColor(Color color, int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Color GetAxisCapColor(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHoveredColor(Color hoveredColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisCapFillMode(GizmoFillMode3D fillMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisCapShadeMode(GizmoShadeMode shadeMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Enum> GetAllowedMidCapTypes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<Enum> GetAllowedAxesCapTypes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMidCapTypeAllowed(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMidCapType(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsAxisCapTypeAllowed(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxisCapType(GizmoCap3DType capType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetAxesLabelWorldSize(Camera gizmoCam, Vector3 labelWorldPos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 CalculateMaxPrjSwitchLabelRectSize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectMidCapLookAndFeel(GizmoCap3D midCap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ConnectAxisCapLookAndFeel(GizmoCap3D axisCap, int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GizmoCap3DLookAndFeel GetAxisCapLookAndFeel(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnScreenSizeChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SceneGizmoLookAndFeel() => throw null;
  }
}
