// Decompiled with JetBrains decompiler
// Type: ThrottleAnimatorData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
