// Decompiled with JetBrains decompiler
// Type: KSP.Modules.ResourceConversionState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
