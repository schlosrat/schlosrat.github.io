// Decompiled with JetBrains decompiler
// Type: RotateRandomlyAtSpeed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RotateRandomlyAtSpeed : OABOrFlightEnablable
{
  [Space(10f)]
  [SerializeField]
  private RotateRandomlyAtSpeed.AxisOfRotation rotationAxis;
  [Tooltip("Speed is in degrees per second")]
  [SerializeField]
  private float rotationSpeed;
  [Tooltip("Number of frames it takes to get to full speed")]
  [SerializeField]
  private int accelerationTime;
  [Tooltip("Number of frames it takes to to stop")]
  [SerializeField]
  private int decelerationTime;
  [SerializeField]
  [Space(10f)]
  private float minRandomizeDelay;
  [SerializeField]
  private float maxRandomizeDelay;
  private bool goalReached;
  private bool stopped;
  private float curSpeed;
  private float curAngle;
  private float curGoal;
  private bool turnDirectionIsPositive;
  private static System.Random randomizer;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator TriggerNewGoalWithDelay() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateSpeed() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateTransformRotation() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateSlowToAStop() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool AreWeCloseEnoughToGoal() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetTurnDirection() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void KeepAngleBetween0And360() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void GenerateNewGoalRotation() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float NextRandomFloat(float min, float max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public RotateRandomlyAtSpeed() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static RotateRandomlyAtSpeed() => throw null;

  internal enum AxisOfRotation
  {
    X,
    Y,
    Z,
  }
}
