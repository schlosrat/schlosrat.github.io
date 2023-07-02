// Decompiled with JetBrains decompiler
// Type: KSP.OAB.ObjectAssemblyBuilderResourceCosting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.ResourceSystem;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.OAB
{
  public class ObjectAssemblyBuilderResourceCosting
  {
    private Dictionary<ResourceDefinitionID, double> _totalCosts;
    private ObjectAssemblyBuilder _builder;
    private ObjectAssemblyBuilderEvents _builderEvents;
    private ResourceDefinitionDatabase _resourceDatabase;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ObjectAssemblyBuilderResourceCosting(ObjectAssemblyBuilder builder) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Initialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IReadOnlyDictionary<ResourceDefinitionID, double> GetTotalCosts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NeedsUpdate(OABActionType type) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NeedsUpdate(object _) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateCosts() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static float GetResourceCostModifier(IObjectAssemblyPart part) => throw null;
  }
}
