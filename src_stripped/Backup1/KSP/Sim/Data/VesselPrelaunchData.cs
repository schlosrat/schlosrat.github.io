// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Data.VesselPrelaunchData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Modules;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Data
{
  public class VesselPrelaunchData
  {
    public BoundingSphere VesselBoundingSphere;
    public int FirstStageWithAnEngine;
    public List<VesselPrelaunchData.EngineStageData> EngineStageDataList;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselPrelaunchData() => throw null;

    public class EngineStageData
    {
      public int Count;
      public List<EngineType> FuelTypes;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public EngineStageData(int c, List<EngineType> ft) => throw null;
    }
  }
}
