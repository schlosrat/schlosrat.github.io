// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Loaders.IScriptLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;

namespace MoonSharp.Interpreter.Loaders
{
  public interface IScriptLoader
  {
    object LoadFile(string file, Table globalContext);

    [Obsolete("This serves almost no purpose. Kept here just to preserve backward compatibility.")]
    string ResolveFileName(string filename, Table globalContext);

    string ResolveModuleName(string modname, Table globalContext);
  }
}
