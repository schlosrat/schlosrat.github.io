// Decompiled with JetBrains decompiler
// Type: RTG.ColorTransition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
  public class ColorTransition
  {
    private ColorRef _colorRef;
    private Color _fadeInColor;
    private Color _fadeOutColor;
    private ColorTransition.State _state;
    private float _durationInSeconds;
    private float _elapsedTimeInSeconds;
    private bool _isActive;

    public event ColorTransition.ColorTransitionBeginHandler TransitionBegin
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public event ColorTransition.ColorTransitionEndHandler TransitionEnd
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public ColorTransition.State TransitionState
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Color FadeInColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Color FadeOutColor
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float DurationInSeconds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool IsActive
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColorTransition(ColorRef colorRef) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BeginFadeIn(bool startFromCurrentColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BeginFadeOut(bool startFromCurrentColor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(float elapsedTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void End() => throw null;

    public enum State
    {
      CompleteFadeIn,
      CompleteFadeOut,
      FadingIn,
      FadingOut,
      Ready,
    }

    public delegate void ColorTransitionBeginHandler(ColorTransition colorTransition);

    public delegate void ColorTransitionEndHandler(ColorTransition colorTransition);
  }
}
