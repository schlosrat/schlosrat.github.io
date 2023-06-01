// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.IUserDataDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace MoonSharp.Interpreter.Interop
{
  public interface IUserDataDescriptor
  {
    string Name { get; }

    Type Type { get; }

    DynValue Index(Script script, object obj, DynValue index, bool isDirectIndexing);

    bool SetIndex(
      Script script,
      object obj,
      DynValue index,
      DynValue value,
      bool isDirectIndexing);

    string AsString(object obj);

    DynValue MetaIndex(Script script, object obj, string metaname);

    bool IsTypeCompatible(Type type, object obj);
  }
}
