// Decompiled with JetBrains decompiler
// Type: I2.Loc.TranslationJob_GET
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public class TranslationJob_GET : TranslationJob_WWW
  {
    private Dictionary<string, TranslationQuery> _requests;
    private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;
    private List<string> mQueries;
    public string mErrorMessage;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TranslationJob_GET(
      Dictionary<string, TranslationQuery> requests,
      GoogleTranslation.fnOnTranslationReady OnTranslationReady)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteNextQuery() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override TranslationJob.eJobState GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessResult(byte[] bytes, string errorMsg) => throw null;
  }
}
