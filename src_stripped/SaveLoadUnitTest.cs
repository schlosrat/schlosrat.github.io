// Decompiled with JetBrains decompiler
// Type: SaveLoadUnitTest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof (Text))]
public class SaveLoadUnitTest : MonoBehaviour
{
  private IConsoleStorage consoleStorage;
  private bool writeSyncSuccess;
  private bool writeAsyncSuccess;
  private bool writeAsyncCoroutineSuccess;
  private bool startUnitTest;
  private string readSyncData;
  private string readAsyncData;
  private string readAsyncCoroutineData;
  private Text text;
  private IAsyncWriter writer;
  private IAsyncReader reader;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Start() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CreateConsoleStorage() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void SyncUnitTest(string absFullPath, string data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AsyncUnitTest(string absFullPath, string data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void AsyncCoroutineUnitTest(string absFullPath, string data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator WriteAsyncTest(string absFullPath, string data) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private IEnumerator ReadAsyncTest(string absFullPath) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void UpdateText() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public SaveLoadUnitTest() => throw null;
}
