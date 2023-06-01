// Decompiled with JetBrains decompiler
// Type: KSP.Messages.ManeuverCreatedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Map;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Maneuver/ManeuverCreatedMessage", true, "A new Manuever node has been Created and Initialized", "")]
  public class ManeuverCreatedMessage : MessageCenterMessage
  {
    public MapManeuverGizmo mapManeuverGizmo
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ManeuverCreatedMessage() => throw null;
  }
}
