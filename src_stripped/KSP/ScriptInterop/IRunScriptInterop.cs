// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IRunScriptInterop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
