// Decompiled with JetBrains decompiler
// Type: RTG.CameraZoomSettings
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
  public class CameraZoomSettings : Settings
  {
    [SerializeField]
    private CameraZoomMode _zoomMode;
    [SerializeField]
    private float _orthoStandardZoomSensitivity;
    [SerializeField]
    private float _perspStandardZoomSensitivity;
    [SerializeField]
    private float _orthoSmoothZoomSensitivity;
    [SerializeField]
    private float _perspSmoothZoomSensitivity;
    [SerializeField]
    private float _orthoZoomSmoothValue;
    [SerializeField]
    private float _perspZoomSmoothValue;
    [SerializeField]
    private bool _invertZoomAxis;
    [SerializeField]
    private bool _isZoomEnabled;

    public CameraZoomMode ZoomMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float OrthoStandardZoomSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float PerspStandardZoomSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float OrthoSmoothZoomSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float PerspSmoothZoomSensitivity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float OrthoZoomSmoothValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float PerspZoomSmoothValue
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool InvertZoomAxis
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsZoomEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetZoomSmoothValue(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetZoomSensitivity(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CameraZoomSettings() => throw null;
  }
}
