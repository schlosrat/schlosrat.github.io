// Decompiled with JetBrains decompiler
// Type: TestLoopVideoPlayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Video;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TestLoopVideoPlayer : MonoBehaviour
{
  [SerializeField]
  [Header("Use context menu to play with selections")]
  private LoopVideoPlayer loopVideoPlayer;
  [SerializeField]
  private LoopVideoData videoData;
  [SerializeField]
  private Vector2 imageSize;
  [SerializeField]
  private string addressablePrefabPath;
  [SerializeField]
  private string addressableDataPath;

  [ContextMenu("PlayVideoData")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private void PlayVideoData() => throw null;

  [ContextMenu("StopVideoData")]
  [MethodImpl(MethodImplOptions.NoInlining)]
  private void StopVideoData() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TestLoopVideoPlayer() => throw null;
}
