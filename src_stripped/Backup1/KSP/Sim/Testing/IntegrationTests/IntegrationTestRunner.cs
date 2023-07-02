// Decompiled with JetBrains decompiler
// Type: KSP.Sim.Testing.IntegrationTests.IntegrationTestRunner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Sim.Testing.IntegrationTests
{
  public class IntegrationTestRunner : MonoBehaviour, ITestManager
  {
    private string startScene;
    public static ITestManager testManager;
    public SceneList testSuites;
    private string currentSuite;
    private string currentTest;
    private int suiteFailures;
    private int testcaseFailures;
    private string _log;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator testCoroutine() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BeginSuite(string suiteName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EndSuite(string suiteName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void BeginTestCase(string testCaseName) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FailTestCase(string testCaseName, string reason) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EndTestCase(string testCaseName) => throw null;

    public string Log
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void appendLog(string appendedText, bool error = false) => throw null;

    public event Action<string> OnLogAppended
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    public bool AcceptsCommands
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnterCommand(string command) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IntegrationTestRunner() => throw null;
  }
}
