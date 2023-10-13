// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.TelemetryDataset
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace VehiclePhysics
{
  public class TelemetryDataset
  {
    private List<TelemetryDataset.DataReference> m_dataReferences;
    private List<List<(float value, bool updated)>> m_channels;
    private Telemetry m_telemetry;
    private int m_nextCapacity;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private int NextCapacity() => throw null;

    public Telemetry telemetry
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public int capacity
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TelemetryDataset(Telemetry telemetry, int initialCapacity = 1000) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Telemetry.DataRow dataRow) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IList<TelemetryDataset.DataReference> GetDataReferences() => throw null;

    public TelemetryDataset.DataReference this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetFrameNum(int dataRow) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsChannel(int channel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IList<(float value, bool updated)> GetChannelValues(int channel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public (bool hasValues, float latestValue) GetLatestChannelValue(int channel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public (bool hasValues, float value) GetChannelValue(int channel, int entry) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetChannelCapacity(int channel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FindTotalTime(int first, int last, double totalTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int FindTotalDistance(int first, int last, double totalDistance) => throw null;

    public struct DataReference
    {
      public int frame;
      public double time;
      public double distance;
      public double totalTime;
      public double totalDistance;
      public int segmentNum;
      public int markers;
    }

    [StructLayout(LayoutKind.Sequential, Size = 1)]
    private struct TotalTimeComparer : IComparer<TelemetryDataset.DataReference>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public int Compare(TelemetryDataset.DataReference a, TelemetryDataset.DataReference b) => throw null;
    }

    [StructLayout(LayoutKind.Sequential, Size = 1)]
    private struct TotalDistanceComparer : IComparer<TelemetryDataset.DataReference>
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public int Compare(TelemetryDataset.DataReference a, TelemetryDataset.DataReference b) => throw null;
    }
  }
}
