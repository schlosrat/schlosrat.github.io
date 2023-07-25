// Decompiled with JetBrains decompiler
// Type: RTG.LocalGizmoTransformSnapshot
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class LocalGizmoTransformSnapshot
  {
    private GizmoTransform _transform;
    private GizmoTransform _parentTransform;
    private Vector3 _localPosition3D;
    private Quaternion _localRotation3D;
    private Vector2 _localPosition2D;
    private float _localRotation2D_Degrees;

    public GizmoTransform Transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static List<LocalGizmoTransformSnapshot> GetSnapshotCollection(IEnumerable<Gizmo> gizmos) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Snapshot(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Apply() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalGizmoTransformSnapshot() => throw null;
  }
}
