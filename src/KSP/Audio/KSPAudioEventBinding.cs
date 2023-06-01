// Decompiled with JetBrains decompiler
// Type: KSP.Audio.KSPAudioEventBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Messages;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Audio
{
  [Serializable]
  public class KSPAudioEventBinding
  {
    [SerializeField]
    public string name;
    [SerializeField]
    public string targetTypeAQN;
    [SerializeField]
    [NonReorderable]
    public AK.Wwise.Event[] wwiseEvents;
    private MessageCenter DebugMessageCenter;
    private SubscriptionHandle subscription;

    private GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Subscribe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unsubscribe() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void MessageHandler(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public KSPAudioEventBinding() => throw null;
  }
}
