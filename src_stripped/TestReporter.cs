﻿// Decompiled with JetBrains decompiler
// Type: TestReporter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;

public class TestReporter : MonoBehaviour
{
  public int logTestCount;
  public int threadLogTestCount;
  public bool logEverySecond;
  private int currentLogTestCount;
  private Reporter reporter;
  private GUIStyle style;
  private Rect rect1;
  private Rect rect2;
  private Rect rect3;
  private Rect rect4;
  private Rect rect5;
  private Rect rect6;
  private Thread thread;
  private float elapsed;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void threadLogTest() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnGUI() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TestReporter() => throw null;
}
