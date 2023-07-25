// Decompiled with JetBrains decompiler
// Type: EventFloatMaxObsolete
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class EventFloatMaxObsolete : BaseGameEventObsolete
{
  private List<EventFloatMaxObsolete.EvtDelegate> events;
  private List<EventFloatMaxObsolete.EvtDelegate> eventsClone;
  public float defaultValue;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public EventFloatMaxObsolete(string eventName, float defaultValue = 0.0f) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Add(EventFloatMaxObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Remove(EventFloatMaxObsolete.OnEvent evt) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public float Fire() => throw null;

  private class EvtDelegate
  {
    public EventFloatMaxObsolete.OnEvent evt;
    public object originator;
    public string originatorType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EvtDelegate(EventFloatMaxObsolete.OnEvent evt) => throw null;
  }

  public delegate float OnEvent();
}
