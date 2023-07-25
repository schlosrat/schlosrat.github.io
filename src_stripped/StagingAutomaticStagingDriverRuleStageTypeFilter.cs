// Decompiled with JetBrains decompiler
// Type: StagingAutomaticStagingDriverRuleStageTypeFilter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
