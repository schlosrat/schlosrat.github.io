// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.TimeOfDayPropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Game/TimeOfDay", false, "Time of day 24hrs format", "")]
  public class TimeOfDayPropertyWatcher : GamePropertyWatcher
  {
    private const float POLLING_INTERVAL = 0.5f;
    private float _lastTimeUpdate;
    private float _lastValue;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetValueDouble() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TimeOfDayPropertyWatcher() => throw null;
  }
}
