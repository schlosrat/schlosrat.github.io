// Decompiled with JetBrains decompiler
// Type: TestWwiseEventPlay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
