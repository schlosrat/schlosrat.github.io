// Decompiled with JetBrains decompiler
// Type: EventDoubleMaxObsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
