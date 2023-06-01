// Decompiled with JetBrains decompiler
// Type: KSP.IFlightControllableInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Controllability;

namespace KSP
{
  public interface IFlightControllableInput : 
    IFlightControlInput,
    IControlInput,
    IVehicleControlsReader,
    IFlightControlReader
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
      bool? killRot,
      bool? gearUp,
      bool? gearDown,
      bool? headlight);
  }
}
