// Decompiled with JetBrains decompiler
// Type: KSP.Messages.FirstPartPlacedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/FirstPartPlacedMessage", false, "Player has placed the first part)", "")]
  public class FirstPartPlacedMessage : OABMessageBase
  {
    public AssemblyPartTypeFilter partType;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FirstPartPlacedMessage() => throw null;
  }
}
