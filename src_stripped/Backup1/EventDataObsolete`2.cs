// Decompiled with JetBrains decompiler
// Type: EventDataObsolete`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventDataObsolete<T, U> : BaseGameEventObsolete
{
  private List<EventDataObsolete<T, U>.EvtDelegate> events;
  private List<EventDataObsolete<T, U>.EvtDelegate> eventsClone;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventDataObsolete(string eventName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventDataObsolete<T, U>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventDataObsolete<T, U>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Fire(T data0, U data1) => throw null;

  private class EvtDelegate
  {
    public EventDataObsolete<T, U>.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventDataObsolete<T, U>.OnEvent evt) => throw null;
  }

  public delegate void OnEvent(T data0, U data1);
}
