// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceDefinition
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.Sim.ResourceSystem
{
  [Serializable]
  public struct ResourceDefinition
  {
    public string name;
    public string displayNameKey;
    public string abbreviationKey;
    public bool isTweakable;
    public bool isVisible;
    public double massPerUnit;
    public double volumePerUnit;
    public double specificHeatCapacityPerUnit;
    public ResourceFlowMode flowMode;
    public ResourceTransferMode transferMode;
    public double costPerUnit;
    public bool ignoreForIsp;
    public bool NonStageable;
    public string resourceIconAssetAddress;
    public string vfxFuelType;
  }
}
