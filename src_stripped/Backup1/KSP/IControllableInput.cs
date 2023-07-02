// Decompiled with JetBrains decompiler
// Type: KSP.IControllableInput
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Controllability;

namespace KSP
{
  public interface IControllableInput : IControlInput, IVehicleControlsReader
  {
    void AtomicSet(
      float? wheelSteer,
      float? wheelSteerTrim,
      float? wheelThrottle,
      float? wheelThrottleTrim,
      bool? headlight);
  }
}
