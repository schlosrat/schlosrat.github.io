// Decompiled with JetBrains decompiler
// Type: RTG.GizmoBehaviour
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
  public abstract class GizmoBehaviour : IGizmoBehaviour
  {
    protected Gizmo _gizmo;
    protected bool _isEnabled;

    public Gizmo Gizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool IsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init_SystemCall(GizmoBehaviorInitParams initParams) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEnabled(bool enabled) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnAttached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDetached() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoDisabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnEnabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDisabled() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoHandlePicked(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool OnGizmoCanBeginDrag(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoAttemptHandleDragBegin(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoDragBegin(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoDragUpdate(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoDragEnd(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoHoverEnter(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoHoverExit(int handleId) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoUpdateBegin() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoUpdateEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGUI() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnGizmoRender(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void CheckRequiredBehaviours(List<System.Type> reqBehaviourTypes) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ThrowReqBehaviourExeception(System.Type reqBehaviorType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected GizmoBehaviour() => throw null;
  }
}
