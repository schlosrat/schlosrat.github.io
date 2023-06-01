// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
  public interface IOverloadableMemberDescriptor : IMemberDescriptor
  {
    DynValue Execute(
      Script script,
      object obj,
      ScriptExecutionContext context,
      CallbackArguments args);

    Type ExtensionMethodType { get; }

    ParameterDescriptor[] Parameters { get; }

    Type VarArgsArrayType { get; }

    Type VarArgsElementType { get; }

    string SortDiscriminant { get; }
  }
}
