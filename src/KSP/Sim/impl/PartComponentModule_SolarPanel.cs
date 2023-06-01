// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_SolarPanel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_SolarPanel : PartComponentModule_Deployable
  {
    private bool _requestActive;
    protected Data_SolarPanel dataSolarPanel;
    protected Data_Deployable dataDeployable;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private double CalculateVesselSolarLOS() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool CalculateOcclusionPerStar(CelestialBodyComponent sunBody, out string blocker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_SolarPanel() => throw null;
  }
}
