// Decompiled with JetBrains decompiler
// Type: KSP.Messages.MessageCenter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Messages
{
  public class MessageCenter : MonoBehaviour, IMessageCenter
  {
    private readonly Dictionary<System.Type, List<SubscriptionHandle>> _subscriptions;
    private readonly Dictionary<System.Type, Stack<MessageCenterMessage>> _cachedMessages;
    private readonly List<System.Type> _unsubscribedThisFrame;
    private const string ERROR_MESSAGE_NO_SUBSCRIBER = "Publishing message with no subscriber.";
    private int _maxPoolSize;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Awake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Publish<T>() where T : MessageCenterMessage, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Publish<TMessage>(TMessage message) where TMessage : MessageCenterMessage => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Publish(System.Type type, MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RecycleMessage<TMessage>(TMessage message) where TMessage : MessageCenterMessage => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubscriptionHandle Subscribe<TMessage>(Action<MessageCenterMessage> callback) where TMessage : MessageCenterMessage => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubscriptionHandle Subscribe(
      System.Type type,
      Action<MessageCenterMessage> callback,
      bool isFinite = false,
      bool isPersistent = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubscriptionHandle FiniteSubscribe<TMessage>(Action<MessageCenterMessage> callback) where TMessage : MessageCenterMessage => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubscriptionHandle PersistentSubscribe<TMessage>(Action<MessageCenterMessage> callback) where TMessage : MessageCenterMessage => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unsubscribe(ref SubscriptionHandle handle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Unsubscribe<TMessage>(Action<MessageCenterMessage> associatedCallback) where TMessage : MessageCenterMessage => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MessageCenterMessage CreateMessage(System.Type type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public T CreateMessage<T>() where T : MessageCenterMessage, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool TryCreateMessage<T>(out T msg) where T : MessageCenterMessage, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RemovePendingUnsubscriptions() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MessageCenter() => throw null;
  }
}
