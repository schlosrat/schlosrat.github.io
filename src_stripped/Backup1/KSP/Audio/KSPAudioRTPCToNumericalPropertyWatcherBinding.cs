// Decompiled with JetBrains decompiler
// Type: KSP.Audio.KSPAudioRTPCToNumericalPropertyWatcherBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
