// Decompiled with JetBrains decompiler
// Type: EventDataObsolete`4
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventDataObsolete<T, U, V, W> : BaseGameEventObsolete
{
  private List<EventDataObsolete<T, U, V, W>.EvtDelegate> events;
  private List<EventDataObsolete<T, U, V, W>.EvtDelegate> eventsClone;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventDataObsolete(string eventName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventDataObsolete<T, U, V, W>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventDataObsolete<T, U, V, W>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Fire(T data0, U data1, V data2, W data3) => throw null;

  private class EvtDelegate
  {
    public EventDataObsolete<T, U, V, W>.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventDataObsolete<T, U, V, W>.OnEvent evt) => throw null;
  }

  public delegate void OnEvent(T data0, U data1, V data2, W data3);
}
