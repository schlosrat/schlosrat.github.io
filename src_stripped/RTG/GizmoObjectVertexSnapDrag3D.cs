// Decompiled with JetBrains decompiler
// Type: RTG.GizmoObjectVertexSnapDrag3D
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class GizmoObjectVertexSnapDrag3D : GizmoDragSession
  {
    private IEnumerable<GameObject> _targetObjects;
    private Vector3 _snapPivot;
    private bool _isActive;
    private List<GameObject> _destinationObjects;
    private GizmoObjectVertexSnapSettings _settings;
    private List<GameObject> _visibleObjectBuffer;

    public override bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override GizmoDragChannel DragChannel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Vector3 SnapPivot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public GizmoObjectVertexSnapSettings Settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetTargetObjects(IEnumerable<GameObject> targetObjects) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool SelectSnapPivotPoint(Gizmo gizmo) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool DoBeginSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool DoUpdateSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void DoEndSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CalculateDragValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool GetWorldPointClosestToInputDevice(
      Camera focusCamera,
      IEnumerable<GameObject> gameObjects,
      out Vector3 point)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected bool CanUseObjectAsSnapDestination(GameObject gameObject) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void GatherDestinationObjects() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GizmoObjectVertexSnapDrag3D() => throw null;
  }
}
