// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.MissionRewardDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions.Definitions
{
  [Serializable]
  public class MissionRewardDefinition
  {
    public MissionRewardType MissionRewardType;
    public float RewardAmount;
    public string RewardKey;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionRewardDefinition DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionRewardDefinition() => throw null;
  }
}
