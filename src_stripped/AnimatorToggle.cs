// Decompiled with JetBrains decompiler
// Type: AnimatorToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class AnimatorToggle : MonoBehaviour
{
  [SerializeField]
  private Animator animator;
  [Tooltip("List of GameObjects that exist as children of this GameObject that will be turned ON/OFF Immediately, when toggled.")]
  [SerializeField]
  private AnimatorToggle.ToggleInfo[] gameObjectsToToggle;
  [SerializeField]
  [Tooltip("The name of the bool parameter inside your animator that is used to toggle states and animate the rig.")]
  private string toggleStateName;
  private bool currentToggleState;
  private Coroutine toggleDelayCoroutine;

  public bool IsToggleOn
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Toggle() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetActive(bool overrideToggle) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator ToggleAtEndOfAnimation(bool isOn) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void ToggleListedGameObjects(
    AnimatorToggle.ToggleInfo[] listedGameObjects,
    bool toggle,
    bool immediately)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AnimationClip[] GetAnimationClips() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AnimatorToggle() => throw null;

  [Serializable]
  internal class ToggleInfo
  {
    [FormerlySerializedAs("gameObject")]
    public GameObject GameObjectToToggle;
    [Tooltip("If Off, will toggle ON at end of animation")]
    public bool ToggleOnImmediately;
    [Tooltip("If Off, will toggle OFF at end of animation")]
    public bool ToggleOffImmediately;
    [Tooltip("Set this to TRUE if you want this GameObject to enable/disable INVERSELY to the norm.")]
    public bool IsToggleInverted;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ToggleInfo() => throw null;
  }
}
