// Decompiled with JetBrains decompiler
// Type: KSP.Assets.impl.CompiledScriptRecord
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using KSP.ScriptInterop;
using System;
using System.Runtime.CompilerServices;

namespace KSP.Assets.impl
{
  [Serializable]
  public struct CompiledScriptRecord : ICompiledScript
  {
    public string name;
    public string sourceFilePath;
    public string lastModifiedTimeUtc;
    public string base64;
    private byte[] byteCode;

    byte[] ICompiledScript.byteCode
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    string ICompiledScript.name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    string ICompiledScript.sourceFilePath
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    string ICompiledScript.lastModifiedTimeUtc
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }
  }
}
