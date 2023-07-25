// Decompiled with JetBrains decompiler
// Type: KSP.Sim.SerializedTravelObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
