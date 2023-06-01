// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CommandStatusChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/Parts/CommandStatusChanged", true, "The command status has changed", "")]
  public class CommandStatusChangedMessage : PartModuleMessageBase
  {
    public CommandControlState NewState;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CommandStatusChangedMessage() => throw null;
  }
}
