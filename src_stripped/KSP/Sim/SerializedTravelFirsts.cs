// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedTravelFirsts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedTravelFirsts
  {
    public List<SerializedTravelSimObjectFirst> SOIReached;
    public List<SerializedTravelSimObjectFirst> CBLanded;
    public List<SerializedTravelSimObjectFirst> WalkedOn;
    public List<SerializedTravelSimObjectFirst> CBLaunched;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Save(TravelFirsts firsts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedTravelFirsts() => throw null;
  }
}
