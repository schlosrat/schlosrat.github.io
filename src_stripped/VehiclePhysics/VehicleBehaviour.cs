// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VehicleBehaviour
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public abstract class VehicleBehaviour : MonoBehaviour
  {
    private bool m_emitTelemetry;

    public VehicleBase vehicle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] protected set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDisableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateAfterFixedUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual int GetUpdateOrder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UpdateVehicleSuspension() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual bool EmitTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void RegisterTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void UnregisterTelemetry() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnEnableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnDisableComponent() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnReposition() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnEnterPause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnLeavePause() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugLogWarning(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DebugLogError(string message) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual VehicleBase GetVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public (bool changed, bool emit) GetTelemetryState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected VehicleBehaviour() => throw null;
  }
}
