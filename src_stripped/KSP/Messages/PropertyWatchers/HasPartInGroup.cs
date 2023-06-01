// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.HasPartInGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/HasPartInGroup", false, "Allows us to check if a vessel has a specific part in the VAB family grouping.", "")]
  public class HasPartInGroup : VehiclePropertyWatcher
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public override Type baseType() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void MissionStageActivated(string missionID, string inputValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void MissionStageDeactivated(string missionID, string inputValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool GetValueBool(string missionID, string value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public HasPartInGroup() => throw null;
  }
}
