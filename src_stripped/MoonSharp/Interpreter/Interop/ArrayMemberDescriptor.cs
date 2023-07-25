// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.ArrayMemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using MoonSharp.Interpreter.Interop.BasicDescriptors;
using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop
{
  public class ArrayMemberDescriptor : ObjectCallbackMemberDescriptor, IWireableDescriptor
  {
    private bool m_IsSetter;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArrayMemberDescriptor(string name, bool isSetter, ParameterDescriptor[] indexerParams) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ArrayMemberDescriptor(string name, bool isSetter) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PrepareForWiring(Table t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static int[] BuildArrayIndices(CallbackArguments args, int count) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static object ArrayIndexerSet(
      object arrayObj,
      ScriptExecutionContext ctx,
      CallbackArguments args)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private static object ArrayIndexerGet(
      object arrayObj,
      ScriptExecutionContext ctx,
      CallbackArguments args)
    {
      throw null;
    }
  }
}
