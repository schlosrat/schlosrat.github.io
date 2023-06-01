// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.sample.SampleInputProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.ModularCamera.sample
{
  [Serializable]
  public class SampleInputProvider : ICameraInputProvider
  {
    public static readonly float EPSILON_SQR;
    private const float MIN_EASE = 0.0f;
    private const float MAX_EASE = 0.995f;
    [Header("Attack/Decay:   0 = fast, 1 = slow")]
    [Space]
    [Header("Move(3d) Inputs")]
    public float moveSlowSensitivity;
    public float moveFastSensitivity;
    [Range(0.0f, 0.995f)]
    public float moveInputAttack;
    [Range(0.0f, 0.995f)]
    public float moveInputDecay;
    [Header("Drag(2d) Inputs")]
    public float dragSensitivity;
    [Range(0.0f, 0.995f)]
    public float dragInputAttack;
    [Range(0.0f, 0.995f)]
    public float dragInputDecay;
    [Header("Scroll(1d) Inputs")]
    public float scrollSlowSensitivity;
    public float scrollFastSensitivity;
    [Range(0.0f, 0.995f)]
    public float scrollInputAttack;
    [Range(0.0f, 0.995f)]
    public float scrollInputDecay;
    [HideInInspector]
    [NonSerialized]
    public KeyCode mouseKeyLocked;
    [HideInInspector]
    [NonSerialized]
    public Vector3 lastMoveInput;
    [HideInInspector]
    [NonSerialized]
    public Dictionary<KeyCode, Vector2> lastDragInputs;
    [HideInInspector]
    [NonSerialized]
    public float lastScrollInput;

    private float MoveInputAttack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private float MoveInputDecay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private float DragInputAttack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private float DragInputDecay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private float ScrollInputAttack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private float ScrollInputDecay
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void HandleMouseDragLocks(ICameraDriver driver) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PassInputsToDriver(ICameraDriver driver) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearLastMoveInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearLastScrollInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearLastDragInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ClearLastInputs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetRawMoveInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector2 GetRawDragInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRawScrollInput() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MouseLock(KeyCode toLock) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MouseUnlock() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SampleInputProvider() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static SampleInputProvider() => throw null;
  }
}
