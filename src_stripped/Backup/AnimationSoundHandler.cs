﻿// Decompiled with JetBrains decompiler
// Type: AnimationSoundHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
