// Decompiled with JetBrains decompiler
// Type: StagingAutomaticStagingDriverRuleStageTypeFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.OAB;
using System;
using System.Runtime.CompilerServices;

public class StagingAutomaticStagingDriverRuleStageTypeFilter : StagingAutomaticStagingDriverRuleBase
{
  private AssemblyPartStageType StageType
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  private Func<ContextListProperty<StageDataContext>, IObjectAssemblyPart, int> SuccessSuggestedStageFunc
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public StagingAutomaticStagingDriverRuleStageTypeFilter(
    ContextListProperty<StageDataContext> stagingStack,
    AssemblyPartStageType stageType,
    Func<ContextListProperty<StageDataContext>, IObjectAssemblyPart, int> successSuggestedStageFunc)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public override bool TryGetSuggestedStageIndex(
    IObjectAssemblyPart part,
    ref int suggestedStageIndex)
  {
    throw null;
  }
}
