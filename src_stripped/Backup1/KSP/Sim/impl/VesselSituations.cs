// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.VesselSituations
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.Sim.impl
{
  public enum VesselSituations : byte
  {
    PreLaunch = 0,
    Landed = 1,
    Splashed = 2,
    Flying = 3,
    SubOrbital = 4,
    Orbiting = 5,
    Escaping = 6,
    Unknown = 255, // 0xFF
  }
}
