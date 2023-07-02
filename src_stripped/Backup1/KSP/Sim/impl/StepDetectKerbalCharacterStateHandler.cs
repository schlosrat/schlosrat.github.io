// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.StepDetectKerbalCharacterStateHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace KSP.Sim.impl
{
  public class StepDetectKerbalCharacterStateHandler : KerbalCharacterStateHandler
  {
    private static readonly int _disableStepClamberInteractContext;
    private const int STEP_RAYCAST_COMMAND_COUNT = 3;
    private const int STEP_TOP_RAYCAST_COMMAND_INDEX = 0;
    private const int STEP_FRONT_RAYCAST_COMMAND_INDEX = 1;
    private const int STEP_UNOBSTRUCTED_RAYCAST_COMMAND_INDEX = 2;
    [HideInInspector]
    public CollisionResult StepTopCollisionResult;
    public bool IsValidStepTop;
    public bool IsValidLadderTop;
    private CollisionResult _stepFrontCollisionResult;
    private CollisionResult _stepUnobstructedCollisionResult;
    private NativeArray<RaycastCommand> _stepRaycastCommands;
    private NativeArray<RaycastHit> _stepRaycastHits;
    private JobHandle _stepRaycastJobHandle;
    private InteractInstance _stepClamberInteractInstance;
    private InteractInstance _ladderTopClamberInteractInstance;
    private float _stepTopDotProductThreshold;
    private float _stepFrontDotProductThreshold;
    private float _ladderTopDotProductThreshold;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public StepDetectKerbalCharacterStateHandler(KerbalBehavior kerbalBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Deinitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void InitializeClamberInteractInstances(
      InteractPreset stepClamberInteractPreset,
      InteractPreset ladderTopClamberInteractPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Update(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool LateUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeStepRaycast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DeinitializeStepRaycast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeStepClamberInteractInstances(
      InteractBehavior interactBehavior,
      InteractPreset stepClamberInteractPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void InitializeLadderTopClamberInteractInstance(
      InteractBehavior interactBehavior,
      InteractPreset ladderTopClamberInteractPreset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessFetchRaycastHits() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScheduleRaycastBatch(
      ref RaycastCommand stepTopRaycastCommand,
      ref RaycastCommand stepFrontRaycastCommand,
      ref RaycastCommand stepUnobstructedRaycastCommand)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeValidStepTop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildStepTopRaycastCommands(
      out RaycastCommand stepTopRaycastCommand,
      out RaycastCommand stepFrontRaycastCommand,
      out RaycastCommand stepUnobstructedRaycastCommand)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScheduleStepClamberRaycast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessStepClamberRaycast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ComputeValidLadderTop() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void BuildLadderTopRaycastCommands(
      out RaycastCommand stepTopRaycastCommand,
      out RaycastCommand stepUnobstructedRaycastCommand)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ScheduleLadderTopClamberRaycast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ProcessLadderTopClamberRaycast() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsLadderTopClamberProcessing(KerbalBehavior kerbalBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static bool IsLadderTopClamberAllowed(KerbalBehavior kerbalBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static StepDetectKerbalCharacterStateHandler() => throw null;
  }
}
