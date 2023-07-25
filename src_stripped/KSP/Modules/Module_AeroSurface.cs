// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_AeroSurface
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_AeroSurface : Module_ControlSurface, IPartBrakes
  {
    [SerializeField]
    protected Data_AeroSurface _dataAeroSurface;
    protected Data_ControlSurface _dataControlSurface;

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
    private void SetBrakeStateOn() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBrakeStateOff() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void SetBrakeState(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void CtrlSurfaceUpdate(Vector3 vel, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void CtrlSurfaceEditorUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_AeroSurface() => throw null;
  }
}
