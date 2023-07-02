// Decompiled with JetBrains decompiler
// Type: KSP.Modules.WheelSubsystem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
