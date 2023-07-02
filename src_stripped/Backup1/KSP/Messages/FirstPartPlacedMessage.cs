// Decompiled with JetBrains decompiler
// Type: KSP.Messages.FirstPartPlacedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
