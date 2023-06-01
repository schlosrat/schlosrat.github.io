// Decompiled with JetBrains decompiler
// Type: KSP.Video.PlaybackControlEvent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace KSP.Video
{
  [Serializable]
  public class PlaybackControlEvent : UnityEvent<PlaybackStateData>
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PlaybackControlEvent() => throw null;
  }
}
