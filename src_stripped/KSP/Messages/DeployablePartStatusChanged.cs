// Decompiled with JetBrains decompiler
// Type: KSP.Messages.DeployablePartStatusChanged
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Parts/PartModules/DeployableChanged", true, "Deployable part status changed", "")]
  public class DeployablePartStatusChanged : PartModuleMessageBase
  {
    public PartComponent partComponent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DeployablePartStatusChanged() => throw null;
  }
}
