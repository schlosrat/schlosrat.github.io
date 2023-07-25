// Decompiled with JetBrains decompiler
// Type: SplashScreensManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using DG.Tweening;
using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class SplashScreensManager : MonoBehaviour
{
  [SerializeField]
  [Tooltip("Set the first animation to be displayed.")]
  private DOTweenAnimation _firstScreenAnimation;
  [SerializeField]
  [Tooltip("Percentage in which the animations time scale will be multiplied duration will be reduced")]
  private float onSkipAnimationTimeMultiplier;
  [SerializeField]
  [Tooltip("Input we wish to use for being able to skip the splash screens")]
  private InputActionReference skipSplashScreensInput;
  [SerializeField]
  private float safeGuardTimeToAutoDisableThis;
  private DOTweenAnimation _currentFadeInAnimation;
  private DOTweenAnimation _currentFadeOutAnimation;
  private bool _isFirstTimePlayed;
  private bool _resolvedCalled;
  private Action _resolveAction;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize(Action resolveAction, bool isFirstTimePlayed) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InputActionPerformed(InputAction.CallbackContext obj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void StartAnimations() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void PlayNextAnimation(DOTweenAnimation next) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResolveSplashScreens() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetCurrentFadeInPlaying(DOTweenAnimation doTweenAnim) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetCurrentFadeOutPlaying(DOTweenAnimation doTweenAnim) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ForcePlayNext() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator SafeGuardCo() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SplashScreensManager() => throw null;
}
