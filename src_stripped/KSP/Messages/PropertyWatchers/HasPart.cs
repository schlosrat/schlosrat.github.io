// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PropertyWatchers.HasPart
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Messages.PropertyWatchers
{
  [DiscoverableProperty("Properties/Vehicle/HasPart", false, "The vehicle has a specific part.", "")]
  public class HasPart : VehiclePropertyWatcher
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
    public HasPart() => throw null;
  }
}
