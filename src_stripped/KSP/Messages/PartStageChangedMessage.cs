// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PartStageChangedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Staging/PartStageChangedMessage", true, "Player has moved a part from one stage to another", "")]
  public class PartStageChangedMessage : StagingMessageBase
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartStageChangedMessage() => throw null;
  }
}
