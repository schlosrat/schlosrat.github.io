// Decompiled with JetBrains decompiler
// Type: RTG.Tut_1_Enabling_and_Disabling_Gizmos
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class Tut_1_Enabling_and_Disabling_Gizmos : MonoBehaviour
  {
    private ObjectTransformGizmo _objectMoveGizmo;
    private ObjectTransformGizmo _objectRotationGizmo;
    private ObjectTransformGizmo _objectScaleGizmo;
    private ObjectTransformGizmo _objectUniversalGizmo;
    private Tut_1_Enabling_and_Disabling_Gizmos.GizmoId _workGizmoId;
    private ObjectTransformGizmo _workGizmo;
    private GameObject _targetObject;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject PickGameObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWorkGizmoId(
      Tut_1_Enabling_and_Disabling_Gizmos.GizmoId gizmoId)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnTargetObjectChanged(GameObject newTargetObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Tut_1_Enabling_and_Disabling_Gizmos() => throw null;

    private enum GizmoId
    {
      Move = 1,
      Rotate = 2,
      Scale = 3,
      Universal = 4,
    }
  }
}
