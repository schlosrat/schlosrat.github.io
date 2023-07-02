// Decompiled with JetBrains decompiler
// Type: KSP.Modules.FairingDeployType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
