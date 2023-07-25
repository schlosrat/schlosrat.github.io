// Decompiled with JetBrains decompiler
// Type: KSP.Messages.OABPasteErrorMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/OABPasteErrorMessage", true, "Player has attempted to paste something that doesn't work or can't deserialize.", "")]
  public class OABPasteErrorMessage : OABMessageBase
  {
    public string Message;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABPasteErrorMessage() => throw null;
  }
}
