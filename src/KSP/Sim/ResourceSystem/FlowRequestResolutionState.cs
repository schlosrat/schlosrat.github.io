// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.FlowRequestResolutionState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
