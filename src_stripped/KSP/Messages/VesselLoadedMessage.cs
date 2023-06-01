// Decompiled with JetBrains decompiler
// Type: KSP.Messages.VesselLoadedMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.OAB;
using System.Runtime.CompilerServices;

namespace KSP.Messages
{
  [DiscoverableMessage("Events/OAB/VesselLoadedMessage", true, "Player has loaded a vessel", "Currently both this and SubassemblyLoadedMessage are fired from the same code path")]
  public class VesselLoadedMessage : OABMessageBase
  {
    public bool HasAssembly;
    public bool IsFromSnapshot;
    public OABHistoricalSnapshot HistoricalSnapshot;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VesselLoadedMessage() => throw null;
  }
}
