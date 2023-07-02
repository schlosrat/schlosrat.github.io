// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.DeltaVState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.DeltaV;
using System.Runtime.CompilerServices;

namespace KSP.Sim.State
{
  public struct DeltaVState
  {
    public bool SyncListInstances;
    public bool UseMultipleInfoLists;
    public float TotalDeltaVVac;
    public float TotalDeltaVASL;
    public float TotalDeltaVActual;
    public float TotalBurnTime;
    public VesselDeltaVComponent.Mode ActiveMode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DeltaVState FromSerialized(SerializedDeltaVState serializedDeltaVState) => throw null;
  }
}
