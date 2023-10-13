// Decompiled with JetBrains decompiler
// Type: AnimationBehaviour_SetAnimTreeParameter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class AnimationBehaviour_SetAnimTreeParameter : StateMachineBehaviour
{
  [SerializeField]
  protected AnimationBehaviour_SetAnimTreeParameter.ParamData[] parameterList;
  protected CoroutineUtil coroutineAccess;
  protected Coroutine delayCoroutine;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected IEnumerator SetValueCoroutine(
    Animator animator,
    string paramName,
    float paramValue,
    float delay)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected abstract void SetValue(Animator animator, string paramName, float paramValue) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected AnimationBehaviour_SetAnimTreeParameter() => throw null;

  [Serializable]
  protected class ParamData
  {
    public string paramName;
    public bool onStateEnter;
    [Tooltip("MAKE SURE THIS VALUE MATCHES THE TYPE YOU WANT FROM THE COMPONENT YOU CHOOSE.\nSetFloat: This is already a float, so no issue\nSetInteger: This will auto convert any float to an integer\nSetBool: If your value isn't 0 or 1, it will error\nSetTrigger: This value is just ignored")]
    public float enterValue;
    [Range(0.0f, 1f)]
    public float enterDelay;
    [Space(5f)]
    public bool onStateExit;
    [Tooltip("MAKE SURE THIS VALUE MATCHES THE TYPE YOU WANT FROM THE COMPONENT YOU CHOOSE.\nSetFloat: This is already a float, so no issue\nSetInteger: This will auto convert any float to an integer\nSetBool: If your value isn't 0 or 1, it will error\nSetTrigger: This value is just ignored")]
    public float exitValue;
    [Range(0.0f, 1f)]
    public float exitDelay;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ParamData() => throw null;
  }
}
