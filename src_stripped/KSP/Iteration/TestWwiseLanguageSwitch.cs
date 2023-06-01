// Decompiled with JetBrains decompiler
// Type: KSP.Iteration.TestWwiseLanguageSwitch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using KSP.Logging;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Iteration
{
  public class TestWwiseLanguageSwitch : MonoBehaviour
  {
    private const LogFilter LOGTAG = LogFilter.Audio;
    public AK.Wwise.Event sound;
    private uint _playingID;
    private float _secondsUntilRestart;
    [Header("click to set to 'English'")]
    public bool setEnglish;
    [Header("click to set to 'Spanish'")]
    public bool setSpanish;
    private const string ENGLISH_LANGUAGE = "English";
    private const string SPANISH_LANGUAGE = "Spanish";
    [Space]
    [Header("enter language, then hit update")]
    public string language;
    public bool updateLanguage;
    private bool _haveSound;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RestartSound() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleEventCallbacks(
      object in_cookie,
      AkCallbackType in_type,
      AkCallbackInfo in_info)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TestWwiseLanguageSwitch() => throw null;
  }
}
