﻿// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.VesselSituations
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
