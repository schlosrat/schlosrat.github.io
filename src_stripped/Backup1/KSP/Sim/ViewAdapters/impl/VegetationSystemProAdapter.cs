// Decompiled with JetBrains decompiler
// Type: KSP.Sim.ViewAdapters.impl.VegetationSystemProAdapter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using KSP.Game;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.ViewAdapters.impl
{
  public class VegetationSystemProAdapter : 
    KerbalMonoBehaviour,
    IViewToUnityAdapter<VegetationSystemPro>,
    IViewToUnityAdapter
  {
    public IUniverseView Universe
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public ViewObjectComponent OwnerBehavior
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    private IUniverseObserver Observer
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private SimulationObjectView OwnerObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VegetationSystemPro Target
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
    }

    public object TargetObject
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(
      GameObject targetRoot,
      IUniverseView universe,
      ViewObjectComponent ownerBehavior)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(IUniverseView universe, ViewObjectComponent ownerBehavior) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VegetationSystemProAdapter() => throw null;
  }
}
