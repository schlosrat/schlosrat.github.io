// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ObjectComponent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Sim.Converters;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public abstract class ObjectComponent : IGuidIdentity
  {
    protected bool _isEnabled;
    private bool _assertForTheWin;
    protected object initialDefinitionData;

    [TypeConverterIgnore]
    public GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public abstract Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public abstract Type DefinitionType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public abstract Type StateType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public SimulationObjectModel SimulationObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    [TypeConverterIgnore]
    public ITransformModel transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public bool IsDestroyed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public bool IsDestroyedOrBeingDestroyed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public virtual bool IsValidInSim
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public bool IsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [TypeConverterIgnore]
    public IGGuid GlobalId
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public string Guid
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public string DisplayName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool Is(IGuidIdentity other) => throw null;

    [TypeConverterIgnore]
    public virtual Type ViewObjectComponentType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnAdded(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnRemoved(SimulationObjectModel simulationObject, double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnFixedUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnLateUpdate(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract object GetDefinition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void SetDefinition(object definitionData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract object GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract bool ValidateState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public abstract object SetState(object stateData, ISimulationModelMap simulationModelMap) => throw null;

    [TypeConverterIgnore]
    public bool IsLocallyAuthorized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [TypeConverterIgnore]
    public bool IsLocallyOwned
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected ObjectComponent() => throw null;
  }
}
