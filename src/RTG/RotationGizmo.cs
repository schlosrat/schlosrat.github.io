// Decompiled with JetBrains decompiler
// Type: RTG.RotationGizmo
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
  public class RotationGizmo : GizmoBehaviour
  {
    private GizmoPlaneSlider3D _xSlider;
    private GizmoPlaneSlider3D _ySlider;
    private GizmoPlaneSlider3D _zSlider;
    private GizmoPlaneSlider3DCollection _axesSliders;
    private GizmoCap3D _midCap;
    private GizmoDblAxisRotationDrag3D _camXYRotationDrag;
    private GizmoPlaneSlider2D _camLookSlider;
    [SerializeField]
    private RotationGizmoHotkeys _hotkeys;
    [SerializeField]
    private RotationGizmoSettings3D _settings3D;
    [SerializeField]
    private RotationGizmoLookAndFeel3D _lookAndFeel3D;
    [SerializeField]
    private bool _useSnapEnableHotkey;
    private RotationGizmoHotkeys _sharedHotkeys;
    private RotationGizmoSettings3D _sharedSettings3D;
    private RotationGizmoLookAndFeel3D _sharedLookAndFeel3D;

    public RotationGizmoSettings3D Settings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RotationGizmoLookAndFeel3D LookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RotationGizmoHotkeys Hotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RotationGizmoSettings3D SharedSettings3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public RotationGizmoLookAndFeel3D SharedLookAndFeel3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public RotationGizmoHotkeys SharedHotkeys
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool UseSnapEnableHotkey
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
    public void SetMidCapHoverable(bool hoverable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSnapEnabled(bool isEnabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDetached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDisabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAttached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoUpdateBegin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoAttemptHandleDragBegin(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCamLookSlider(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSharedLookAndFeel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetupSharedSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGizmoTransformChanged(
      GizmoTransform gizmoTransform,
      GizmoTransform.ChangeData changeData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RotationGizmo() => throw null;
  }
}
