// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IRunScriptInterop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
