// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.SynchronousDrive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class SynchronousDrive : Block
  {
    public float targetRpm;
    public float maxTorque;
    public float damping;
    private Block.Connection m_output;

    public float angularVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float torque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CheckConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SynchronousDrive() => throw null;
  }
}
