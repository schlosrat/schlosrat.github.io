// Decompiled with JetBrains decompiler
// Type: RTG.UniversalGizmo
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
  public class UniversalGizmo : GizmoBehaviour
  {
    private GizmoLineSlider3D _mvPXSlider;
    private GizmoLineSlider3D _mvPYSlider;
    private GizmoLineSlider3D _mvPZSlider;
    private GizmoLineSlider3D _mvNXSlider;
    private GizmoLineSlider3D _mvNYSlider;
    private GizmoLineSlider3D _mvNZSlider;
    private GizmoLineSlider3DCollection _mvAxesSliders;
    private GizmoPlaneSlider3D _mvXYSlider;
    private GizmoPlaneSlider3D _mvYZSlider;
    private GizmoPlaneSlider3D _mvZXSlider;
    private GizmoPlaneSlider3DCollection _mvDblSliders;
    private bool _isMvVertexSnapEnabled;
    private GizmoCap2D _mvVertSnapCap;
    private GizmoObjectVertexSnapDrag3D _mvVertexSnapDrag;
    private Vector3 _mvPostVSnapPosRestore;
    private GizmoLineSlider2D _mvP2DModeXSlider;
    private GizmoLineSlider2D _mvP2DModeYSlider;
    private GizmoLineSlider2D _mvN2DModeXSlider;
    private GizmoLineSlider2D _mvN2DModeYSlider;
    private GizmoLineSlider2DCollection _mv2DModeSliders;
    private GizmoPlaneSlider2D _mv2DModeDblSlider;
    private GizmoPlaneSlider3D _rtXSlider;
    private GizmoPlaneSlider3D _rtYSlider;
    private GizmoPlaneSlider3D _rtZSlider;
    private GizmoPlaneSlider3DCollection _rtAxesSliders;
    private GizmoCap3D _rtMidCap;
    private GizmoDblAxisRotationDrag3D _rtCamXYRotationDrag;
    private GizmoPlaneSlider2D _rtCamLookSlider;
    private GizmoCap3D _scMidCap;
    private GizmoUniformScaleDrag3D _scUnformScaleDrag;
    private GizmoScaleGuide _scScaleGuide;
    private IEnumerable<GameObject> _scScaleGuideTargetObjects;
    private bool _is2DModeEnabled;
    [SerializeField]
    private UniversalGizmoSettings2D _settings2D;
    private UniversalGizmoSettings2D _sharedSettings2D;
    [SerializeField]
    private UniversalGizmoSettings3D _settings3D;
    private UniversalGizmoSettings3D _sharedSettings3D;
    [SerializeField]
    private UniversalGizmoLookAndFeel2D _lookAndFeel2D;
    private UniversalGizmoLookAndFeel2D _sharedLookAndFeel2D;
    [SerializeField]
    private UniversalGizmoLookAndFeel3D _lookAndFeel3D;
    private UniversalGizmoLookAndFeel3D _sharedLookAndFeel3D;
    [SerializeField]
    private UniversalGizmoHotkeys _hotkeys;
    private UniversalGizmoHotkeys _sharedHotkeys;
    [SerializeField]
    private bool _useSnapEnableHotkey;
    [SerializeField]
    private bool _useVertSnapEnableHotkey;
    [SerializeField]
    private bool _use2DModeEnableHotkey;

    public UniversalGizmoSettings2D Settings2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoSettings2D SharedSettings2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniversalGizmoSettings3D Settings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoSettings3D SharedSettings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniversalGizmoLookAndFeel2D LookAndFeel2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoLookAndFeel2D SharedLookAndFeel2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniversalGizmoLookAndFeel3D LookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoLookAndFeel3D SharedLookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public UniversalGizmoHotkeys Hotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmoHotkeys SharedHotkeys
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
    public UniversalGizmo.MvVertexSnapState GetMvVertexSnapState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMvZoomFactor(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMvZoomFactor(Vector3 position, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRtZoomFactor(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRtZoomFactor(Vector3 position, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetScZoomFactor(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetScZoomFactor(Vector3 position, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDraggingMoveHandle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDraggingRotationHandle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsDraggingScaleHandle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMoveHandle(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRotationHandle(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsScaleHandle(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool OwnsHandle(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertexSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set2DModeEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvVertexSnapTargetObjects(IEnumerable<GameObject> targetObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMvAxesLinesHoverable(bool hoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetRtMidCapHoverable(bool hoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetScaleGuideTargetObjects(IEnumerable<GameObject> targetObjects) => throw null;

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
    public override void OnGizmoDragBegin(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoDragEnd(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoAttemptHandleDragBegin(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void PlaceMvDblSlidersInSliderPlanes(Camera camera) => throw null;

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
    private void UpdateRtCamLookSlider(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMoveHandlesVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetRotationHandlesVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetScaleHandlesVisible(bool visible) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UniversalGizmo() => throw null;

    public enum MvVertexSnapState
    {
      SelectingPivot,
      Snapping,
      Inactive,
    }
  }
}
