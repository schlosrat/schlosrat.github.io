// Decompiled with JetBrains decompiler
// Type: RTG.GizmoDragSession
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public abstract class GizmoDragSession : IGizmoDragSession
  {
    private List<GizmoTransform> _targetTransforms;
    protected Vector3 _totalDragOffset;
    protected Quaternion _totalDragRotation;
    protected Vector3 _totalDragScale;
    protected Vector3 _relativeDragOffset;
    protected Quaternion _relativeDragRotation;
    protected Vector3 _relativeDragScale;

    public int NumTargetTransforms
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

    public abstract bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public abstract GizmoDragChannel DragChannel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsTargetTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddTargetTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveTargetTransform(GizmoTransform transform) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Begin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void End() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract bool DoBeginSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract bool DoUpdateSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void DoEndSession() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void CalculateDragValues() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ApplyDrag() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool CanBegin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnSessionBegin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnSessionEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected GizmoDragSession() => throw null;
  }
}
