// Decompiled with JetBrains decompiler
// Type: KSP.ThermalData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Mathematics;

namespace KSP
{
  public struct ThermalData
  {
    public FixedBytes16 Guid;
    public double BodyAtmosphereFlux;
    public double BodyLocalFlux;
    public double BodySurfaceFlux;
    public double EnvironmentFlux;
    public double SolarFlux;
    public double RemovedFlux;
    public double4 ReentryFlux;
    public double ExhaustFlux;
    public double OtherFlux;
    public double CoolingDemand;
    public double WeightedCoolingDemand;
    public double ExposedAreaProportion;
    public double CoolingEnergyToApply;
    public double ThermalMass;
    public double Temperature;
    public double MaxTemp;
    public bool CallResetAllowed;
    public bool DestroyPart;
    public double WettedArea;
    private bool _resetAllowedThisFrame;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetAllowed() => throw null;
  }
}
