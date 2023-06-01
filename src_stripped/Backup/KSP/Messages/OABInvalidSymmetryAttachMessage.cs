// Decompiled with JetBrains decompiler
// Type: KSP.Messages.OABInvalidSymmetryAttachMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/OABInvalidSymmetryAttachMessage", true, "Player has attempted to perform an attachment to an invalid attach node.", "")]
  public class OABInvalidSymmetryAttachMessage : OABMessageBase
  {
    public string Message;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABInvalidSymmetryAttachMessage() => throw null;
  }
}
