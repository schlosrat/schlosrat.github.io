// Decompiled with JetBrains decompiler
// Type: KSP.Game.Missions.Definitions.CompletedStages
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Runtime.CompilerServices;

namespace KSP.Game.Missions.Definitions
{
  [Serializable]
  public class CompletedStages
  {
    [NonSerialized]
    public const int[] DEFAULT_STAGE_IDS = null;
    [NonSerialized]
    public const int DEFAULT_CURRENT_STAGE_INDEX = 0;
    public int PlayerId;
    public int[] StageIds;
    public int CurrentStageIndex;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CompletedStages() => throw null;
  }
}
