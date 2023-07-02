// Decompiled with JetBrains decompiler
// Type: KSP.Modules.ResourceConversionState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.ComponentModel;

namespace KSP.Modules
{
  [Serializable]
  public enum ResourceConversionState : byte
  {
    None,
    [Description("PartModules/ResourceConverter/Operational")] Operational,
    [Description("PartModules/ResourceConverter/OperationalLow")] OperationalLow,
    [Description("PartModules/ResourceConverter/Inactive")] Inactive,
    [Description("PartModules/ResourceConverter/NoPower")] NoPower,
    [Description("PartModules/ResourceConverter/InsufficientResource")] InsufficientResource,
    [Description("PartModules/ResourceConverter/InsufficientContainment")] InsufficientContainment,
    [Description("PartModules/Generator/Overheat")] Overheated,
  }
}
