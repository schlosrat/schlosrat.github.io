// Decompiled with JetBrains decompiler
// Type: I2.Loc.TranslationJob_WEB
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public class TranslationJob_WEB : TranslationJob_WWW
  {
    private Dictionary<string, TranslationQuery> _requests;
    private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;
    public string mErrorMessage;
    private string mCurrentBatch_ToLanguageCode;
    private string mCurrentBatch_FromLanguageCode;
    private List<string> mCurrentBatch_Text;
    private List<KeyValuePair<string, string>> mQueries;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TranslationJob_WEB(
      Dictionary<string, TranslationQuery> requests,
      GoogleTranslation.fnOnTranslationReady OnTranslationReady)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FindAllQueries() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void ExecuteNextBatch() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override TranslationJob.eJobState GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessResult(byte[] bytes, string errorMsg) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private string ParseTranslationResult(string html, string OriginalText) => throw null;
  }
}
