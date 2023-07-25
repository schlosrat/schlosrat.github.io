// Decompiled with JetBrains decompiler
// Type: KSP.UI.TutorialFullScreenVideo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.UserInterface;
using KSP.Video;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.UI
{
  [PrefabName("TutorialFullScreenVideo.prefab")]
  public class TutorialFullScreenVideo : KSP2UIWindow
  {
    [Space(5f)]
    [SerializeField]
    private LocalizedVideoPlayer player;
    private System.Type OnPlaybackFinished;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPlaybackDone() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Show(string scriptablePath = null, System.Type eventTypeDismiss = null, bool showCrontrols = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IMissionAction DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TutorialFullScreenVideo() => throw null;
  }
}
