// Decompiled with JetBrains decompiler
// Type: TestSceneUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Messages;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof (MessageCenter))]
public class TestSceneUtility : MonoBehaviour
{
  private static bool _initialized;
  private static MessageCenter _messages;

  public static MessageCenter Messages
  {
    [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void OnDestroy() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TestSceneUtility() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static TestSceneUtility() => throw null;
}
