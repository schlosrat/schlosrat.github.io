// Decompiled with JetBrains decompiler
// Type: TestWwiseEventPlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class TestWwiseEventPlay : MonoBehaviour
{
  public AK.Wwise.Event sound;
  private const uint EVENT_CALLBACK_FLAG = 1669332991;
  private uint playingId;
  [FormerlySerializedAs("startNew")]
  public bool start;
  public bool stop;
  private float waitDelay;
  private float durationMs;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DoStart() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void DoStop() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void Update() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private void CallbackHandler(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public TestWwiseEventPlay() => throw null;
}
