// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.ITypeInterop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
