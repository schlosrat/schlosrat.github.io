// Decompiled with JetBrains decompiler
// Type: KSP.Messages.SubassemblyLoadedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/SubassemblyLoadedMessage", true, "Player has loaded a subassembly", "Currently both this and VesselLoadedMessages are fired from the same code path")]
  public class SubassemblyLoadedMessage : OABMessageBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SubassemblyLoadedMessage() => throw null;
  }
}
