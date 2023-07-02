// Decompiled with JetBrains decompiler
// Type: OdeSolverStageComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
