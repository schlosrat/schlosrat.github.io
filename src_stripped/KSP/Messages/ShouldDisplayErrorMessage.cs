// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ShouldDisplayErrorMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Gameplay/ShouldDisplayErrorMessage", true, "Error message that should get displayed from the log console window.", "")]
  public class ShouldDisplayErrorMessage : GameplayMessageBase
  {
    public string ErrorMessage;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ShouldDisplayErrorMessage() => throw null;
  }
}
