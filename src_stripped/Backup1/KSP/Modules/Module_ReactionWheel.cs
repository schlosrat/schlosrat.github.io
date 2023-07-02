// Decompiled with JetBrains decompiler
// Type: KSP.Modules.Module_ReactionWheel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Modules
{
  [DisallowMultipleComponent]
  public class Module_ReactionWheel : PartBehaviourModule, ITorqueProvider
  {
    [SerializeField]
    protected Data_ReactionWheel dataReactionWheel;
    private Module_ReactionWheel.ReactionWheelTorque _torque;
    private Vector3 _inputVector;
    private float _inputSum;
    private Vector3 _cmdInput;
    private Vector3 _inputVectorTmp;

    public override System.Type PartComponentModuleType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void AddDataModules() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnInitialize() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnShutdown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleFixedUpdate(float fixedDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void OnModuleOABFixedUpdate(float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ActiveUpdate(Data_ReactionWheel.ActuatorModes mode, float deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string GetModuleDisplayName() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void EnableTorque() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void DisableTorque() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ToggleTorque(bool newState) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetPotentialTorque(out Vector3 pos, out Vector3 neg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Module_ReactionWheel() => throw null;

    public class ReactionWheelTorque : ITorque
    {
      public ForceType TorqueMode
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      public Vector3d RelativeTorque
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ReactionWheelTorque() => throw null;
    }
  }
}
