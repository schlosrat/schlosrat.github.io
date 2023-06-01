// Decompiled with JetBrains decompiler
// Type: SetLoadingOptimizationsFlowAction
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Game.Flow;
using KSP.Rendering;
using KSP.Sim.impl;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SetLoadingOptimizationsFlowAction : FlowAction
{
  private bool _enableOptimizations;
  private Camera _flowCamera;
  private Camera _flareCamera;
  private GameInstance _gameInstance;
  private UniverseCameraManager _camManager;
  private GraphicsManager _gameGraphicsManager;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SetLoadingOptimizationsFlowAction(bool enableOptimizations) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void InitReferences() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected override void DoAction(Action resolve, Action<string> reject) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SetOptimalCameraState(bool state) => throw null;
}
