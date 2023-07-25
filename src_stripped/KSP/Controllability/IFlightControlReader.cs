// Decompiled with JetBrains decompiler
// Type: KSP.Controllability.IFlightControlReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Controllability
{
  public interface IFlightControlReader
  {
    float mainThrottle { get; }

    float roll { get; }

    float yaw { get; }

    float pitch { get; }

    float rollTrim { get; }

    float yawTrim { get; }

    float pitchTrim { get; }

    bool killRot { get; }

    bool gearUp { get; }

    bool gearDown { get; }
  }
}
