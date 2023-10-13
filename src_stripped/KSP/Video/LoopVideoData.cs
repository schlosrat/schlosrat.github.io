// Decompiled with JetBrains decompiler
// Type: KSP.Video.LoopVideoData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Video;

namespace KSP.Video
{
  [CreateAssetMenu(fileName = "New_LoopVideo", menuName = "Video/LoopVideo", order = 101)]
  [Serializable]
  public class LoopVideoData : ScriptableObject
  {
    [SerializeField]
    private string _title;
    [SerializeField]
    [TextArea(4, 8)]
    private string _description;
    [SerializeField]
    private LoopVideoType _loopVideoType;
    [SerializeField]
    private VideoClip _videoClip;
    [SerializeField]
    [Range(0.0f, 10f)]
    private float _videoPlaybackSpeed;
    [SerializeField]
    private Sprite[] _gif;
    [Tooltip("Frames FPS")]
    [SerializeField]
    private float _gifFPS;
    [SerializeField]
    [Space]
    private Sprite _preview;

    public string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public LoopVideoType LoopVideoType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VideoClip VideoClip
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float VidepPlaybackSpeed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite[] Gif
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float GifFramesPerSeconds
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Sprite Preview
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LoopVideoData() => throw null;
  }
}
