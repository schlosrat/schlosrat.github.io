﻿// Decompiled with JetBrains decompiler
// Type: ParameterBindingTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ParameterBindingTest : MonoBehaviour
{
  public ContextBindRoot root;
  public string nameValue;
  private DataContext context;
  [Space]
  [Header("debug \"buttons\"")]
  public bool toggleName;
  private bool nameIsOn;
  public bool toggleFPS;
  private bool fpsIsOn;
  public bool toggleTime;
  private bool timeIsOn;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdatePropertyLifetimes(bool init = false) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdatePropertyValues() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public ParameterBindingTest() => throw null;
}
