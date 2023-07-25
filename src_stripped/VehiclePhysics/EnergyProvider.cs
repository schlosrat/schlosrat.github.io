// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.EnergyProvider
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VehiclePhysics
{
  public class EnergyProvider
  {
    public float maxEnergy;
    public float antiStallRamp;
    private Engine m_engine;
    private float m_energyLimit;
    private float m_demandedEnergy;
    private float m_deliveredEnergy;
    private float m_engineEnergy;
    private float m_engineRpm;
    private float m_frictionTorque;
    private List<EnergyProvider.OutputSlot> m_outputs;

    public float sensorTorque
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorRpm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorEnergyLimit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorEngineEnergy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorDemandedEnergy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float sensorDeliveredEnergy
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public EnergyProvider(Engine engine) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DoUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RegisterOutput(int priority, EnergyProvider.Output output) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveOutput(EnergyProvider.Output output) => throw null;

    public class Output
    {
      public float demanded;
      public float maximum;
      public float delivered;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Output() => throw null;
    }

    private class OutputSlot
    {
      public int priority;
      public EnergyProvider.Output output;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public OutputSlot() => throw null;
    }
  }
}
