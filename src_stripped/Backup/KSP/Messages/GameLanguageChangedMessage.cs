// Decompiled with JetBrains decompiler
// Type: KSP.Messages.GameLanguageChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
