// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IScriptClass
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

namespace KSP.ScriptInterop
{
  public interface IScriptClass
  {
    string name { get; }

    IScriptClass RegisterChild(string name);

    void RegisterClrMethod(string name, object clrFunction);
  }
}
