// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.FlowRequestResolutionState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;

namespace KSP.Sim.ResourceSystem
{
  public struct FlowRequestResolutionState
  {
    public ResourceFlowRequestHandle RequestHandle;
    public double LastTickUniversalTime;
    public double LastTickDeltaTime;
    public bool WasLastTickDeliveryAccepted;
    public double LastTickDeliveryNormalized;
    public double LastAcceptedDeliveryUniversalTime;
    public double LastAcceptedDeliveryNormalized;
    public List<ResourceDefinitionID> ResourcesNotProcessed;
  }
}
