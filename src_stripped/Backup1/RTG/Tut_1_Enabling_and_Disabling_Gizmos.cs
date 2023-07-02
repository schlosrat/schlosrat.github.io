// Decompiled with JetBrains decompiler
// Type: RTG.Tut_1_Enabling_and_Disabling_Gizmos
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
