// Decompiled with JetBrains decompiler
// Type: KSP.Messages.LaunchSequenceCompleteMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Flight/LaunchSequenceCompleteMessage", true, "Launch sequence complete", "")]
  public class LaunchSequenceCompleteMessage : FlightMessageBase
  {
    public OABProvider.LaunchLocation locationCompleted;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchSequenceCompleteMessage() => throw null;
  }
}
