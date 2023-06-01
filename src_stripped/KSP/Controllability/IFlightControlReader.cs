// Decompiled with JetBrains decompiler
// Type: KSP.Controllability.IFlightControlReader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
