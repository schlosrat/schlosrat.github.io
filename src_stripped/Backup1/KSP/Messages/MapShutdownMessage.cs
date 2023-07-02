// Decompiled with JetBrains decompiler
// Type: KSP.Messages.MapShutdownMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/Map/MapShutdownMessage", true, "Player has initialized the closing of the map view", "")]
  public class MapShutdownMessage : MessageCenterMessage
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public MapShutdownMessage() => throw null;
  }
}
