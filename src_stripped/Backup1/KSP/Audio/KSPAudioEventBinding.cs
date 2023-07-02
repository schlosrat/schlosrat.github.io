// Decompiled with JetBrains decompiler
// Type: KSP.Audio.KSPAudioEventBinding
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
