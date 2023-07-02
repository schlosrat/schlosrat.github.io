// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Gearset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class Gearset : Block
  {
    public int gearInput;
    public Gearset.Settings settings;
    private Block.Connection m_input;
    private Block.Connection m_output;
    private float m_ratio;
    private float m_invRatio;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool CheckConnections() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void PreStep() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ComputeStateUpstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void EvaluateTorqueDownstream() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Gearset() => throw null;

    public class Settings
    {
      public float[] ratios;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Settings() => throw null;
    }
  }
}
