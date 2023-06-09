﻿// Decompiled with JetBrains decompiler
// Type: PhysicsSettingsManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
