// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ColonyEstablishedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Colony/ColonyEstablishedMessage", false, "Player has established a colony", "")]
  public class ColonyEstablishedMessage : ColonyMessageBase
  {
    public IGGuid vesselID;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ColonyEstablishedMessage() => throw null;
  }
}
