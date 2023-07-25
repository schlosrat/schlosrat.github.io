// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Data_CargoBay
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
  public sealed class Data_CargoBay : ModuleData
  {
    [KSPDefinition]
    public string BayContainerName;
    [KSPDefinition]
    public bool useBayContainer;
    [KSPDefinition]
    public float lookUpRadius;
    [KSPDefinition]
    public Vector3 lookUpCenter;
    [KSPDefinition]
    public float ClosedPosition;
    [KSPDefinition]
    public string nodeOuterForeID;
    [KSPDefinition]
    public string nodeOuterAftID;
    [KSPDefinition]
    public string nodeInnerForeID;
    [KSPDefinition]
    public string nodeInnerAftID;
    [HideInInspector]
    public bool IsSealed;

    public override System.Type ModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Data_CargoBay() => throw null;
  }
}
