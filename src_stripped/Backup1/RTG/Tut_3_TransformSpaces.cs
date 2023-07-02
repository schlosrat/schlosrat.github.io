// Decompiled with JetBrains decompiler
// Type: RTG.Tut_3_TransformSpaces
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class Tut_3_TransformSpaces : MonoBehaviour
  {
    private ObjectTransformGizmo _objectMoveGizmo;
    private ObjectTransformGizmo _objectRotationGizmo;
    private ObjectTransformGizmo _objectScaleGizmo;
    private ObjectTransformGizmo _objectUniversalGizmo;
    private Tut_3_TransformSpaces.GizmoId _workGizmoId;
    private ObjectTransformGizmo _workGizmo;
    private List<GameObject> _selectedObjects;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private GameObject PickGameObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetWorkGizmoId(Tut_3_TransformSpaces.GizmoId gizmoId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnSelectionChanged() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetTransformSpace(GizmoSpace transformSpace) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Tut_3_TransformSpaces() => throw null;

    private enum GizmoId
    {
      Move = 1,
      Rotate = 2,
      Scale = 3,
      Universal = 4,
    }
  }
}
