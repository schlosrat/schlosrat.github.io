// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.OtherMissionLastStageCompleted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Missions.Definitions;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/MissionData/OtherMissionLastStageCompleted", false, "Returns the last FTUE mission stage completed index.", "")]
  public class OtherMissionLastStageCompleted : MissionDataPropertyWatcher
  {
    private string _cachedMissionID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetValueInt(MissionData missionData, string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OtherMissionLastStageCompleted() => throw null;
  }
}
