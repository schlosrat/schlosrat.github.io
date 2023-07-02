// Decompiled with JetBrains decompiler
// Type: KSP.FX.Timeline.ContextualFXSystemBehavior
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
