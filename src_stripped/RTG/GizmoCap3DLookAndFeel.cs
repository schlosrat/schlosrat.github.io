// Decompiled with JetBrains decompiler
// Type: RTG.GizmoCap3DLookAndFeel
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
  public class GizmoCap3DLookAndFeel
  {
    [SerializeField]
    private GizmoCap3DType _capType;
    [SerializeField]
    private GizmoFillMode3D _fillMode;
    [SerializeField]
    private GizmoShadeMode _shadeMode;
    [SerializeField]
    private float _scale;
    [SerializeField]
    private bool _useZoomFactor;
    [SerializeField]
    private float _coneHeight;
    [SerializeField]
    private float _coneRadius;
    [SerializeField]
    private float _pyramidHeight;
    [SerializeField]
    private float _pyramidWidth;
    [SerializeField]
    private float _pyramidDepth;
    [SerializeField]
    private float _boxWidth;
    [SerializeField]
    private float _boxHeight;
    [SerializeField]
    private float _boxDepth;
    [SerializeField]
    private float _sphereRadius;
    [SerializeField]
    private float _trPrismWidth;
    [SerializeField]
    private float _trPrismHeight;
    [SerializeField]
    private float _trPrismDepth;
    [SerializeField]
    private bool _isSphereBorderVisible;
    [SerializeField]
    private Color _sphereBorderColor;
    [SerializeField]
    private int _numSphereBorderPoints;
    [SerializeField]
    private Color _color;
    [SerializeField]
    private Color _hoveredColor;

    public GizmoCap3DType CapType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoFillMode3D FillMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public GizmoShadeMode ShadeMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float Scale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool UseZoomFactor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float ConeHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float ConeRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float PyramidHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float PyramidWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float PyramidDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float BoxWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float BoxHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float BoxDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float SphereRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float TrPrismWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float TrPrismHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float TrPrismDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsSphereBorderVisible
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color SphereBorderColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public int NumSphereBorderPoints
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color HoveredColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public static float DefaultConeHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float DefaultConeRadius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float DefaultPyramidHeight
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float DefaultPyramidWidth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static float DefaultPyramidDepth
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoCap3DLookAndFeel() => throw null;
  }
}
