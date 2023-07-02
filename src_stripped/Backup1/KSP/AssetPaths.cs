// Decompiled with JetBrains decompiler
// Type: KSP.AssetPaths
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace KSP
{
  public static class AssetPaths
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static string AbsolutePath(string pathRelativeToAssets) => throw null;

    public static class LuaScripts
    {
      public const string Base = "LuaScripts";
      public const string Release = "LuaScripts/Release";
      public const string CelestialBodies = "LuaScripts/Release/CelestialBodies";
      public const string PlanetarySystems = "LuaScripts/Release/PlanetarySystems";
      public const string Parts = "LuaScripts/Release/Parts";
      public const string Debug = "LuaScripts/DebugBuilds";
      public const string IntegrationTests = "LuaScripts/DebugBuilds/IntegrationTests";
      public const string DebugHud = "LuaScripts/DebugBuilds/Hud";
      public const string Iteration = "LuaScripts/DebugBuilds/Iteration";
      public const string Scratch = "LuaScripts/DebugBuilds/Scratch";

      public static string BasicVessel
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public static string BasicPlanet
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public static string TinyUniverse
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public static string Ksp1Universe
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public static string Tools
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public static string ToolsDefaultFolder
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      public static string SimulationLuaFolder
      {
        [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static string Load() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static string LoadBasicPlanet() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static string LoadTinyUniverse() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static string LoadBasicVessel() => throw null;
    }
  }
}
