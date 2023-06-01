// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.CommandControlState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
