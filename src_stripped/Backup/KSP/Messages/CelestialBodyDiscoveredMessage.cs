﻿// Decompiled with JetBrains decompiler
// Type: KSP.Messages.CelestialBodyDiscoveredMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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