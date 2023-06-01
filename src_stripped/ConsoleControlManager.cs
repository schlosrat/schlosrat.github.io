// Decompiled with JetBrains decompiler
// Type: ConsoleControlManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api;
using KSP.Game;
using KSP.OAB;
using KSP.Sim;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ConsoleControlManager
{
  [HideInInspector]
  public List<Action<bool>> UpdateIcons;
  [HideInInspector]
  public bool isVirtualMouseHold;
  [HideInInspector]
  public ObjectAssemblyUIEvents OABEvents;
  [HideInInspector]
  public MultiClickButton SymmetryButton;
  private bool isSymmetryHold;
  private float symmetryHoldtime;
  private bool isPCInput;
  private IDataContextReadonly ViewApiContext;
  private IDataContextReadonly TelemetryApiContext;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void TogglePCInput(bool val) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ConsoleControlManager() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsRCS() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsPCInput() => throw null;

  public ViewDataProvider ViewDataProvider
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  public bool RCSToggle
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool SASToggle
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public AltimeterDisplayMode AltimeterMode
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public SpeedDisplayMode VelocityMode
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  public bool IsUniverseTimePaused
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsRCSOn() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public bool IsSASOn() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateVEL() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateALT() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateRCS() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public void UpdateSAS() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateSymmetryMode() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public T NextValueEnum<T>(T input) where T : Enum => throw null;
}
