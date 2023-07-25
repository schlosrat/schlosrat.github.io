// Decompiled with JetBrains decompiler
// Type: KSP.Messages.GameLanguageChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
