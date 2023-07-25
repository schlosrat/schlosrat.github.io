// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.OtherTutorialLastStageCompleted
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/MissionData/OtherTutorialLastStageCompleted", false, "Returns the last Tutorial mission stage completed index.", "")]
  public class OtherTutorialLastStageCompleted : MissionDataPropertyWatcher
  {
    private string _cachedMissionID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetValueInt(string missionIDKey, string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OtherTutorialLastStageCompleted() => throw null;
  }
}
