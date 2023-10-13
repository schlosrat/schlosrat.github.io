// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.LocalizedVideoPlayerTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Video;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration
{
  public class LocalizedVideoPlayerTest : MonoBehaviour
  {
    public LocalizedVideoPlayer player;
    [Space]
    public LocalizedVideoData video1;
    public LocalizedVideoData video2;
    public LocalizedVideoData video3;
    [Space(order = 1)]
    [Header("Quick-n-dirty \"buttons\" - click to play", order = 2)]
    public bool buttonPlay1;
    public bool buttonPlay2;
    public bool buttonPlay3;
    [Space(order = 1)]
    [Header("Click to stop if already playing", order = 2)]
    public bool buttonClose;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Play1() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Play2() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Play3() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Close() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LocalizedVideoPlayerTest() => throw null;
  }
}
