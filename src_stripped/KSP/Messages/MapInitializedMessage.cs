// Decompiled with JetBrains decompiler
// Type: KSP.Messages.MapInitializedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
