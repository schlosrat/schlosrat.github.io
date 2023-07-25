// Decompiled with JetBrains decompiler
// Type: KSP.Game.Serialization.SerializationUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Sim;
using KSP.Sim.Definitions;
using KSP.Sim.impl;
using System.Runtime.CompilerServices;

namespace KSP.Game.Serialization
{
  public class SerializationUtility
  {
    public static GameInstance Game
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerializedAssembly VesselToSerializable(
      SimulationObjectModel vessel,
      bool isAutosave)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerializedLocation SerializeLocation(
      SimulationObjectModel vessel,
      SerializationUtility.RigidBodySerializationMode rbSerializationMode = SerializationUtility.RigidBodySerializationMode.Default)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerializedPart SerializePart(PartComponent partComponent) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerializedFlag SerializePlantedFlag(SimulationObjectModel flag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static SerializedLocation SerializePlantedFlagLocation(SimulationObjectModel flag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static SerializedLegacyModuleData ToSerializedLegacyModuleData(IPartModule comp) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public SerializationUtility() => throw null;

    public enum RigidBodySerializationMode
    {
      Invalid,
      Default,
      LocalUp,
    }
  }
}
