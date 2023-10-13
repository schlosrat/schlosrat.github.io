// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PartResourceData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;

namespace KSP.Sim
{
  [Serializable]
  public struct PartResourceData
  {
    public double amount;
    public double maxAmount;
    public bool flowState;
    public PartResource.FlowMode flowMode;
    public ResourceType type;
  }
}
