// Decompiled with JetBrains decompiler
// Type: AnimationBehaviour_RandomParamLerping
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Networking.MP.Utils;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class AnimationBehaviour_RandomParamLerping : StateMachineBehaviour
{
  private const float FLOAT_EPSILON = 0.0001f;
  [FormerlySerializedAs("_managedLerpData")]
  [SerializeField]
  private AnimationBehaviour_RandomParamLerping.LerpData[] _lerpData;
  private List<int> _managedLerpDataIndicies;
  private bool _initialized;
  private static readonly MPRandom _randomizer;
  private bool _isNormalGameRunning;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateUpdate(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init(Animator animator) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetRandomGoal(
    ref AnimationBehaviour_RandomParamLerping.LerpData data)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ResetGoalChangeTimer(
    ref AnimationBehaviour_RandomParamLerping.LerpData data)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateLerpParam(
    Animator animator,
    ref AnimationBehaviour_RandomParamLerping.LerpData data)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AnimVarFloatLerp(
    ref AnimationBehaviour_RandomParamLerping.LerpData data,
    Animator animator,
    int timewarpMul)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private float GetNextRandomFloatInRange(float min, float max) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool AreFloatsCloseEnough(float f1, float f2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AnimationBehaviour_RandomParamLerping() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static AnimationBehaviour_RandomParamLerping() => throw null;

  [Serializable]
  internal class LerpData
  {
    public static readonly AnimationCurve CURVE_LINEAR;
    public static readonly AnimationCurve CURVE_EASEIN;
    public static readonly AnimationCurve CURVE_EASEOUT;
    public static readonly AnimationCurve CURVE_EASEINOUT;
    [Tooltip("Name of float parameter in this anim tree")]
    public string Name;
    [Tooltip("Minimum float value the named parameter is allowed to reach")]
    public float Min;
    [Tooltip("Maximum float value the named parameter is allowed to reach")]
    public float Max;
    [Tooltip("Minimum wait time in seconds before the lerp goal will change during runtime")]
    public float ResetGoalDelayMin;
    [Tooltip("Maximum wait time in seconds before the lerp goal will change during runtime")]
    public float ResetGoalDelayMax;
    [Tooltip("Multiplier for how fast or slow to lerp toward the goal. 1.0 = 1 unit per second")]
    public float LerpSpeedMul;
    [Tooltip("Enum of lerp curve options. Used instead of just an editable curve to prevent user from making bad curves.")]
    public AnimationBehaviour_RandomParamLerping.LerpData.CurveTypes LerpCurveType;
    [HideInInspector]
    public float CurGoal;
    [HideInInspector]
    public int ParamHash;
    [HideInInspector]
    public float CurGoalChangeTimer;
    [HideInInspector]
    public float CurLinearValue;
    [HideInInspector]
    public float LerpStartValue;
    [HideInInspector]
    public float FullLerpDistance;
    [HideInInspector]
    public AnimationCurve LerpCurve;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LerpData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static LerpData() => throw null;

    public enum CurveTypes
    {
      EASEINOUT,
      EASEIN,
      EASEOUT,
      LINEAR,
    }
  }
}
