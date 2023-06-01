// Decompiled with JetBrains decompiler
// Type: KSP.Modules.WheelSubsystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Sim.Definitions;
using System.Runtime.CompilerServices;

namespace KSP.Modules
{
  public class WheelSubsystem
  {
    public string reason;
    public WheelSubsystem.SystemTypes type;
    public PartBehaviourModule owner;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WheelSubsystem(
      string reason,
      WheelSubsystem.SystemTypes type,
      PartBehaviourModule owner)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool IsType(WheelSubsystem.SystemTypes type) => throw null;

    public enum SystemTypes
    {
      All = -1, // 0xFFFFFFFF
      Any = -1, // 0xFFFFFFFF
      None = 0,
      Tire = 1,
      Suspension = 2,
      Steering = 4,
      Motor = 8,
      Brakes = 16, // 0x00000010
      WheelCollider = 32, // 0x00000020
      Bogey = 64, // 0x00000040
    }
  }
}
