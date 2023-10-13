// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.VPVehicleToolkit
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VehiclePhysics
{
  public class VPVehicleToolkit : VehicleBehaviour
  {
    [FormerlySerializedAs("startEngineOnEnable")]
    [Tooltip("Start the engine when the vehicle is enabled")]
    [Header("On Vehicle Startup")]
    public bool startEngine;
    [FormerlySerializedAs("pressBrake")]
    [Tooltip("Press brakes. Note that if the vehicle has other input components, they will override brakes inmediately afterwards.")]
    public bool pressBrakes;
    [Space(5f)]
    [Tooltip("Specify the default gear mode (P, R, N, D) in Automatic tranmsissions.")]
    [FormerlySerializedAs("setAutomaticMode")]
    public bool setAutomaticGear;
    [FormerlySerializedAs("defaultAutomaticMode")]
    [Tooltip("Default gear mode (P, R, N, D) in Automatic tranmsissions. Applied when Set Automatic Gear is enabled.")]
    public VPVehicleToolkit.AutomaticGear automaticGearMode;
    private bool m_engineStarting;

    public float speed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float speedInKph
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float speedInMph
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float engineRpm
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float engineLoad
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int engagedGear
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public VPVehicleToolkit.AutomaticGear automaticMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool isEngineStarting
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool isEngineStarted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public bool hasEngineStalled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float longitudinalG
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float lateralG
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float verticalG
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float pitch
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float roll
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float yaw
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float pitchVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float rollVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public float yawVelocity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [ContextMenu("Start Engine")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StartEngine() => throw null;

    [ContextMenu("Stop Engine")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void StopEngine() => throw null;

    [ContextMenu("Toggle Engine On/Off")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleStartStopEngine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSteering(float steering) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetThrottle(float throttle) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBrake(float brake) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetHandbrake(float handbrake) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetClutch(float clutch) => throw null;

    public float throttlePedal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float brakePedal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public float clutchPedal
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [ContextMenu("Set Automatic Mode M")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAutomaticModeM() => throw null;

    [ContextMenu("Set Automatic Mode P")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAutomaticModeP() => throw null;

    [ContextMenu("Set Automatic Mode R")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAutomaticModeR() => throw null;

    [ContextMenu("Set Automatic Mode N")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAutomaticModeN() => throw null;

    [ContextMenu("Set Automatic Mode D")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetAutomaticModeD() => throw null;

    [ContextMenu("Toggle Automatic Mode P")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ToggleAutomaticModeP() => throw null;

    [ContextMenu("Set Next Automatic Mode")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNextAutomaticMode() => throw null;

    [ContextMenu("Set Previous Automatic Mode")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetPreviousAutomaticMode() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetGear(int gear) => throw null;

    [ContextMenu("Shift Gear Up")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShiftGearUp() => throw null;

    [ContextMenu("Shift Gear Down")]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ShiftGearDown() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnEnableVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void UpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void FixedUpdateVehicle() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetUpdateOrder() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void StartEngineProcedure() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VPVehicleToolkit() => throw null;

    public enum AutomaticGear
    {
      M,
      P,
      R,
      N,
      D,
      L,
    }
  }
}
