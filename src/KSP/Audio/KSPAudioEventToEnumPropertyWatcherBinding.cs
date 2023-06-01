// Decompiled with JetBrains decompiler
// Type: KSP.Audio.KSPAudioEventToEnumPropertyWatcherBinding
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
      [Tooltip("The name of the specific enum value")]
      [HideInInspector]
      public string Name;
      [HideInInspector]
      public int TargetInt;
      public AK.Wwise.Event[] TargetEvents;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public IntToAudioEventListBinding() => throw null;
    }
  }
}
