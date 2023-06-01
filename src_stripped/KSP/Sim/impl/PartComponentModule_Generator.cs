// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.PartComponentModule_Generator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using KSP.Modules;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public class PartComponentModule_Generator : PartComponentModule
  {
    protected Data_ModuleGenerator dataGenerator;
    private bool _engineFound;
    private PartComponentModule_Engine _engineModule;
    private double _decayMultiplier;

    public override Type PartBehaviourModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private GameInstance _game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnStart(double universalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnUpdate(double universalTime, double deltaUniversalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void ResourceGenerationUpdate(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartComponentModule_Generator() => throw null;
  }
}
