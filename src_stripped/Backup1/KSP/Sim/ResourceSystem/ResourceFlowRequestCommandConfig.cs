// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceFlowRequestCommandConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.ResourceSystem
{
  public class ResourceFlowRequestCommandConfig
  {
    public ResourceDefinitionID FlowResource;
    public double FlowUnits;
    public double TargetUnits;
    public FlowDirection FlowDirection;
    public ResourceFlowMode FlowModeOverride;
    public double FlowPriorityOffset;
    public ResourceRecipeIngredientDefinitionOverride[] IngredientOverrides;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ResourceFlowRequestCommandConfig() => throw null;
  }
}
