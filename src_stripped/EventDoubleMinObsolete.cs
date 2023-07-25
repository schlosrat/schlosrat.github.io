// Decompiled with JetBrains decompiler
// Type: EventDoubleMinObsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventDoubleMinObsolete : BaseGameEventObsolete
{
  private List<EventDoubleMinObsolete.EvtDelegate> events;
  private List<EventDoubleMinObsolete.EvtDelegate> eventsClone;
  public double defaultValue;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventDoubleMinObsolete(string eventName, double defaultValue = 0.0) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventDoubleMinObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventDoubleMinObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public double Fire() => throw null;

  private class EvtDelegate
  {
    public EventDoubleMinObsolete.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventDoubleMinObsolete.OnEvent evt) => throw null;
  }

  public delegate double OnEvent();
}
