// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Definitions.VesselControlState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.ComponentModel;

namespace KSP.Sim.Definitions
{
  public enum VesselControlState : byte
  {
    [Description("PartModules/Command/VesselControlState/NoControl")] NoControl,
    [Description("PartModules/Command/VesselControlState/NoCommNet")] NoCommNet,
    [Description("PartModules/Command/VesselControlState/FullControlHibernation")] FullControlHibernation,
    [Description("PartModules/Command/VesselControlState/FullControl")] FullControl,
  }
}
