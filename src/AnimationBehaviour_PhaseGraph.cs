// Decompiled with JetBrains decompiler
// Type: AnimationBehaviour_PhaseGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Serialization;

public class AnimationBehaviour_PhaseGraph : StateMachineBehaviour
{
  [Tooltip("The name of the variable that represents the phase percentage goal float in the Anim Tree.")]
  [SerializeField]
  private string phaseGoalName;
  [SerializeField]
  [FormerlySerializedAs("phaseChangeSpeed")]
  [Tooltip("Time in seconds to travel from one extreme to the other. Bigger is slower.")]
  private float phaseChangeTime;
  [Tooltip("If on, will set the initial position of the phase graph to whatever the first goal is.")]
  [SerializeField]
  private bool setInitialPositionOnFirstFrame;
  [Tooltip("If on, will pick the shortest distance between current and goal value, even if that would wrap around from 0 to 1")]
  [SerializeField]
  private bool supportLooping;
  [SerializeField]
  [Tooltip("The Name of the Game Object to act as the source of the sounds. Will default to the root of the object if left empty or not found.")]
  private string AudioCall_Source_Name;
  [Tooltip("When the phasegraph was stopped, and starts transitioning from a LOWER number to a HIGHER number, this sound will play.")]
  [SerializeField]
  private string AudioCall_Forward_Starting;
  [SerializeField]
  [Tooltip("When the phasegraph reaches its goal, from a LOWER number to a HIGHER number, this sound will play.")]
  private string AudioCall_Forward_Stopping;
  [SerializeField]
  [Tooltip("When the phasegraph was stopped, and starts transitioning from a HIGHER number to a LOWER number, this sound will play.")]
  private string AudioCall_Backward_Starting;
  [SerializeField]
  [Tooltip("When the phasegraph reaches its goal, from a HIGHER number to a LOWER number, this sound will play.")]
  private string AudioCall_Backward_Stopping;
  private float percentagePosition;
  private float floatAccuracyBuffer;
  private GameObject goToPlaySoundFrom;
  private bool isGoingForward;
  private bool previouslyGoingForward;
  private bool isAtRest;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override void OnStateUpdate(
    Animator animator,
    AnimatorStateInfo stateInfo,
    int layerIndex,
    AnimatorControllerPlayable controller)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PlayPhasegraphAudio(Animator curAnimator) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AnimationBehaviour_PhaseGraph() => throw null;
}
