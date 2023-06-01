// Decompiled with JetBrains decompiler
// Type: KSP.Audio.KSPAudioRTPCToNumericalPropertyWatcherBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Messages.PropertyWatchers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Audio
{
  [Serializable]
  public class KSPAudioRTPCToNumericalPropertyWatcherBinding : BasePropertyWatcherBinding
  {
    [HideInInspector]
    public string TargetPropertyWatcherClassName;
    public List<string> TargetRTPCs;
    private PropertyWatcher targetPropertyWatcher;
    private Dictionary<string, uint> RTPCIDLookUpTable;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Subscribe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Unsubscribe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PollPropertyWatcher() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPropertyWatcherChange(double newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPropertyWatcherChange(int newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnPropertyWatcherChange(bool newValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSPAudioRTPCToNumericalPropertyWatcherBinding() => throw null;
  }
}
