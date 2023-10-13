// Decompiled with JetBrains decompiler
// Type: MessageSubscriberForAnimators
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game;
using KSP.Messages;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MessageSubscriberForAnimators : KerbalMonoBehaviour
{
  [SerializeField]
  private List<MessageSubscriberForAnimators.MessageParamPairing> _pairings;
  private Animator _animator;
  private List<SubscriptionHandle> _subscriptionHandlers;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Awake() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnEnable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDisable() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitializeSubscriptions() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SubscribeParamChangeToMessage(
    MessageSubscriberForAnimators.MessageParamPairing messageParamPair)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UnsubscribeAll() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public MessageSubscriberForAnimators() => throw null;

  [Serializable]
  internal class MessageParamPairing
  {
    public SelectedDiscoverableMessage Message;
    public string ParamName;
    public AnimatorVariableRandomizer.AnimatorVariableType ParamType;
    public float ParamValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MessageParamPairing() => throw null;
  }
}
