// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_ActiveRadiator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [Serializable]
  public class Data_ActiveRadiator : ModuleData
  {
    [Tooltip("This is the axis direction we should use to calculate the area of the radiator for procedural radiators.\nWill not be used if the radiator is NOT procedural.")]
    [KSPDefinition]
    public Data_LiftingSurface.TransformDir RadiatorDirection;
    [KSPDefinition]
    [Tooltip("This is the amount of flux removed from the radiator calculated from the area of the radiator for procedural radiators.\nWill not be used if the radiator is NOT procedural.\nThis will be used to calculate the fluxRemoved value.")]
    public float ProceduralRadiatorFluxPerAreaUnit;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_ActiveRadiator() => throw null;
  }
}
