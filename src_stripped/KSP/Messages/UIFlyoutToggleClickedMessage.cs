// Decompiled with JetBrains decompiler
// Type: KSP.Messages.UIFlyoutToggleClickedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
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
