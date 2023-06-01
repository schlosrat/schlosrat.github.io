// Decompiled with JetBrains decompiler
// Type: KSP.Messages.FirstPartPlacedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
