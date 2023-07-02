// Decompiled with JetBrains decompiler
// Type: AnimationSoundHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AnimationSoundHandler : MonoBehaviour
{
  public List<AnimWwiseEvent> akEvents;
  public List<AnimWwiseState> akStates;
  public List<AnimWwiseSwitch> akSwitches;
  public GameObject AnimationEventsObject;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void PostAnimWWEvent(string eventName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void TriggerAkEvent(string eventKey) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void TriggerAkState(string eventKey) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected void TriggerAkSwitch(string eventKey) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public AnimationSoundHandler() => throw null;
}
