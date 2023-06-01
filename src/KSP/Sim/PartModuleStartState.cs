// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PartModuleStartState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.Sim
{
  [Flags]
  public enum PartModuleStartState
  {
    None = 0,
    Editor = 1,
    PreLaunch = 2,
    Landed = 4,
    Docked = 8,
    Flying = 16, // 0x00000010
    Splashed = 32, // 0x00000020
    SubOrbital = 64, // 0x00000040
    Orbital = 128, // 0x00000080
  }
}
