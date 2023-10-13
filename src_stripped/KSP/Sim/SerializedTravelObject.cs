// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedTravelObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using Newtonsoft.Json;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  [Serializable]
  public class SerializedTravelObject
  {
    public Guid TravelObjectId;
    public TravelObjectStatistics Statistics;

    [JsonConstructor]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedTravelObject() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializedTravelObject(TravelObject tObject) => throw null;
  }
}
