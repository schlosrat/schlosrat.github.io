// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.IUserDataType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

namespace MoonSharp.Interpreter.Interop
{
  public interface IUserDataType
  {
    DynValue Index(Script script, DynValue index, bool isDirectIndexing);

    bool SetIndex(Script script, DynValue index, DynValue value, bool isDirectIndexing);

    DynValue MetaIndex(Script script, string metaname);
  }
}
