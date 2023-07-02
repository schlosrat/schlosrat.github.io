// Decompiled with JetBrains decompiler
// Type: KSP.IOrbitControllableInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
