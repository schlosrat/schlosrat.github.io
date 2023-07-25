// Decompiled with JetBrains decompiler
// Type: RTG.ObjectTransformGizmo
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
  public class ObjectTransformGizmo : GizmoBehaviour
  {
    private ObjectTransformGizmo.TargetObjectMode _targetObjectMode;
    private ObjectTransformGizmo.Channels _transformChannelFlags;
    private IEnumerable<GameObject> _targetObjects;
    private GameObject _targetPivotObject;
    private List<LocalTransformSnapshot> _preTransformSnapshots;
    private List<GameObject> _transformableParents;
    private AABB _targetGroupAABBOnDragBegin;
    private GizmoSpace _transformSpace;
    private bool _isTransformSpacePermanent;
    private GizmoObjectTransformPivot _transformPivot;
    private bool _isTransformPivotPermanent;
    private bool _scaleConstraintEnabled;
    private Vector3 _minPositiveScale;
    private Vector3 _customWorldPivot;
    private Dictionary<GameObject, Vector3> _objectToCustomLocalPivot;
    private Dictionary<GameObject, ObjectTransformGizmo.ObjectRestrictions> _objectToRestrictions;
    [SerializeField]
    private ObjectTransformGizmoSettings _settings;
    private ObjectTransformGizmoSettings _sharedSettings;

    public GizmoObjectTransformPivot TransformPivot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsTransformPivotPermanent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoSpace TransformSpace
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsTransformSpacePermanent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectTransformGizmo.Channels TransformChannelFlags
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool CanAffectPosition
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool CanAffectRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool CanAffectScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 CustomWorldPivot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool ScaleConstraintEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 MinPositiveScale
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ObjectTransformGizmoSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public ObjectTransformGizmoSettings SharedSettings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnAttached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnDetached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeTransformSpacePermanent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MakeTransformPivotPermanent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsRestrictionsForObject(GameObject targetObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterObjectRestrictions(
      GameObject targetObject,
      ObjectTransformGizmo.ObjectRestrictions restrictions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterObjectRestrictions(
      List<GameObject> targetObjects,
      ObjectTransformGizmo.ObjectRestrictions restrictions)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UnregisterObjectRestrictions(GameObject targetObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectTransformGizmo.ObjectRestrictions GetObjectRestrictions(GameObject targetObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTransformChannelFlags(ObjectTransformGizmo.Channels flags) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCanAffectPosition(bool affectPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCanAffectRotation(bool affectRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCanAffectScale(bool affectScale) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetPivotObject(GameObject targetPivotObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetObjects(IEnumerable<GameObject> targetObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetObject(GameObject targetObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTransformPivot(GizmoObjectTransformPivot transformPivot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCustomWorldPivot(Vector3 pivot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetObjectCustomLocalPivot(GameObject gameObj, Vector3 pivot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetObjectCustomLocalPivot(GameObject gameObj) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTransformSpace(GizmoSpace transformSpace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AABB GetTargetObjectGroupWorldAABB() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNumTransformableParentObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshPosition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RefreshPositionAndRotation() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoDragBegin(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoDragUpdate(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnGizmoDragEnd(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private List<GameObject> GetTransformableParentObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnUndoRedoEnd(IUndoRedoAction action) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveObjects(Vector3 moveVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MoveObject(GameObject gameObject, Vector3 moveVector) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RotateObjects(Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RotateObject(GameObject gameObject, Quaternion rotation, Vector3 rotationPivot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScaleObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScaleObject(GameObject gameObject, Vector3 scalePivot) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private ObjectBounds.QueryConfig GetObjectBoundsQConfig() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectTransformGizmo() => throw null;

    public class ObjectRestrictions
    {
      private bool[] _moveAxesMask;
      private bool[] _scaleAxesMask;
      private HashSet<int> _handleMask;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool CanMoveAlongAllAxes() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool CanScaleAlongAllAxes() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool CanMoveAlongAxis(int axisIndex) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool CanScaleAlongAxis(int axisIndex) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCanMoveAlongAxis(int axisIndex, bool canMove) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetCanScaleAlongAxis(int axisIndex, bool canScale) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public bool IsAffectedByHandle(int handleId) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetIsAffectedByHandle(int handleId, bool isAffected) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3 AdjustMoveVector(Vector3 moveVector) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Vector3 AdjustScaleVector(Vector3 scaleVector) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ObjectRestrictions() => throw null;
    }

    [Flags]
    public enum Channels
    {
      None = 0,
      Position = 1,
      Rotation = 2,
      Scale = 4,
      All = Scale | Rotation | Position, // 0x00000007
    }

    private enum TargetObjectMode
    {
      Multiple,
      Single,
    }
  }
}
