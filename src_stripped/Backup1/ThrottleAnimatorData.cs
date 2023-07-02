// Decompiled with JetBrains decompiler
// Type: ThrottleAnimatorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ThrottleAnimatorData : KerbalMonoBehaviour, IEngineFXData
{
  public string ThrottleParamNameInAnimator;
  public float ValueAtMinThrottle;
  public float ValueAtMaxThrottle;
  public AnimationCurve ValueCurve;
  [Space(10f)]
  public bool DoLerpValue;
  [Tooltip("Speed is in 'Value Units' per second")]
  public float LerpSpeed;
  private Animator _animator;
  private float _rawValueRange;
  private float _curValue;
  private float _curLerpThrust;
  private float _lastValue;

  public Action<float, float, float, Vector3> TriggerUpdateVisuals
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ToggleVisibility(bool doTurnOn, ParticleSystemStopBehavior stopBehaviour = ParticleSystemStopBehavior.StopEmitting) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsVisible() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateVisuals(
    float curThrust,
    float curAtmo,
    float curAngleVel,
    Vector3 curAccelerationDir)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float GetValueOnCurve(float xValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ThrottleAnimatorData() => throw null;
}
