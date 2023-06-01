// Decompiled with JetBrains decompiler
// Type: VideoLanguageTrackManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Experimental.Audio;
using UnityEngine.Video;

public class VideoLanguageTrackManager : MonoBehaviour
{
  [Tooltip("Connect the Video Player Component you want this component to manage.")]
  [SerializeField]
  private VideoPlayer videoPlayer;
  private List<VideoLanguageTrackManager.ManagedTrackInfo> audioTrackInfoList;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private bool ShouldDisableSelfCheck() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void OnLanguageChange() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator ChangeVideoLanguage() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public VideoLanguageTrackManager() => throw null;

  private struct ManagedTrackInfo
  {
    public float[][] AudioBuffers;
    public int[] ChannelReadPositionArray;
    public int SampleRate;
    public int BufferSize;
    public AudioSampleProvider AudioProvider;
    public Stopwatch BufferStopWatch;
    public Stopwatch[] WwiseStopWatches;
    public uint[] WWiseEventIDs;
    public uint[] WWiseAudioIDs;
    public int ChannelCount;
    public AudioSampleProvider.SampleFramesHandler BufferFeeder;
    public AkAudioInputManager.AudioSamplesDelegate WwiseFeeder;
    public uint ID_Mono;
    public uint ID_Left;
    public uint ID_Right;
    private const string wwiseEventName_Mono = "Play_Video_Audio_Input";
    private const string wwiseEventName_Left = "Play_Video_Audio_Input_L";
    private const string wwiseEventName_Right = "Play_Video_Audio_Input_R";
    public static object WWiseBufferLock;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManagedTrackInfo(AudioSampleProvider _provider) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildBufferForWwise(AudioSampleProvider provider, uint sampleFrameCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool WWiseSampleDelegate(uint playingID, uint channelIndex, float[] samples) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ManagedTrackInfo() => throw null;
  }
}
