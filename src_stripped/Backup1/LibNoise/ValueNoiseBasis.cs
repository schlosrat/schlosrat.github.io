// Decompiled with JetBrains decompiler
// Type: LibNoise.ValueNoiseBasis
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace LibNoise
{
  public class ValueNoiseBasis
  {
    private const int XNoiseGen = 1619;
    private const int YNoiseGen = 31337;
    private const int ZNoiseGen = 6971;
    private const int SeedNoiseGen = 1013;
    private const int ShiftNoiseGen = 8;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int IntValueNoise(int x, int y, int z, int seed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double ValueNoise(int x, int y, int z) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double ValueNoise(int x, int y, int z, int seed) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ValueNoiseBasis() => throw null;
  }
}
