// Decompiled with JetBrains decompiler
// Type: KSP.Video.PlaybackController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Inspector;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Video
{
  public abstract class PlaybackController : MonoBehaviour
  {
    [Header("what controllable are we interacting with?")]
    [ValidateObjectField(typeof (IPlaybackControllable), true)]
    [SerializeField]
    private GameObject m_playbackControl;

    public IPlaybackControllable PlaybackControllable
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetControl(IPlaybackControllable controllable) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected abstract void HandlePlaybackStateDataChanged(PlaybackStateData state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected PlaybackController() => throw null;
  }
}
