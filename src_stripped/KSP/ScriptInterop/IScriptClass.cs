// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IScriptClass
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace KSP.ScriptInterop
{
  public interface IScriptClass
  {
    string name { get; }

    IScriptClass RegisterChild(string name);

    void RegisterClrMethod(string name, object clrFunction);
  }
}
