// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.VesselSituations
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
