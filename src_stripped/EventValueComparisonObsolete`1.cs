// Decompiled with JetBrains decompiler
// Type: EventValueComparisonObsolete`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventValueComparisonObsolete<T> : BaseGameEventObsolete
{
  private List<EventValueComparisonObsolete<T>.EvtDelegate> events;
  private List<EventValueComparisonObsolete<T>.EvtDelegate> eventsClone;
  private T defaultValue;
  private EventValueComparisonObsolete<T>.OnCompare comparer;

  public T value
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventValueComparisonObsolete(
    string eventName,
    T defaultValue,
    EventValueComparisonObsolete<T>.OnCompare comparer)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventValueComparisonObsolete<T>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventValueComparisonObsolete<T>.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Update() => throw null;

  private class EvtDelegate
  {
    public EventValueComparisonObsolete<T>.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventValueComparisonObsolete<T>.OnEvent evt) => throw null;
  }

  public delegate bool OnCompare(T a, T b);

  public delegate T OnEvent();
}
