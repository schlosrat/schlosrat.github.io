// Decompiled with JetBrains decompiler
// Type: RTG.MoveGizmo
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
  public class MoveGizmo : GizmoBehaviour
  {
    private GizmoLineSlider3D _pXSlider;
    private GizmoLineSlider3D _pYSlider;
    private GizmoLineSlider3D _pZSlider;
    private GizmoLineSlider3D _nXSlider;
    private GizmoLineSlider3D _nYSlider;
    private GizmoLineSlider3D _nZSlider;
    private GizmoLineSlider3DCollection _axesSliders;
    private GizmoPlaneSlider3D _xySlider;
    private GizmoPlaneSlider3D _yzSlider;
    private GizmoPlaneSlider3D _zxSlider;
    private GizmoPlaneSlider3DCollection _dblSliders;
    private GizmoCap3D _midCap;
    private bool _isVertexSnapEnabled;
    private GizmoCap2D _vertSnapCap;
    private GizmoObjectVertexSnapDrag3D _vertexSnapDrag;
    private Vector3 _postVSnapPosRestore;
    private bool _is2DModeEnabled;
    private GizmoLineSlider2D _p2DModeXSlider;
    private GizmoLineSlider2D _p2DModeYSlider;
    private GizmoLineSlider2D _n2DModeXSlider;
    private GizmoLineSlider2D _n2DModeYSlider;
    private GizmoLineSlider2DCollection _2DModeSliders;
    private GizmoPlaneSlider2D _2DModeDblSlider;
    [SerializeField]
    private bool _useSnapEnableHotkey;
    [SerializeField]
    private bool _useVertSnapEnableHotkey;
    [SerializeField]
    private bool _use2DModeEnableHotkey;
    [SerializeField]
    private MoveGizmoHotkeys _hotkeys;
    [SerializeField]
    private MoveGizmoSettings2D _settings2D;
    [SerializeField]
    private MoveGizmoSettings3D _settings3D;
    [SerializeField]
    private MoveGizmoLookAndFeel2D _lookAndFeel2D;
    [SerializeField]
    private MoveGizmoLookAndFeel3D _lookAndFeel3D;
    private MoveGizmoHotkeys _sharedHotkeys;
    private MoveGizmoSettings2D _sharedSettings2D;
    private MoveGizmoSettings3D _sharedSettings3D;
    private MoveGizmoLookAndFeel2D _sharedLookAndFeel2D;
    private MoveGizmoLookAndFeel3D _sharedLookAndFeel3D;

    public MoveGizmoSettings2D Settings2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmoSettings3D Settings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmoLookAndFeel2D LookAndFeel2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmoLookAndFeel3D LookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmoHotkeys Hotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmoSettings2D SharedSettings2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MoveGizmoSettings3D SharedSettings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MoveGizmoLookAndFeel2D SharedLookAndFeel2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MoveGizmoLookAndFeel3D SharedLookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public MoveGizmoHotkeys SharedHotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool UseSnapEnableHotkey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool UseVertSnapEnableHotkey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool Use2DModeEnableHotkey
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoveGizmo.VertexSnapState GetVertexSnapState() => throw null;

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
    public void SetVertexSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set2DModeEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAttached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDetached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoUpdateBegin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoDragUpdate(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlaceDblSlidersInSliderPlanes(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSharedLookAndFeel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSharedSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update2DGizmoPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update2DModeHandlePositions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoTransformChanged(
      GizmoTransform transform,
      GizmoTransform.ChangeData changeData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Hide2DModeHandles() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MoveGizmo() => throw null;

    public enum VertexSnapState
    {
      SelectingPivot,
      Snapping,
      Inactive,
    }
  }
}
