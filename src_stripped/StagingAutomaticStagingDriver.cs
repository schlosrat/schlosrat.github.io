// Decompiled with JetBrains decompiler
// Type: StagingAutomaticStagingDriver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Game;
using KSP.OAB;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class StagingAutomaticStagingDriver
{
  public List<IStagingAutomaticStagingDriverRule> Rules
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  private ContextListProperty<StageDataContext> StagingStack
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public StagingAutomaticStagingDriver(ContextListProperty<StageDataContext> stagingStack) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool TryGetSuggestedStageIndex(IObjectAssemblyPart part, out int suggestedStageIndex) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsDecouplerPart(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsStackDecouplerPart(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsGroundLaunchClampPart(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsFairingPart(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsEnginePart(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static bool IsRadiallyAttachedBooster(IObjectAssemblyPart part) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IObjectAssemblyPart GetNearestParent(
    IObjectAssemblyPart part,
    Func<IObjectAssemblyPart, bool> filterFunc)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static IObjectAssemblyPart GetNearestChild(
    IObjectAssemblyPart part,
    Func<IObjectAssemblyPart, bool> successFilter,
    Func<IObjectAssemblyPart, bool> traverseFilter = null)
  {
    throw null;
  }
}
