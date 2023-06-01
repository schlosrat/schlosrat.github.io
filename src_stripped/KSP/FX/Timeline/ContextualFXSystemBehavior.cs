// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.ContextualFXSystemBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Playables;

namespace KSP.FX.Timeline
{
  [Serializable]
  public class ContextualFXSystemBehavior : PlayableBehaviour
  {
    private bool active;
    [HideInInspector]
    public ContextualFXSystemData CFXData;

    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private MessageCenter Messages
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Activate(SequenceControllerComponent controller) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Deactivate(SequenceControllerComponent controller) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ContextualFXSystemBehavior() => throw null;
  }
}
