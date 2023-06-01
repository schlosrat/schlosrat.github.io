// Decompiled with JetBrains decompiler
// Type: PhysicsSettingsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Game;
using System;
using System.Runtime.CompilerServices;

public class PhysicsSettingsManager
{
  public static bool IsPhysicsSettingsLoaded;
  private static bool _physicsSettingsFileExists;
  private static bool _isInitialized;

  public GameInstance Game
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public static event Action OnPhysicsSettingsLoaded
  {
    [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void Initialize() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool LoadPhysicsSettings() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static bool DoesVersionRequireResetToDefaults(string version) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void AddLiftingSurfaceCurves() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void SetSurfaceCurves() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UsedOnlyForAOTCodeGeneration() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public PhysicsSettingsManager() => throw null;
}
