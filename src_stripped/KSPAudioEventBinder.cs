// Decompiled with JetBrains decompiler
// Type: KSPAudioEventBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using AK.Wwise;
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
    public Event audioEvent;
    public KeyCode keyCode;
    public bool hasFired;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoundEvent() => throw null;
  }
}
