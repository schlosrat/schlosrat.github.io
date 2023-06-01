// Decompiled with JetBrains decompiler
// Type: EventDataModifierObsolete`2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventDataModifierObsolete<T, U> : BaseGameEventObsolete
{
  private List<EventDataModifierObsolete<T, U>.EvtDelegateObsolete> events;
  private List<EventDataModifierObsolete<T, U>.EvtDelegateObsolete> eventsClone;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private T DefaultModifier(T d1, U d2) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventDataModifierObsolete(string eventName) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventDataModifierObsolete<T, U>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventDataModifierObsolete<T, U>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public T Fire(T d1, U d2) => throw null;

  private class EvtDelegateObsolete
  {
    public EventDataModifierObsolete<T, U>.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegateObsolete(EventDataModifierObsolete<T, U>.OnEvent evt) => throw null;
  }

  public delegate T OnEvent(T d1, U d2);
}
