// Decompiled with JetBrains decompiler
// Type: KSP.Messages.SelectedDiscoverableMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Messages
{
  [Serializable]
  public struct SelectedDiscoverableMessage
  {
    [SerializeField]
    private string _discoveryName;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectedDiscoverableMessage(string messageDiscoveryName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SelectedDiscoverableMessage(System.Type discoverableMessageType) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeForType<T>() where T : MessageCenterMessage, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public System.Type GetStoredType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PublishFromMessageCenter(MessageCenter messageCenter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SelectedDiscoverableMessage CreateFor<T>() where T : MessageCenterMessage, new() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SelectedDiscoverableMessage CreateFor(string discoveryName) => throw null;
  }
}
