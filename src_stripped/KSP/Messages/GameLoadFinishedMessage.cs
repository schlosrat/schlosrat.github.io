// Decompiled with JetBrains decompiler
// Type: KSP.Messages.GameLoadFinishedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/State/GameLoadFinishedMessage", true, "Event fired when the game loading sequence has finished", "")]
  public class GameLoadFinishedMessage : MessageCenterMessage
  {
    public bool IsSuccess;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameLoadFinishedMessage() => throw null;
  }
}
