// Decompiled with JetBrains decompiler
// Type: KSP.Messages.UIFlyoutToggleClickedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
