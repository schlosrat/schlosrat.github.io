// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ForceDecreaseTimewarpMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Map/ForceDecreaseTimewarpMessage", true, "Timewarp rate is too high, force decrease is required.", "")]
  public class ForceDecreaseTimewarpMessage : MessageCenterMessage
  {
    public string BodyDisplayName;
    public string TimeScaleFactor;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ForceDecreaseTimewarpMessage() => throw null;
  }
}
