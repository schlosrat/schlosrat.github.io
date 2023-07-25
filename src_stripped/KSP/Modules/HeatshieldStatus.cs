// Decompiled with JetBrains decompiler
// Type: KSP.Modules.HeatshieldStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.ComponentModel;

namespace KSP.Modules
{
  public enum HeatshieldStatus : byte
  {
    [Description("PartModules/HeatShield/Nominal")] NOMINAL,
    [Description("PartModules/HeatShield/Ablating")] ABLATING,
    [Description("PartModules/HeatShield/NoResource")] NORESOURCE,
  }
}
