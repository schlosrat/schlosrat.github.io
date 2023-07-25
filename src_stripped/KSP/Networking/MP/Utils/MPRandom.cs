// Decompiled with JetBrains decompiler
// Type: KSP.Networking.MP.Utils.MPRandom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP.Networking.MP.Utils
{
  public class MPRandom
  {
    public const uint DEFAULT_SEED = 0;
    public const uint DEFAULT_BIAS = 78665521;
    public const int DEFAULT_COUNTER = 0;
    private uint _seed;
    private uint _bias;
    private int _counter;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static uint GetTrulyRandomUInt32() => throw null;

    public uint Seed
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSeed(uint seed) => throw null;

    public uint Bias
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBias(uint bias) => throw null;

    public int Counter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCounter(int counter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPRandom() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPRandom(uint seed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPRandom(int seed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPRandom(uint seed, uint bias, int counter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public MPRandom(MPRandom src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(uint seed, uint bias = 78665521, int counter = 0) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Init(MPRandom src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Uninit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Set(MPRandom src) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetDebugString() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Advance() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint GetRandomUInt32() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetRandomInt32() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetRandomInt32Range(int min, int max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetRandomInt32RangeMaxExcluded(int min, int max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint GetRandomUInt32Range(uint min, uint max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint GetRandomUInt32RangeMaxExcluded(uint min, uint max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint GetRandomUInt32With32BitsNotZero() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint GetRandomUInt32With31BitsNotZero() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRandomFloatZeroToPositiveOne() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRandomFloatNegativeOneToPositiveOne() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetRandomFloatRange(float min, float max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetRandomDoubleZeroToPositiveOne() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetRandomDoubleNegativeOneToPositiveOne() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetRandomDoubleRange(double min, double max) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetRandomBool() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public uint GetRandomUInt32Key() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetRandomStringInRange(int stringLength, char charMin, char charMax) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public char GetRandomUpperAndLowerAlphaNumericChar() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetRandomUpperAndLowerAlphaPlusNumericString(int stringLength) => throw null;
  }
}
