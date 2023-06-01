// Decompiled with JetBrains decompiler
// Type: KSP.Assets.impl.CompiledScriptRecord
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
