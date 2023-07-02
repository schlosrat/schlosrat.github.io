// Decompiled with JetBrains decompiler
// Type: KSCBuildingAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class KSCBuildingAudio : MonoBehaviour
{
  [NonReorderable]
  public AK.Wwise.Event[] onBuildingHighlightedStart;
  [NonReorderable]
  public AK.Wwise.Event[] onBuildingHighlightedStop;
  private bool _hasAudioObject;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void PlayHover() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void StopHover() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSCBuildingAudio() => throw null;
}
