// Decompiled with JetBrains decompiler
// Type: StagingAutomaticStagingDriverRuleBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
