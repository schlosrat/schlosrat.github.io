// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IScriptValue
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
