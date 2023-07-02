// Decompiled with JetBrains decompiler
// Type: KSP.Audio.KSPAudioEventToEnumPropertyWatcherBinding
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
  public class KSPAudioEventToEnumPropertyWatcherBinding : BasePropertyWatcherBinding
  {
    [HideInInspector]
    public string TargetPropertyWatcherClassName;
    public List<KSPAudioEventToEnumPropertyWatcherBinding.IntToAudioEventListBinding> EventsToEnumBindings;
    private PropertyWatcher targetPropertyWatcher;
    private Dictionary<int, List<AK.Wwise.Event>> EventsByEnumLookupTable;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Subscribe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Unsubscribe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PollPropertyWatcher() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnPropertyWatcherChange(int curEnumAsInt) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSPAudioEventToEnumPropertyWatcherBinding() => throw null;

    [Serializable]
    public class IntToAudioEventListBinding
    {
      [HideInInspector]
      [Tooltip("The name of the specific enum value")]
      public string Name;
      [HideInInspector]
      public int TargetInt;
      public AK.Wwise.Event[] TargetEvents;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IntToAudioEventListBinding() => throw null;
    }
  }
}
