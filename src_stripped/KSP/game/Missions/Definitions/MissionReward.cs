// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionReward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions.Definitions
{
  [Serializable]
  public class MissionReward
  {
    public List<MissionRewardDefinition> _missionRewardDefinitions;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionReward() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private MissionReward(int capacity) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddDefinition(MissionRewardDefinition missionRewardDefinition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveLastDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionReward DeepCopy() => throw null;
  }
}
