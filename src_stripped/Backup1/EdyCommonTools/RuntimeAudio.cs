// Decompiled with JetBrains decompiler
// Type: EdyCommonTools.RuntimeAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace EdyCommonTools
{
  public class RuntimeAudio
  {
    private Transform m_transform;
    private AudioSource m_audioSource;
    private AudioLowPassFilter m_lowPassFilter;

    public AudioSource source
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public AudioLowPassFilter lowPassFilter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public RuntimeAudio(Transform transform, bool lazyAudioSourceCreation = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Release() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void SetVolumeRolloff(
      AudioSource source,
      float minDistance,
      float maxVolume,
      float attenuationDistance,
      float attenuatedVolume,
      float maxDistance,
      float minVolume = 0.0f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateAudioSource() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void CreateLowPassFilter() => throw null;
  }
}
