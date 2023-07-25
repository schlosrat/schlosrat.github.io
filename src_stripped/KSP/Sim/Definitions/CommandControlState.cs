// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.CommandControlState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.ComponentModel;

namespace KSP.Sim.Definitions
{
  public enum CommandControlState : byte
  {
    None = 0,
    [Description("PartModules/Command/ControlStatus/Disabled")] Disabled = 1,
    [Description("PartModules/Command/ControlStatus/NotEnoughCrew")] NotEnoughCrew = 2,
    [Description("PartModules/Command/ControlStatus/NotEnoughResources")] NotEnoughResources = 3,
    [Description("PartModules/Command/ControlStatus/NoCommnetConnection")] NoCommNetConnection = 4,
    [Description("PartModules/Command/ControlStatus/Hibernating")] Hibernating = 5,
    [Description("PartModules/Command/ControlStatus/FullyFunctional")] FullyFunctional = 15, // 0x0F
  }
}
