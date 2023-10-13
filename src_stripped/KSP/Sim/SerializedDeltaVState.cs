// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedDeltaVState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

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
