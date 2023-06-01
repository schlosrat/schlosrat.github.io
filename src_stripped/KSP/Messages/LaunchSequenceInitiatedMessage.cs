// Decompiled with JetBrains decompiler
// Type: KSP.Messages.LaunchSequenceInitiatedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/LaunchSequenceInitiatedMessage", true, "Launch sequence initiated", "")]
  public class LaunchSequenceInitiatedMessage : FlightMessageBase
  {
    public OABProvider.LaunchLocation locationInitiated;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchSequenceInitiatedMessage() => throw null;
  }
}
