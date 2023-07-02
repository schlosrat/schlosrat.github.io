// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PauseStateChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/State/PauseStateChangedMessage", true, "Player has changed the state of Pause to paused or unpaused", "")]
  public class PauseStateChangedMessage : MessageCenterMessage
  {
    public bool Paused
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PauseStateChangedMessage() => throw null;
  }
}
