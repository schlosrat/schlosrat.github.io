// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ColonyComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Converters;
using KSP.Sim.Definitions;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class ColonyComponent : ObjectComponent
  {
    private IUniverseModel universeModel;

    [TypeConverterIgnore]
    public override Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public override Type ViewObjectComponentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public double Radius
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public OrbiterComponent Orbiter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public IOrbit Orbit
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public SimulationObjectModel TargetObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyComponent(AssemblyDefinition colonyDefinition, UniverseModel universeModel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void SetDefinition(object definitionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override object SetState(object state, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;
  }
}
