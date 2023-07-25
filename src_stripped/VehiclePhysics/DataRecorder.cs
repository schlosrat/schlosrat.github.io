// Decompiled with JetBrains decompiler
// Type: VehiclePhysics.DataRecorder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace VehiclePhysics
{
  public class DataRecorder
  {
    private List<DataRecorder.FloatData[]> m_floatChannels;
    private List<Vector3[]> m_vector3Channels;
    private List<Quaternion[]> m_quaternionChannels;
    private float m_deltaTime;
    private int m_frameCapacity;
    private int m_writeFrame;
    private int m_readFrame;
    private int m_firstFrame;
    private int m_lastFrame;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DataRecorder(float recordTime, float recordDeltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void NextWriteFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RewriteFromRead() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetWriteFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetFirstFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetLastFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetReadPointers(
      float fromTime,
      float toTime,
      out int fromFrame,
      out int frameCount)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int ReadTimeSpan(float fromTime, float toTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveReadToFrame(int frame) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveReadToTime(float time) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveReadToStart() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void MoveReadToEnd() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool NextReadFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PrevReadFrame() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int NewFloatChannel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteFloatValue(int channel, float value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ReadFloatValue(int channel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int NewVector3Channel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteVector3Value(int channel, Vector3 value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Vector3 ReadVector3Value(int channel) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int NewQuaternionChannel() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void WriteQuaternionValue(int channel, Quaternion value) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Quaternion ReadQuaternionValue(int channel) => throw null;

    private class FloatData
    {
      public int frame;
      public float value;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public FloatData() => throw null;
    }
  }
}
