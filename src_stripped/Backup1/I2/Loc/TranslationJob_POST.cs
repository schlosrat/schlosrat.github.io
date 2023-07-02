// Decompiled with JetBrains decompiler
// Type: I2.Loc.TranslationJob_POST
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace I2.Loc
{
  public class TranslationJob_POST : TranslationJob_WWW
  {
    private Dictionary<string, TranslationQuery> _requests;
    private GoogleTranslation.fnOnTranslationReady _OnTranslationReady;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TranslationJob_POST(
      Dictionary<string, TranslationQuery> requests,
      GoogleTranslation.fnOnTranslationReady OnTranslationReady)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override TranslationJob.eJobState GetState() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ProcessResult(byte[] bytes, string errorMsg) => throw null;
  }
}
