// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PartModuleStartState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
