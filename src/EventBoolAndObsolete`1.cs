// Decompiled with JetBrains decompiler
// Type: EventBoolAndObsolete`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventBoolAndObsolete<T> : BaseGameEventObsolete
{
  private List<EventBoolAndObsolete<T>.EvtDelegate> events;
  private List<EventBoolAndObsolete<T>.EvtDelegate> eventsClone;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventBoolAndObsolete(string eventName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventBoolAndObsolete<T>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventBoolAndObsolete<T>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool Fire(T data) => throw null;

  private class EvtDelegate
  {
    public EventBoolAndObsolete<T>.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventBoolAndObsolete<T>.OnEvent evt) => throw null;
  }

  public delegate bool OnEvent(T data);
}
