// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.DeltaVEngineInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Modules;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.DeltaV
{
  [Serializable]
  public class DeltaVEngineInfo
  {
    public VesselDeltaVComponent VesselDeltaVComponent;
    private DeltaVPartInfo _partInfo;
    public IDeltaVPart Part;
    public Data_Engine Engine;
    public DeltaVPropellantInfo PropellantInfo;
    public double IspVac;
    public double IspASL;
    public double IspActual;
    public Vector3 ThrustVectorVac;
    public Vector3 ThrustVectorASL;
    public Vector3 ThrustVectorActual;
    public float ThrustVac;
    public float ThrustASL;
    public float ThrustActual;
    public int StartBurnStage;
    public bool RequiresAir;
    public bool ThrottleIsLimited;
    public float FuelFlowActual;
    public float FuelFlowASL;
    public float FuelFlowVac;
    public double MinBurnTime;
    public static IComparer<DeltaVEngineInfo> BurnTimeSorting;

    public DeltaVPartInfo PartInfo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetSituationISP(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetSituationThrust(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 GetSituationThrustVector(DeltaVSituationOptions situation) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeltaVEngineInfo(
      VesselDeltaVComponent inVesselDeltaV,
      Data_Engine inEngine,
      IDeltaVPart part)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void Reset(int stage, int partCount) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal void CalcThrustActual(bool engineIngitedCheck = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateISP(bool engineIngitedCheck = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetISPVac() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetISPASL() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetISPActual() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateThrustVector(bool engineIngitedCheck = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ThrottleLimited() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static DeltaVEngineInfo() => throw null;
  }
}
