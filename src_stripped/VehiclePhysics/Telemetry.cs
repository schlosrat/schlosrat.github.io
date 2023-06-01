// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.Telemetry
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using EdyCommonTools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  [Serializable]
  public class Telemetry
  {
    private float m_fixedUpdateFrequency;
    private int m_frame;
    private double m_time;
    private double m_distance;
    private double m_totalTime;
    private double m_totalDistance;
    private int m_segmentNum;
    private BitArray32 m_markers;
    private Vector3 m_lastPosition;
    private List<Telemetry.ChannelGroupInfo> m_channelGroups;
    private List<Telemetry.ChannelInfo> m_channels;
    private Telemetry.DataRow m_dataRow;
    private List<Telemetry.SemanticInfo> m_semantics;
    private Telemetry.Specifications m_specs;
    private SortedDictionary<string, int> m_channelIndex;
    private ReadOnlyDictionary<string, int> m_channelIndexAsReadOnly;

    public float fixedUpdateFrequency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Telemetry.DataRow latest
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Telemetry.Specifications specs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IList<Telemetry.ChannelGroupInfo> channelGroups
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IList<Telemetry.ChannelInfo> channels
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IList<Telemetry.SemanticInfo> semantics
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public IDictionary<string, int> channelIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Telemetry.DistanceMode distanceMode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool adaptiveFrequency
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public bool debugLog
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public VehicleBase vehicle
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private Telemetry.SemanticInfo GetSemantic(int channelIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void UpdateDataRow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Telemetry(VehicleBase vehicle, float fixedUpdateFrequency = 50f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFixedUpdateFrequency(float fixedUpdateFrequency) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Update(
      float fixedDeltaTime,
      Vector3 position,
      bool reposition,
      Vector3 positionOffset)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplySpecifications() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Register<T>(UnityEngine.Object instance) where T : Telemetry.ChannelGroup => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Unregister<T>(UnityEngine.Object instance) where T : Telemetry.ChannelGroup => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsRegistered<T>(UnityEngine.Object instance) where T : Telemetry.ChannelGroup => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetChannelIndex(string channelName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string FormatChannelValue(int channelIndex, Telemetry.SemanticInfo semantic = null) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Telemetry.SemanticInfo GetChannelSemmantic(int channelIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public (float min, float max, float quantization) GetChannelRange(int channelIndex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetTime() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetDistance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSegmentNum(int segmentNum) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMarker(Telemetry.Marker marker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetMarker(int marker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsMarker(int markerData, int marker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsUniqueMarker(Telemetry.DataRow dataRow, int marker) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int CustomMarker(int index) => throw null;

    public class ChannelGroup
    {
      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual int GetChannelCount() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual float GetPollFrequency() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void GetChannelInfo(Telemetry.ChannelInfo[] channelInfo, UnityEngine.Object instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public virtual void PollValues(float[] values, int index, UnityEngine.Object instance) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ChannelGroup() => throw null;
    }

    public enum Semantic
    {
      Default,
      Custom,
      Ratio,
      SignedRatio,
      Speed,
      Gear,
      Acceleration,
      Weight,
      BankAngle,
      AngularVelocity,
      EngineRpm,
      EngineTorque,
      EnginePower,
      EngineLoad,
      FuelRate,
      WheelTorque,
      SuspensionTravel,
      SuspensionSpring,
      SuspensionForce,
      SuspensionSpeed,
      SlipAngle,
      SlipVelocity,
      TireForce,
      TireFriction,
      Max,
    }

    public class SemanticInfo
    {
      public float rangeMin;
      public float rangeMax;
      public float rangeQuantization;
      public float displayMultiplier;
      public string displayFormat;
      public string displayFormatAlt;
      public string displayUnitsSuffix;

      public string displayRangeMin
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public string displayRangeMax
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public string displayUnits
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public float range
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string FormatValue(float value) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string FormatValueNoUnits(float value) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string FormatValueAlt(float value) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public string FormatValueWithUpdate(float value, bool updated) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetRangeAndFormat(
        float min,
        float max,
        string format,
        string units,
        float quantization = 0.1f,
        float multiplier = 1f,
        string alternateFormat = "")
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public SemanticInfo() => throw null;
    }

    public class Specifications
    {
      public float maxSpeed;
      public int maxGearPosition;
      public int minGearPosition;
      public float maxAcceleration;
      public float maxEngineRpm;
      public float maxEngineTorque;
      public float minEngineTorque;
      public float maxEnginePowerKw;
      public float minEnginePowerKw;
      public float maxEngineFuelRate;
      public float maxSuspensionTravel;
      public float maxSuspensionSpring;
      public float maxWheelTorque;
      public float maxSuspensionLoad;
      public float maxTireForce;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public Specifications() => throw null;
    }

    public class ChannelInfo
    {
      public string name;
      public Telemetry.Semantic semantic;
      public Telemetry.SemanticInfo customSemantic;
      private Telemetry.ChannelGroupInfo m_group;

      public Telemetry.ChannelGroupInfo group
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public string fullName
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ChannelInfo(Telemetry.ChannelGroupInfo channelGroup) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetNameAndSemantic(
        string channelName,
        Telemetry.Semantic channelSemantic,
        Telemetry.SemanticInfo customChannelSemantic = null)
      {
        throw null;
      }
    }

    public class ChannelGroupInfo
    {
      public UnityEngine.Object instance;
      private Telemetry.ChannelGroup m_channelGroup;
      private int m_channelBaseIndex;
      private int m_channelCount;
      private System.Type m_groupType;
      private int m_groupTypeIndex;
      private int m_updateInterval;
      private float m_expectedFrequency;
      private float m_actualFrequency;

      public Telemetry.ChannelGroup channels
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int channelCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public float expectedFrequency
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public float actualFrequency
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int updateInterval
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int channelBaseIndex
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public System.Type type
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int typeIndex
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public int typeCount
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
        [MethodImpl(MethodImplOptions.NoInlining)] private set => throw null;
      }

      public string typeName
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public ChannelGroupInfo(
        Telemetry.ChannelGroup group,
        int baseIndex,
        float fixedUpdateFrequency,
        int groupTypeIndex)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetFixedUpdateFrequency(float fixedUpdateFrequency) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetTypeCount(int count) => throw null;
    }

    public class DataRow
    {
      public int frame;
      public double time;
      public double distance;
      public double totalTime;
      public double totalDistance;
      public int segmentNum;
      public int markers;
      public bool valuesUpdated;
      public float[] values;
      public bool[] updated;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DataRow(int channels = 0) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void CopyFrom(Telemetry.DataRow dataRow) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Allocate(int channels) => throw null;
    }

    public enum DistanceMode
    {
      Displacement,
      Gps,
    }

    public enum Marker
    {
      TimeReset = 0,
      DistanceReset = 1,
      Reposition = 2,
      StartLinePass = 3,
      SectorLinePass = 4,
      Driver = 8,
      Contact = 9,
      OffTrack = 10, // 0x0000000A
      Impact = 11, // 0x0000000B
      Custom = 16, // 0x00000010
    }
  }
}
