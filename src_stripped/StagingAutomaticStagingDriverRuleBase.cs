// Decompiled with JetBrains decompiler
// Type: StagingAutomaticStagingDriverRuleBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.OAB;
using System.Runtime.CompilerServices;

public abstract class StagingAutomaticStagingDriverRuleBase : IStagingAutomaticStagingDriverRule
{
  protected ContextListProperty<StageDataContext> StagingStack
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected StagingAutomaticStagingDriverRuleBase(ContextListProperty<StageDataContext> stagingStack) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public abstract bool TryGetSuggestedStageIndex(
    IObjectAssemblyPart part,
    ref int suggestedStageIndex)
  {
    throw null;
  }
}
