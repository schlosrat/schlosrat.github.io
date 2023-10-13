// Decompiled with JetBrains decompiler
// Type: KSP.Sim.impl.SimUniverseTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0F37EC74-8184-4DF6-B7AF-AB13D81C547A
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp-stripped.xml

using System.Runtime.CompilerServices;

namespace KSP.Sim.impl
{
  public struct SimUniverseTime
  {
    public bool IsPaused;
    public double UniverseTime;
    public double UniverseTimeDelta;
    public TimeScaleValues TimewarpScalars;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SimUniverseTime(
      bool isPaused,
      double ut,
      double deltaUT,
      TimeScaleValues timewarpScalars)
    {
      throw null;
    }
  }
}
