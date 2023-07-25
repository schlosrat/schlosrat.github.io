// Decompiled with JetBrains decompiler
// Type: KSP.Sim.State.ResourceConsumerComponentRateState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using UnityEngine.Serialization;

namespace KSP.Sim.State
{
  [Serializable]
  public struct ResourceConsumerComponentRateState
  {
    public string name;
    public double universalTime;
    [FormerlySerializedAs("rate")]
    public double rateInUnitsPerSecond;
    public double deltaRate;
  }
}
