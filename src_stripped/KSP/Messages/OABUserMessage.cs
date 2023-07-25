// Decompiled with JetBrains decompiler
// Type: KSP.Messages.OABUserMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/State/OABUserMessage", true, "OAB needs to display a message to the user", "")]
  public class OABUserMessage : OABMessageBase
  {
    public string Message;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public OABUserMessage() => throw null;
  }
}
