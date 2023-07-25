// Decompiled with JetBrains decompiler
// Type: KSP.Messages.OABInvalidPartAnchorMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/OABInvalidPartAnchorMessage", true, "Player has attempted to select new anchor on an invalid part.", "")]
  public class OABInvalidPartAnchorMessage : OABMessageBase
  {
    public string Message;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABInvalidPartAnchorMessage() => throw null;
  }
}
