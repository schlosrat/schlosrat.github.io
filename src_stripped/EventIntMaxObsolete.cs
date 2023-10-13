// Decompiled with JetBrains decompiler
// Type: EventIntMaxObsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventIntMaxObsolete : BaseGameEventObsolete
{
  private List<EventIntMaxObsolete.EvtDelegate> events;
  private List<EventIntMaxObsolete.EvtDelegate> eventsClone;
  public int defaultValue;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventIntMaxObsolete(string eventName, int defaultValue = 0) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventIntMaxObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventIntMaxObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public int Fire() => throw null;

  private class EvtDelegate
  {
    public EventIntMaxObsolete.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventIntMaxObsolete.OnEvent evt) => throw null;
  }

  public delegate int OnEvent();
}
