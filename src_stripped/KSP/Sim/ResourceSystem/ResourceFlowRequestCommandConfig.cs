// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ResourceSystem.ResourceFlowRequestCommandConfig
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
