// Decompiled with JetBrains decompiler
// Type: RTG.GizmoTransform
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoTransform
  {
    private bool _firingChanged3DEvent;
    private bool _firingChanged2DEvent;
    private Vector3 _position3D;
    private Vector3 _localPosition3D;
    private Quaternion _rotation3D;
    private Quaternion _localRotation3D;
    private Vector2 _position2D;
    private Vector2 _localPosition2D;
    private float _rotation2DDegrees;
    private Quaternion _rotation2D;
    private float _localRotation2DDegrees;
    private Quaternion _localRotation2D;
    private Vector3[] _axes3D;
    private Vector2[] _axes2D;
    private GizmoTransform _parent;
    private List<GizmoTransform> _children;

    public event GizmoEntityTransformChangedHandler Changed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool CanChange3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool CanChange2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoTransform Parent
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int NumChildren
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public List<GizmoTransform> Children
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Right3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Up3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Look3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 Right2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector2 Up2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 Position3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2 Position2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion Rotation3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion Rotation2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float Rotation2DDegrees
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector3 LocalPosition3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Vector2 LocalPosition2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion LocalRotation3D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Quaternion LocalRotation2D
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float LocalRotation2DDegrees
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<GizmoTransform> FilterParentsOnly(IEnumerable<GizmoTransform> transforms) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlaneQuadrantId Get3DQuadrantFacingCamera(PlaneId planeId, Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Rotate3D(Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Rotate2D(float rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Rotate2D(Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 TransformVector3D(Vector3 vec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 TransformVector2D(Vector2 vec) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 TransformNormal3D(Vector3 normal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 TransformNormal2D(Vector2 normal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 InverseTransformNormal3D(Vector3 normal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 InverseTransformNormal2D(Vector2 normal) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 TransformPoint3D(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 TransformPoint2D(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 InverseTransformPoint3D(Vector3 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 InverseTransformPoint2D(Vector2 point) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignAxis3D(int axisIndex, AxisSign axisSign, Vector3 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AlignAxis2D(int axisIndex, AxisSign axisSign, Vector2 axis) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsChildOf(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetParent(GizmoTransform newParent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetAxis3D(AxisDescriptor axisDesc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetAxis3D(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetAxis2D(AxisDescriptor axisDesc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetAxis2D(int axisIndex, AxisSign axisSign) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3[] GetAxes3D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2[] GetAxes2D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Plane GetPlane3D(PlaneId planeId, PlaneQuadrantId planeQuadrantId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Plane GetPlane3D(PlaneDescriptor planeDesc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangePosition3D(Vector3 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangePosition2D(Vector2 position) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeRotation3D(Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeRotation2D(float rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeRotation2D(Quaternion rotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeLocalPosition3D(Vector3 localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeLocalPosition2D(Vector2 localPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeLocalRotation3D(Quaternion localRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeLocalRotation2D(float localRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ChangeLocalRotation2D(Quaternion localRotation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnParentChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPosition3DChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPosition2DChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalPosition3DChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalPosition2DChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotation3DChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnRotation2DChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalRotation3DChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnLocalRotation2DChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateChildTransforms3D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateChildTransforms2D() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnChanged(GizmoTransform.ChangeData changeData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update3DAxes() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update2DAxes() => throw null;

    public enum ChangeReason
    {
      TRSChange,
      ParentChange,
    }

    public struct ChangeData
    {
      public GizmoTransform.ChangeReason ChangeReason;
      public GizmoDimension TRSDimension;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ChangeData(GizmoTransform.ChangeReason changeReason, GizmoDimension trsDimension) => throw null;
    }
  }
}
