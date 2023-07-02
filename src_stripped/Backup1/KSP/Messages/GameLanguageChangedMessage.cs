// Decompiled with JetBrains decompiler
// Type: KSP.Messages.GameLanguageChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Gameplay/GameLanguageChangedMessage", true, "Players changed language", "")]
  public class GameLanguageChangedMessage : GameplayMessageBase
  {
    public string langCode;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GameLanguageChangedMessage() => throw null;
  }
}
