// Decompiled with JetBrains decompiler
// Type: KSP.Messages.PartSeparatedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.OAB;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/PartSeparatedMessage", true, "Player has removed a part from the assembly", "")]
  public class PartSeparatedMessage : OABPartMessageBase
  {
    public IObjectAssemblyPart partDetachedFrom;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PartSeparatedMessage() => throw null;
  }
}
