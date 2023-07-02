// Decompiled with JetBrains decompiler
// Type: KSPAudioEventBinder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
