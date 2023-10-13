// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionSaveData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions.Definitions
{
  [Serializable]
  public class MissionSaveData
  {
    public string MissionID;
    public KSP.Game.Missions.Definitions.CompletedStages[] CompletedStages;
    public bool IsActive;
    public bool Available;
    public bool Completed;
    public bool TurnedIn;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static KSP.Game.Missions.Definitions.CompletedStages[] GetDefaultCompletedStages() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionSaveData() => throw null;
  }
}
