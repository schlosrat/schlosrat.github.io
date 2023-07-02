// Decompiled with JetBrains decompiler
// Type: RTG.Gizmo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  [Serializable]
  public class Gizmo
  {
    private bool _isEnabled;
    private GizmoHandleCollection _handles;
    private GizmoBehaviourCollection _behaviours;
    private GizmoHoverInfo _hoverInfo;
    private GizmoDragInfo _dragInfo;
    private IGizmoHandle _hoveredHandle;
    private Priority _genericHoverPriority;
    private Priority _hoverPriority3D;
    private Priority _hoverPriority2D;
    private IGizmoDragSession _activeDragSession;
    private GizmoTransform _transform;
    [NonSerialized]
    private MoveGizmo _moveGizmo;
    [NonSerialized]
    private RotationGizmo _rotationGizmo;
    [NonSerialized]
    private ScaleGizmo _scaleGizmo;
    [NonSerialized]
    private UniversalGizmo _universalGizmo;
    [NonSerialized]
    private ObjectTransformGizmo _objectTransformGizmo;
    [NonSerialized]
    private SceneGizmo _sceneGizmo;

    public event GizmoPostEnabledHandler PostEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPostDisabledHandler PostDisabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPreUpdateBeginHandler PreUpdateBegin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPostUpdateEndHandler PostUpdateEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPreHoverEnterHandler PreHoverEnter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPostHoverEnterHandler PostHoverEnter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPreHoverExitHandler PreHoverExit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPostHoverExitHandler PostHoverExit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPreDragBeginHandler PreDragBegin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPostDragBeginHandler PostDragBegin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPreDragEndHandler PreDragEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPostDragEndHandler PostDragEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPreDragUpdateHandler PreDragUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPostDragUpdateHandler PostDragUpdate
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPreHandlePickedHandler PreHandlePicked
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPostHandlePickedHandler PostHandlePicked
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPreDragBeginAttemptHandler PreDragBeginAttempt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoPostDragBeginAttemptHandler PostDragBeginAttempt
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event GizmoOffsetDragAxisModifyHandler OffsetDragAxisModify
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public static int InputDeviceDragButtonIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumHandles
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Camera FocusCamera
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Priority GenericHoverPriority
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Priority HoverPriority3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Priority HoverPriority2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoTransform Transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoHoverInfo HoverInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsHovered
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int HoverHandleId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoDimension HoverHandleDimension
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 HoverPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoDragInfo DragInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsDragged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoDragChannel ActiveDragChannel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int DragHandleId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 DragBeginPoint
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoDimension DragHandleDimension
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 TotalDragOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion TotalDragRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 TotalDragScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 RelativeDragOffset
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Quaternion RelativeDragRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 RelativeDragScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public MoveGizmo MoveGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public RotationGizmo RotationGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ScaleGizmo ScaleGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public UniversalGizmo UniversalGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectTransformGizmo ObjectTransformGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SceneGizmo SceneGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Gizmo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Camera GetWorkCamera() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoHandle CreateHandle(int id) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BehaviourType AddBehaviour<BehaviourType>() where BehaviourType : class, IGizmoBehaviour, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool AddBehaviour(IGizmoBehaviour behaviour) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool RemoveBehaviour(IGizmoBehaviour behaviour) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<BehaviourType> GetBehavioursOfType<BehaviourType>() where BehaviourType : class, IGizmoBehaviour => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BehaviourType GetFirstBehaviourOfType<BehaviourType>() where BehaviourType : class, IGizmoBehaviour => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IGizmoBehaviour GetFirstBehaviourOfType(System.Type behaviourType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public List<GizmoHandleHoverData> GetAllHandlesHoverData(Ray hoverRay) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IGizmoHandle GetHandleById_SystemCall(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnGUI_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdateBegin_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnUpdateEnd_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateHandleHoverInfo_SystemCall(GizmoHoverInfo hoverInfo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Render_SystemCall(Camera camera, Plane[] worldFrustumPlanes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleInputDeviceEvents_SystemCall() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInputDevicePickButtonDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInputDevicePickButtonUp() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EndDragSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnInputDeviceMoved() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TryActivateDragSession() => throw null;
  }
}
