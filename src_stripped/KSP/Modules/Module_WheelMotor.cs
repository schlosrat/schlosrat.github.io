// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_WheelMotor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_WheelMotor : Module_WheelSubmodule
  {
    [SerializeField]
    protected Data_WheelMotor dataWheelMotor;
    public double avgResRate;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMotorState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMotorStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMotorStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMotorStateInverted(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMotorTractionState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMotorTractionStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetMotorTractionStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnWheelSetup() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual float OnDriveUpdate(float motorInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMotorOrientationSign() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual bool GetMotorEnabled(
      bool baseMotorEnabled,
      ModuleProperty<string> stateString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetMaxSpeed() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnAutoTorqueChanged(bool value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_WheelMotor() => throw null;
  }
}
