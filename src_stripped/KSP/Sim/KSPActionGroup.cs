// Decompiled with JetBrains decompiler
// Type: KSP.Sim.KSPActionGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.ComponentModel;

namespace KSP.Sim
{
  [Flags]
  public enum KSPActionGroup : uint
  {
    [Description("ActionGroups/GroupNames/None")] None = 0,
    [Description("ActionGroups/GroupNames/Stage")] Stage = 1,
    [Description("ActionGroups/GroupNames/Gear")] Gear = 2,
    [Description("ActionGroups/GroupNames/Lights")] Lights = 4,
    [Description("ActionGroups/GroupNames/RCS")] RCS = 8,
    [Description("ActionGroups/GroupNames/SAS")] SAS = 16, // 0x00000010
    [Description("ActionGroups/GroupNames/Brakes")] Brakes = 32, // 0x00000020
    [Description("ActionGroups/GroupNames/Abort")] Abort = 64, // 0x00000040
    [Description("ActionGroups/GroupNames/SolarPanels")] SolarPanels = 128, // 0x00000080
    [Description("ActionGroups/GroupNames/RadiatorPanels")] RadiatorPanels = 256, // 0x00000100
    [Description("ActionGroups/GroupNames/Custom01")] Custom01 = 65536, // 0x00010000
    [Description("ActionGroups/GroupNames/Custom02")] Custom02 = 131072, // 0x00020000
    [Description("ActionGroups/GroupNames/Custom03")] Custom03 = 262144, // 0x00040000
    [Description("ActionGroups/GroupNames/Custom04")] Custom04 = 524288, // 0x00080000
    [Description("ActionGroups/GroupNames/Custom05")] Custom05 = 1048576, // 0x00100000
    [Description("ActionGroups/GroupNames/Custom06")] Custom06 = 2097152, // 0x00200000
    [Description("ActionGroups/GroupNames/Custom07")] Custom07 = 4194304, // 0x00400000
    [Description("ActionGroups/GroupNames/Custom08")] Custom08 = 8388608, // 0x00800000
    [Description("ActionGroups/GroupNames/Custom09")] Custom09 = 16777216, // 0x01000000
    [Description("ActionGroups/GroupNames/Custom10")] Custom10 = 33554432, // 0x02000000
  }
}
