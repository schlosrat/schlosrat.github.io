// Decompiled with JetBrains decompiler
// Type: RTG.ScaleGizmo
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
  public class ScaleGizmo : GizmoBehaviour
  {
    private GizmoLineSlider3D _pstvXSlider;
    private GizmoLineSlider3D _pstvYSlider;
    private GizmoLineSlider3D _pstvZSlider;
    private GizmoLineSlider3D _negXSlider;
    private GizmoLineSlider3D _negYSlider;
    private GizmoLineSlider3D _negZSlider;
    private GizmoLineSlider3DCollection _axesSliders;
    private GizmoMultiAxisScaleMode _multiAxisScaleMode;
    private GizmoPlaneSlider3D _xySlider;
    private GizmoPlaneSlider3D _yzSlider;
    private GizmoPlaneSlider3D _zxSlider;
    private GizmoPlaneSlider3DCollection _dblSliders;
    private GizmoCap3D _midCap;
    private GizmoUniformScaleDrag3D _unformScaleDrag;
    private GizmoScaleGuide _scaleGuide;
    private IEnumerable<GameObject> _scaleGuideTargetObjects;
    [SerializeField]
    private ScaleGizmoLookAndFeel3D _lookAndFeel3D;
    [SerializeField]
    private ScaleGizmoSettings3D _settings3D;
    [SerializeField]
    private ScaleGizmoHotkeys _hotkeys;
    [SerializeField]
    private bool _useSnapEnableHotkey;
    [SerializeField]
    private bool _useMultiAxisScaleModeHotkey;
    private ScaleGizmoLookAndFeel3D _sharedLookAndFeel3D;
    private ScaleGizmoSettings3D _sharedSettings3D;
    private ScaleGizmoHotkeys _sharedHotkeys;

    public GizmoMultiAxisScaleMode MultiAxisScaleMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ScaleGizmoLookAndFeel3D LookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ScaleGizmoSettings3D Settings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ScaleGizmoHotkeys Hotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ScaleGizmoHotkeys SharedHotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ScaleGizmoSettings3D SharedSettings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ScaleGizmoLookAndFeel3D SharedLookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool UseSnapEnableHotkey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool UseMultiAxisScaleModeHotkey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetZoomFactor(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetZoomFactor(Vector3 position, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OwnsHandle(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAxesLinesHoverable(bool hoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMultiAxisScaleMode(GizmoMultiAxisScaleMode scaleMode) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAttached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoUpdateBegin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoAttemptHandleDragBegin(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlaceDblSlidersInSliderPlanes(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSharedLookAndFeel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSharedSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ScaleGizmo() => throw null;
  }
}
