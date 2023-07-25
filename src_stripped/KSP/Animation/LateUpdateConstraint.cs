// Decompiled with JetBrains decompiler
// Type: KSP.Animation.LateUpdateConstraint
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Animation
{
  public abstract class LateUpdateConstraint : OABOrFlightEnablable
  {
    [SerializeField]
    protected bool _keepUpdating;
    protected Action OnUpdateCompleted;
    [Tooltip("Link to another constraint to force this constraint to wait until this parent has updated before we will update.")]
    public LateUpdateConstraint ParentLateUpdateConstraintToWaitFor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void UpdateTransform() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetUpdateState(bool doUpdate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected LateUpdateConstraint() => throw null;
  }
}
