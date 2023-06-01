// Decompiled with JetBrains decompiler
// Type: KSP.Messages.OABUserMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
