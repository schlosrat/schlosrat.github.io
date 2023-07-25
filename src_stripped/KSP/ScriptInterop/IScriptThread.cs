// Decompiled with JetBrains decompiler
// Type: KSP.ScriptInterop.IScriptThread
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace KSP.ScriptInterop
{
  public interface IScriptThread
  {
    bool IsReady { get; }

    bool IsFinished { get; }

    bool IsErrored { get; }

    IScriptValue ReturnValue { get; }

    event Action<IScriptValue> onFinished;

    void CreateCoroutine(IScriptValue script);

    void ResumeCoroutine();
  }
}
