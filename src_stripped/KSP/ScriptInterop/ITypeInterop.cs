// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.ITypeInterop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;
using System.Collections.Generic;

namespace KSP.ScriptInterop
{
  public interface ITypeInterop
  {
    Dictionary<string, string> GetTypes();

    object ToValue(Type dotNetType, IScriptValue scriptValue);

    IScriptValue FromValue(Type dotNetType, object objectValue);

    T ToValue<T>(IScriptValue scriptValue);

    IScriptValue FromValue<T>(T objectValue);
  }
}
