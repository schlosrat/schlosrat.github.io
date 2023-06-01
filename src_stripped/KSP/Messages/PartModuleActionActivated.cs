// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PartModuleActionActivated
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Parts/PartModules/ActionExecuted", true, "Player has triggered a part action", "")]
  public class PartModuleActionActivated : PartModuleMessageBase
  {
    public PartComponent partComponent;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartModuleActionActivated() => throw null;
  }
}
