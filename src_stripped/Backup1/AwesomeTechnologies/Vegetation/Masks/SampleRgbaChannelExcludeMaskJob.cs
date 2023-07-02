// Decompiled with JetBrains decompiler
// Type: AwesomeTechnologies.Vegetation.Masks.SampleRgbaChannelExcludeMaskJob
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using AwesomeTechnologies.VegetationSystem;
using System.Runtime.CompilerServices;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace AwesomeTechnologies.Vegetation.Masks
{
  [BurstCompile]
  public struct SampleRgbaChannelExcludeMaskJob : IJobParallelForDefer
  {
    public NativeArray<float3> Position;
    public NativeArray<byte> Excluded;
    [ReadOnly]
    public NativeArray<RGBABytes> RgbaNativeArray;
    public bool Inverse;
    public int SelectedChannel;
    public int Width;
    public int Height;
    public Rect TextureRect;
    public float MinValue;
    public float MaxValue;
    public float2 Repeat;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Execute(int index) => throw null;
  }
}
