// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IScriptValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace KSP.ScriptInterop
{
  public interface IScriptValue
  {
    bool IsNil { get; }

    object ToObject(Type dotNetType = null);

    T ToValue<T>();

    T? ToReference<T>() where T : struct;

    string ToString(FormatOptions options);

    string ToString();
  }
}
