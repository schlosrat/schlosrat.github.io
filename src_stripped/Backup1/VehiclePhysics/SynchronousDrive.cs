// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.SynchronousDrive
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
