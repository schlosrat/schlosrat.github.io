// Decompiled with JetBrains decompiler
// Type: EventDoubleMaxObsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventDoubleMaxObsolete : BaseGameEventObsolete
{
  private List<EventDoubleMaxObsolete.EvtDelegate> events;
  private List<EventDoubleMaxObsolete.EvtDelegate> eventsClone;
  public double defaultValue;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventDoubleMaxObsolete(string eventName, double defaultValue = 0.0) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventDoubleMaxObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventDoubleMaxObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public double Fire() => throw null;

  private class EvtDelegate
  {
    public EventDoubleMaxObsolete.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventDoubleMaxObsolete.OnEvent evt) => throw null;
  }

  public delegate double OnEvent();
}
