// Decompiled with JetBrains decompiler
// Type: KSCBuildingAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class KSCBuildingAudio : MonoBehaviour
{
  [NonReorderable]
  public Event[] onBuildingHighlightedStart;
  [NonReorderable]
  public Event[] onBuildingHighlightedStop;
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
