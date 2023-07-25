// Decompiled with JetBrains decompiler
// Type: KSP.IOrbitControllableInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Controllability;
using KSP.Sim.State;

namespace KSP
{
  public interface IOrbitControllableInput : 
    IOrbitControlInput,
    IFlightControlInput,
    IControlInput,
    IVehicleControlsReader,
    IFlightControlReader,
    IOrbitControlReader
  {
    void AtomicSet(
      float? mainThrottle,
      float? roll,
      float? yaw,
      float? pitch,
      float? rollTrim,
      float? yawTrim,
      float? pitchTrim,
      float? wheelSteer,
      float? wheelSteerTrim,
      float? wheelThrottle,
      float? wheelThrottleTrim,
      float? X,
      float? Y,
      float? Z,
      bool? killRot,
      bool? gearUp,
      bool? gearDown,
      bool? headlight);

    void AtomicSet(FlightCtrlStateIncremental state);
  }
}
