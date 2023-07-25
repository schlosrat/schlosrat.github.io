// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.ModuleDeployableGear
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.impl
{
  [PartModule]
  public class ModuleDeployableGear : MonoBehaviour, IPartModule
  {
    private AnimatorToggle animatorToggle;
    private bool isGearActive;
    private bool lastGearState;

    public DataContext DataContext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VesselBehavior vessel
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public PartBehavior part
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public PartOwnerBehavior partOwner
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public ISimulationObjectView simulationObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool stagingEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool moduleIsEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ModuleAction executedAction
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public IDictionary<string, BaseAction> Actions
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IDictionary<string, BaseEvent> Events
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public IDictionary<string, BaseField> Fields
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ITransformModel transform
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetInfo() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsStageable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnActive() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnStart(PartModuleStartState state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ModuleDeployableGear() => throw null;
  }
}
