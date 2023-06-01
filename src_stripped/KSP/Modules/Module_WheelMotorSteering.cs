// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_WheelMotorSteering
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_WheelMotorSteering : Module_WheelMotor
  {
    [SerializeField]
    protected Data_WheelMotorSteering dataWheelMotorSteering;
    private Vector3 _wFwd;
    private Vector3 _rCom;
    private Vector3 _wXcom;
    private Vector3 _steerAxisInput;
    private float _wDot;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override float OnDriveUpdate(float motorInput) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override bool GetMotorEnabled(
      bool baseMotorEnabled,
      ModuleProperty<string> stateString)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_WheelMotorSteering() => throw null;
  }
}
