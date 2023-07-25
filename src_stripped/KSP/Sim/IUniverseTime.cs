// Decompiled with JetBrains decompiler
// Type: KSP.Sim.IUniverseTime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.Sim
{
  public interface IUniverseTime
  {
    IUniverseTimeCommandEntry CommandEntry { get; }

    event Action<bool> IsTimePausedChanged;

    bool IsTimePaused { get; }

    event Action<TimeScaleValues> TimeScaleChanged;

    event Action<float> UniverseTimeScaleChanged;

    TimeScaleValues TimeScaleValues { get; }

    float PhysicsTimeScale { get; }

    float PhysicsToUniverseMultiplier { get; }

    float UniverseTimeScale { get; }

    float MaxPhysicsTimeScale { get; }

    float MaxUniverseTimeScale { get; }
  }
}
