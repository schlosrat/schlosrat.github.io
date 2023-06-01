// Decompiled with JetBrains decompiler
// Type: KSP.ThermalData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP
{
  public struct ThermalData
  {
    public double BodyAtmosphereFlux;
    public double BodyLocalFlux;
    public double BodySurfaceFlux;
    public double EnvironmentFlux;
    public double SolarFlux;
    public double RemovedFlux;
    public Vector3d ReentryFlux;
    public double ExhaustFlux;
    public double OtherFlux;
    public string InfluencingEngineID;
    public double CoolingDemand;
    public double WeightedCoolingDemand;
    public double ShockAreaMultiplier;
    private bool _resetAllowedThisFrame;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllowed() => throw null;
  }
}
