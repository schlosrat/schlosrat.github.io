// Decompiled with JetBrains decompiler
// Type: TestSceneUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
