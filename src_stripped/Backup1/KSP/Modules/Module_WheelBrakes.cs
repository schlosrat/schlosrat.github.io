// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_WheelBrakes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_WheelBrakes : Module_WheelSubmodule, IPartBrakes
  {
    [SerializeField]
    protected Data_WheelBrakes dataWheelBrakes;
    [Header("Runtime Variables Below here - Do not change")]
    public Module_StatusLight StatusLight;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool isBraking
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnWheelSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBrakeStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBrakeStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBrakeState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnSubsystemsModified(WheelSubsystems s) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_WheelBrakes() => throw null;
  }
}
