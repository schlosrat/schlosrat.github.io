// Decompiled with JetBrains decompiler
// Type: KSP.Messages.DismissAllNotificationsMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Gameplay/DismissAllNotificationsMessage", true, "Game is changing scene or returing to main menu, all notifications must be dismissed", "")]
  public class DismissAllNotificationsMessage : GameplayMessageBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public DismissAllNotificationsMessage() => throw null;
  }
}
