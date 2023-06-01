// Decompiled with JetBrains decompiler
// Type: ParameterBindingTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Api.CoreTypes;
using KSP.UI.Binding;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ParameterBindingTest : MonoBehaviour
{
  public ContextBindRoot root;
  public string nameValue;
  private DataContext context;
  [Header("debug \"buttons\"")]
  [Space]
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
