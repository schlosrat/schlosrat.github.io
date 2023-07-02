// Decompiled with JetBrains decompiler
// Type: SplashScreensManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
  [Tooltip("Set the first animation to be displayed.")]
  [SerializeField]
  private DOTweenAnimation _firstScreenAnimation;
  [Tooltip("Percentage in which the animations time scale will be multiplied duration will be reduced")]
  [SerializeField]
  private float onSkipAnimationTimeMultiplier;
  [Tooltip("Input we wish to use for being able to skip the splash screens")]
  [SerializeField]
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
