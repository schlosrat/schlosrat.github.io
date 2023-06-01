// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.MissionActionBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using Newtonsoft.Json;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions
{
  public class MissionActionBase
  {
    [JsonProperty]
    public string StageEvent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Activate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual IMissionAction DeepCopy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MissionActionBase() => throw null;
  }
}
