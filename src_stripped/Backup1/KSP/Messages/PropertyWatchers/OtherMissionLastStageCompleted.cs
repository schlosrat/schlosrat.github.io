// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.OtherMissionLastStageCompleted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
    public override int GetValueInt(string missionIDKey, string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OtherMissionLastStageCompleted() => throw null;
  }
}
