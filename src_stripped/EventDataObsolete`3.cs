﻿// Decompiled with JetBrains decompiler
// Type: EventDataObsolete`3
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventDataObsolete<T, U, V> : BaseGameEventObsolete
{
  private List<EventDataObsolete<T, U, V>.EvtDelegateObsolete> events;
  private List<EventDataObsolete<T, U, V>.EvtDelegateObsolete> eventsClone;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventDataObsolete(string eventName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventDataObsolete<T, U, V>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventDataObsolete<T, U, V>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Fire(T data0, U data1, V data2) => throw null;

  private class EvtDelegateObsolete
  {
    public EventDataObsolete<T, U, V>.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegateObsolete(EventDataObsolete<T, U, V>.OnEvent evt) => throw null;
  }

  public delegate void OnEvent(T data0, U data1, V data2);
}
