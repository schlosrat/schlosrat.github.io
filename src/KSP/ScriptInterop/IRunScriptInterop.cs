// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IRunScriptInterop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.ScriptInterop
{
  public interface IRunScriptInterop
  {
    IScriptValue RunScript(string scriptString, string codeFriendlyName = null);

    IScriptValue RunScript(ICompiledScript compiledScript);

    IScriptValue RunScript(byte[] script, string codeFriendlyName = null);

    IScriptThread RunScriptAsync(string scriptId);
  }
}
