// Decompiled with JetBrains decompiler
// Type: OdeSolverStageComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Mathematics;

[BurstCompile]
public struct OdeSolverStageComponent
{
  public int StageID;
  public double StartUT;
  public double EndUT;
  public double InitialAssemblyMass;
  public double MassFlux;
  public double3 ExhaustVelocity;
  public double BurnTime;
  public double MaxPossibleBurnTime;
  public double DeltaV;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OdeSolverStageComponent(int stageId) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public OdeSolverStageComponent(
    int stageId,
    double startUt,
    double endUt,
    double3 exhaustVelocity,
    double initialAssemblyMass,
    double massFlux,
    double burnTime,
    double maxPossibleBurnTime)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void ResetExhaustVelocityDirection(ITransformFrame frame, Vector newDirection) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateAfterSoiCross(double utAtSoiCross) => throw null;
}
