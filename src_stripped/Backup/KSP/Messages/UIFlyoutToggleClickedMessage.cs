// Decompiled with JetBrains decompiler
// Type: KSP.Messages.UIFlyoutToggleClickedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Gameplay/UIFlyoutToggleClickedMessage", true, "Player has clicked a flyout item in the UI", "")]
  public class UIFlyoutToggleClickedMessage : GameplayMessageBase
  {
    public int Value;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public UIFlyoutToggleClickedMessage() => throw null;
  }
}
