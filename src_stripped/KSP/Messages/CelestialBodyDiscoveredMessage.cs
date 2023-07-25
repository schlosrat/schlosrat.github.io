// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CelestialBodyDiscoveredMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/CelestialBody/CelestialBodyDiscoveredMessage", false, "Player has discovered a celestial body", "")]
  public class CelestialBodyDiscoveredMessage : CelestialBodyMessageBase
  {
    public string DiscoveredBodyName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public CelestialBodyDiscoveredMessage(string discoveredBodyName) => throw null;
  }
}
