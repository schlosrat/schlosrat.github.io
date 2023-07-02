// Decompiled with JetBrains decompiler
// Type: KSP.Sim.PartModuleStartState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
