// Decompiled with JetBrains decompiler
// Type: KSCBuildingAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
