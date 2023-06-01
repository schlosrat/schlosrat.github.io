// Decompiled with JetBrains decompiler
// Type: KSP.Messages.GamePauseToggledMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Map/GamePauseToggledMessage", true, "Game pause is toggled on/off.", "")]
  public class GamePauseToggledMessage : MessageCenterMessage
  {
    public bool IsPaused;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GamePauseToggledMessage() => throw null;
  }
}
