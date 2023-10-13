// Decompiled with JetBrains decompiler
// Type: StagingAutomaticStagingDriverRulePartEngine
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.OAB;
using System.Runtime.CompilerServices;

public abstract class StagingAutomaticStagingDriverRulePartEngine : 
  StagingAutomaticStagingDriverRuleStageTypeFilter
{
  protected bool WasHandledByEngineRule
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected StagingAutomaticStagingDriverRulePartEngine(
    ContextListProperty<StageDataContext> stagingStack,
    AssemblyPartStageType stageType)
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
