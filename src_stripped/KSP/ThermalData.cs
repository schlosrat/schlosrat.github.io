// Decompiled with JetBrains decompiler
// Type: KSP.ThermalData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
