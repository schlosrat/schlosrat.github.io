// Decompiled with JetBrains decompiler
// Type: KSP.Modules.GeneratorStatus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.ComponentModel;

namespace KSP.Modules
{
  [Serializable]
  public enum GeneratorStatus : byte
  {
    [Description("PartModules/Generator/Nominal")] NOMINAL,
    [Description("PartModules/Generator/Off")] OFF,
    [Description("PartModules/Generator/Overheat")] OVERHEATED,
  }
}
