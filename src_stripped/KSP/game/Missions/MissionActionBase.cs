// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionActionBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Game.Missions.Definitions;
using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  public class MissionActionBase
  {
    [JsonProperty]
    public string StageEvent;
    [JsonIgnore]
    protected MissionData ParentMissionData;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IMissionAction DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionActionBase() => throw null;
  }
}
