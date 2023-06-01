// Decompiled with JetBrains decompiler
// Type: SplashScreensManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using DG.Tweening;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SplashScreensManager : MonoBehaviour
{
  [Tooltip("Set the first animation to be displayed.")]
  [SerializeField]
  private DOTweenAnimation _firstScreenAnimation;
  private Action _resolveAction;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StartAnimations(Action resolve) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void PlayNextAnimation(DOTweenAnimation next) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResolveSplashScreens() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SplashScreensManager() => throw null;
}
