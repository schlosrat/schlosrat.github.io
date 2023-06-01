// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedDeltaVState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.DeltaV;

namespace KSP.Sim
{
  public struct SerializedDeltaVState
  {
    public bool SyncListInstances;
    public bool UseMultipleInfoLists;
    public float TotalDeltaVVac;
    public float TotalDeltaVASL;
    public float TotalDeltaVActual;
    public float TotalBurnTime;
    public VesselDeltaVComponent.Mode ActiveMode;
  }
}
