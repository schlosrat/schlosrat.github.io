// Decompiled with JetBrains decompiler
// Type: KSP.Sim.DeltaV.DeltaVCalc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.DeltaV
{
  public class DeltaVCalc
  {
    public double DvInVac;
    public double DvAtASL;
    public double DvActual;
    public double BurnTime;
    public List<DeltaVEngineInfo> ActiveEngines;
    public double IspVAC;
    public double IspASL;
    public double IspActual;
    public float TWRVac;
    public float TWRASL;
    public float TWRActual;
    public float FuelFlowActual;
    public float FuelFlowASL;
    public float FuelFlowVac;
    public float FuelMassBurntASL;
    public float FuelMassBurntVac;
    public float FuelMassBurntActual;
    public double StartMass;
    public double EndMass;
    public double ThrustVac;
    public double ThrustASL;
    public double ThrustActual;
    public Vector3 VectoredDirectionThrustVac;
    public Vector3 VectoredDirectionThrustASL;
    public Vector3 VectoredDirectionThrustActual;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeltaVCalc() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeltaVCalc(List<DeltaVEngineInfo> activeEngines) => throw null;
  }
}
