// Decompiled with JetBrains decompiler
// Type: PauseAudioFadeHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PauseAudioFadeHandler : MonoBehaviour
{
  public AudioSource Source;
  private AudioClip pausedClip;
  private float pausedVolume;
  private bool pausedLoop;
  private float pausedTime;
  private Coroutine fadeRoutine;

  [HideInInspector]
  public bool IsPaused
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [HideInInspector]
  public bool IsFading
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void PauseWithFade(
    float fadeDuration,
    AudioClip fadeClip,
    float fadeClipVolume,
    float fadeClipTime,
    bool fadeClipLoop)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator PauseWithFadeRoutine(
    AudioSource fadeSource,
    float fadeDuration,
    AudioClip fadeClip,
    float fadeClipVolume,
    float fadeClipTime,
    bool fadeClipLoop)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UnpauseWithFade() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PauseAudioFadeHandler() => throw null;
}
