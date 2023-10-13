// Decompiled with JetBrains decompiler
// Type: KSP.Sim.TravelFirsts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class TravelFirsts
  {
    public DictionaryValueList<string, TravelSimObjectFirst> SOIReached;
    public DictionaryValueList<string, TravelSimObjectFirst> CBLanded;
    public DictionaryValueList<string, TravelSimObjectFirst> WalkedOn;
    public DictionaryValueList<string, TravelSimObjectFirst> CBLaunched;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Load(SerializedTravelFirsts firsts) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void AddSerializedSimObjectFirst(
      DictionaryValueList<string, TravelSimObjectFirst> list,
      SerializedTravelSimObjectFirst firstEvent)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool AddSOIReached(VesselComponent vessel, double ut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool AddCBLanded(VesselComponent vessel, double ut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal bool AddCBLaunched(VesselComponent vessel, double ut) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private bool AddFirstsEvent(
      DictionaryValueList<string, TravelSimObjectFirst> list,
      string objectKey,
      IGGuid travelObjectId,
      double ut)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TravelFirsts() => throw null;
  }
}
