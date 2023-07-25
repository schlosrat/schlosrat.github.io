// Decompiled with JetBrains decompiler
// Type: KSPBaseAudio
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public class KSPBaseAudio
{
  public static readonly string SubtitleSetCommand;
  private static bool verboseAudioLogging;

  [MethodImpl(MethodImplOptions.NoInlining)]
  private static void LogIfEnabled(string message) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static uint PostEvent(
    string eventName,
    GameObject owner,
    uint flags,
    AkCallbackManager.EventCallback callback,
    object cookie)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static uint PostEvent(
    uint eventID,
    GameObject owner,
    uint flags,
    AkCallbackManager.EventCallback callback,
    object cookie)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static uint PostEvent(uint eventID, GameObject gameObj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static uint PostEvent(string eventName, GameObject gameObj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static AKRESULT SetRTPCValueIfChanged(
    uint in_rtpcID,
    ref float cachedValue,
    float newValue,
    GameObject gameObj)
  {
    throw null;
  }

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static AKRESULT SetRTPCValue(uint in_rtpcID, float in_value, GameObject gameObj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static AKRESULT SetRTPCValue(uint in_rtpcID, double in_value, GameObject gameObj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static AKRESULT SetSwitch(uint in_switchGroup, uint in_switchState, GameObject gameObj) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static uint GetIDFromString(string id) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public static void OnAkCallback(object in_cookie, AkCallbackType in_type, object in_info) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  public KSPBaseAudio() => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  static KSPBaseAudio() => throw null;
}
