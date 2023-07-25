// Decompiled with JetBrains decompiler
// Type: KSPPartAudioRTPCs.KSPPartAudioRTPCBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSPPartAudioRTPCs
{
  [Serializable]
  public class KSPPartAudioRTPCBase
  {
    public string _rtpcName;
    public string _objectName;
    protected float _rtpcValueCached;
    protected Dictionary<GameObject, float> _rtpcValueCachedMap;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected KSPPartAudioRTPCBase() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Update(
      KSPPartAudioBase partAudio,
      ref Dictionary<uint, float> cache,
      VesselBehavior vessel,
      PartBehavior partBehavior)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void SetRTPC(
      uint rtpc,
      ref Dictionary<uint, float> cache,
      float value,
      GameObject gameObject)
    {
      throw null;
    }
  }
}
