// Decompiled with JetBrains decompiler
// Type: KSP.ThermalData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
