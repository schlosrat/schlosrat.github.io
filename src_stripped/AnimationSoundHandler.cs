// Decompiled with JetBrains decompiler
// Type: AnimationSoundHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
