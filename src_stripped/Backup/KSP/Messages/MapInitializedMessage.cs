// Decompiled with JetBrains decompiler
// Type: KSP.Messages.MapInitializedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Map/MapInitializedMessage", true, "Player has initialized the map view", "Whenever the map in any form is shown, be it 2D or 3D, this is called. This includes 2D tracking UI for things like the KSC, or colonies")]
  public class MapInitializedMessage : MessageCenterMessage
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapInitializedMessage() => throw null;
  }
}
