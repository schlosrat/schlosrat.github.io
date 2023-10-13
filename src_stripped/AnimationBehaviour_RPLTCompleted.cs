// Decompiled with JetBrains decompiler
// Type: AnimationBehaviour_RPLTCompleted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimationBehaviour_RPLTCompleted : StateMachineBehaviour
{
  [SerializeField]
  private bool _triggerOnStateEnter;
  [SerializeField]
  private bool _triggerOnStateExit;
  [SerializeField]
  private bool _triggerAtPercentThroughState;
  [SerializeField]
  [Range(0.0f, 1f)]
  private float _percentageThroughStateToTrigger;
  private bool _initialized;
  private bool _hasTriggeredOnUpdateSinceStateEnter;
  private RandomPrefabLoader_Target _rplt;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateUpdate(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool TryToInitialize(Animator animator) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InvokeOnComplete(Animator animator) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AnimationBehaviour_RPLTCompleted() => throw null;
}
