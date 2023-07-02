// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.FlowRequestResolutionState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
