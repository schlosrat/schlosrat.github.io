// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_ResourceIntake
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace KSP.Modules
{
  public class Module_ResourceIntake : PartBehaviourModule
  {
    [FormerlySerializedAs("data")]
    [SerializeField]
    protected Data_ResourceIntake dataResourceIntake;
    protected Transform intakeTransform;
    protected double densityRecip;
    protected AttachNodeData attachNode;
    protected bool checkNode;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void InitProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnIntakeToggle(bool bValue) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableIntake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableIntake() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleIntake(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_ResourceIntake() => throw null;
  }
}
