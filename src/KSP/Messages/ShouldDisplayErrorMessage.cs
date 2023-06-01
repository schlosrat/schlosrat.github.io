// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ShouldDisplayErrorMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
