// Decompiled with JetBrains decompiler
// Type: AnimationBehaviour_LayerWeightController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class AnimationBehaviour_LayerWeightController : StateMachineBehaviour
{
  [SerializeField]
  [Tooltip("Allows you to decide if this will be used on a State or an entire StateMachine, since the script can't figure that out automatically.")]
  private bool useStateMachineTriggers;
  [SerializeField]
  [Tooltip("If true, will restore managed layers to their original weights on exit.")]
  private bool restoreManagedLayersOnExit;
  [SerializeField]
  [Tooltip("Put the names of the layers you want this state to manage here.")]
  private string[] layersToControlByName;
  [Tooltip("How long should the transition of the above layer weights take, in seconds.")]
  [FormerlySerializedAs("startTransitionSpeed")]
  [SerializeField]
  private float defaultTransitionTime;
  [SerializeField]
  [Range(0.0f, 1f)]
  [Tooltip("What is the goal layer weight we want to set our managed layers to when this state is entered? 0-1.")]
  private float startGoalWeight;
  [Range(-1f, 1f)]
  [Tooltip("If between 0-1, and restoreManagedLayersOnExit is true, this will be used as the layer weight to restore managed layers to.")]
  [SerializeField]
  [Space(10f)]
  private float overrideExitLayerWeight;
  [SerializeField]
  [Tooltip("If >=0, and restoreManagedLayersOnExit is true, this will be used as the layer restoration transition time for all managed layers.")]
  private float overrideExitTransitionTime;
  private CoroutineUtil coroutineAccess;
  private List<AnimationBehaviour_LayerWeightController.AnimationLayerData> layersToControl;
  private AnimationUtility_ManagedLayersInfo managedLayers;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateMachineEnter(Animator animator, int stateMachinePathHash) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateMachineExit(Animator animator, int stateMachinePathHash) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Init(Animator animator) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitLayersToControl(Animator animator) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitManagedLayers(Animator animator) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ReplaceCoroutine(
    Animator animator,
    int layerIndex,
    float transitionTime,
    float goalWeight)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void ManageLayerWeightCoroutine(Animator animator, bool isExitTransition) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator TransitionLayerWeightCoroutine(
    Animator animator,
    int layerIndex,
    float transitionTime,
    float goalWeight)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AnimationBehaviour_LayerWeightController() => throw null;

  private struct AnimationLayerData
  {
    public string name;
    public int index;
    public float originalWeight;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AnimationLayerData(string _name, int _index, float _originalWeight) => throw null;
  }
}
