// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Loaders.IScriptLoader
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

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
