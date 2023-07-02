// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_Generator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using KSP.Sim.Definitions;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_Generator : PartBehaviourModule
  {
    [SerializeField]
    [FormerlySerializedAs("DataGenerator")]
    protected Data_ModuleGenerator dataGenerator;
    public Module_Engine EngineModule;
    private IEngineStatus _engineStatus;
    private List<Material> _emissiveMaterials;
    private bool _emissiveListPopulated;
    private float emissiveIntensity;
    private KSPPartAudioManager _kspPartAudioManager;
    private const string TIME_FORMAT = "{0}Y {1}D {2:00}:{3:00}:{4:00}";

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetPAMVisibility() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetLifetimeDisplay() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string GetLifetimeDisplayTotal() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string FormatLifeTimeString(double seconds) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnVesselLaunched(MessageCenterMessage message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetStatus() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetEngineReference(Module_Engine engine) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void ThermalUpdate(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGeneratorState(bool state) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGeneratorOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetGeneratorOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_Generator() => throw null;
  }
}
