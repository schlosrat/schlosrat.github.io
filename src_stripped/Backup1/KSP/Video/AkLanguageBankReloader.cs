// Decompiled with JetBrains decompiler
// Type: KSP.Video.AkLanguageBankReloader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.Logging;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace KSP.Video
{
  public class AkLanguageBankReloader : MonoBehaviour
  {
    private const LogFilter LOGTAG = LogFilter.Audio;
    private const string PREFIX = "[AkLanguageBankReloader] ";
    public List<string> banksToReload;
    public float reloadCheckDelay;
    private string lastLanguage;
    private float countdown;
    private Coroutine _bankReloadRoutine;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator Start() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void Update() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void HandleLanguageUpdateCheck() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private IEnumerator InternalUpdateBank(IList<string> bankPaths) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AkLanguageBankReloader() => throw null;
  }
}
