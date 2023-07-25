// Decompiled with JetBrains decompiler
// Type: AnimationBehaviour_PhaseGraph
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Serialization;

public class AnimationBehaviour_PhaseGraph : StateMachineBehaviour
{
  [SerializeField]
  [Tooltip("The name of the variable that represents the phase percentage goal float in the Anim Tree.")]
  private string phaseGoalName;
  [SerializeField]
  [Tooltip("Time in seconds to travel from one extreme to the other. Bigger is slower.")]
  [FormerlySerializedAs("phaseChangeSpeed")]
  private float phaseChangeTime;
  [Tooltip("If on, will set the initial position of the phase graph to whatever the first goal is.")]
  [SerializeField]
  private bool setInitialPositionOnFirstFrame;
  [Tooltip("If on, will pick the shortest distance between current and goal value, even if that would wrap around from 0 to 1")]
  [SerializeField]
  private bool supportLooping;
  [Tooltip("The Name of the Game Object to act as the source of the sounds. Will default to the root of the object if left empty or not found.")]
  [SerializeField]
  private string AudioCall_Source_Name;
  [SerializeField]
  [Tooltip("When the phasegraph was stopped, and starts transitioning from a LOWER number to a HIGHER number, this sound will play.")]
  private string AudioCall_Forward_Starting;
  [SerializeField]
  [Tooltip("When the phasegraph reaches its goal, from a LOWER number to a HIGHER number, this sound will play.")]
  private string AudioCall_Forward_Stopping;
  [SerializeField]
  [Tooltip("When the phasegraph was stopped, and starts transitioning from a HIGHER number to a LOWER number, this sound will play.")]
  private string AudioCall_Backward_Starting;
  [Tooltip("When the phasegraph reaches its goal, from a HIGHER number to a LOWER number, this sound will play.")]
  [SerializeField]
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
