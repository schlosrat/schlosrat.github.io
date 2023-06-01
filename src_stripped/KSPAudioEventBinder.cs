// Decompiled with JetBrains decompiler
// Type: KSPAudioEventBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class KSPAudioEventBinder : MonoBehaviour
{
  [NonReorderable]
  public KSPAudioEventBinder.BoundEvent[] EventBindings;
  public bool ForceControlKey;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPAudioEventBinder() => throw null;

  [Serializable]
  public class BoundEvent
  {
    public AK.Wwise.Event audioEvent;
    public KeyCode keyCode;
    public bool hasFired;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundEvent() => throw null;
  }
}
