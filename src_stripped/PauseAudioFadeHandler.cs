// Decompiled with JetBrains decompiler
// Type: PauseAudioFadeHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
