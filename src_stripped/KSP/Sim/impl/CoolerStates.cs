// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.CoolerStates
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.ComponentModel;

namespace KSP.Sim.impl
{
  public enum CoolerStates
  {
    [Description("PartModules/Cooler/States/Removing")] REMOVING,
    [Description("PartModules/Cooler/States/TooHot")] TOOHOT,
    [Description("PartModules/Cooler/States/NoSurfaceContact")] NOSRFCONTACT,
    [Description("PartModules/Cooler/States/NoFluidContact")] NOFLUIDCONTACT,
    [Description("PartModules/Cooler/States/NoResource")] OUTOFRESOURCE,
    [Description("PartModules/Cooler/States/PoweredOff")] OFF,
    [Description("PartModules/Cooler/States/Idle")] IDLE,
    [Description("PartModules/Cooler/States/OutOfAtm")] OUTOFATMOSPHERE,
    [Description("PartModules/Deployable/Retracted")] RETRACTED,
  }
}
