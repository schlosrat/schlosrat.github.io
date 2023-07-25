// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.IUserDataDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
