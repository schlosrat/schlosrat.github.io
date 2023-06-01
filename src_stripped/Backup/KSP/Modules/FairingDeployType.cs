// Decompiled with JetBrains decompiler
// Type: KSP.Modules.FairingDeployType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.ComponentModel;

namespace KSP.Modules
{
  public enum FairingDeployType : byte
  {
    [Description("PartModules/Fairings/DeployTypes/None")] None,
    [Description("PartModules/Fairings/DeployTypes/Shroud")] Shroud,
    [Description("PartModules/Fairings/DeployTypes/Clamshellx2")] Clamshellx2,
    [Description("PartModules/Fairings/DeployTypes/Clamshellx3")] Clamshellx3,
    [Description("PartModules/Fairings/DeployTypes/Clamshellx4")] Clamshellx4,
  }
}
