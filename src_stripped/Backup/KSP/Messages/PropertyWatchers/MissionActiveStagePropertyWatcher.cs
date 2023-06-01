// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.MissionActiveStagePropertyWatcher
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/MissionData/MissionActiveStage", false, "Returns true or false if the active mission current stage passes the passed in value.", "")]
  public class MissionActiveStagePropertyWatcher : MissionDataPropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetValueInt(string missionIDKey, string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionActiveStagePropertyWatcher() => throw null;
  }
}
