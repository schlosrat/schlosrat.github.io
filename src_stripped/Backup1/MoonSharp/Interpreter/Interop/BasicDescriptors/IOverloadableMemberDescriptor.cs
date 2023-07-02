// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.BasicDescriptors.IOverloadableMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

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
