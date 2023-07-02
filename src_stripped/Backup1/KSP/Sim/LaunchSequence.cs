// Decompiled with JetBrains decompiler
// Type: KSP.Sim.LaunchSequence
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace KSP.Sim
{
  public class LaunchSequence : StagedSequence
  {
    private LaunchSequence.Stages Foo;
    private static float Duration;
    private static List<Tuple<LaunchSequence.Stages, float>> DefaultCues;
    private static List<Tuple<LaunchSequence.Stages, float>> cues;
    private LaunchSequence.Stages stage;

    public override string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    private Dictionary<Enum, object> events
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public override Enum Events
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public LaunchSequence() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Update(double deltaTime) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Reset() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static LaunchSequence() => throw null;

    public enum Stages
    {
      SoundSupression,
      WaterStart,
      BurnoffStart,
      EngineStart,
      DroppingIce,
      LiftingOff,
      KillWater,
      KillBurnoff,
      KillIce,
      Complete,
    }
  }
}
