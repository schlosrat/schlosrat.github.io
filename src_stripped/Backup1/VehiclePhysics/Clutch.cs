// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Clutch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class Clutch : Block
  {
    public float lockRatio;
    public float inertiaRatio;
    private float L;
    private float I;
    private float T;
    private Block.Connection m_input;
    private Block.Connection m_output;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CheckConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetState(ref Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetSubstepState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ComputeStateUpstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void GetSubstepDerivative(ref Block.Derivative D) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetState(Block.State S) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Clutch() => throw null;
  }
}
