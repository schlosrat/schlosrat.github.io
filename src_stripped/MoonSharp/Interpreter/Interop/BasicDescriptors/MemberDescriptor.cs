// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.BasicDescriptors.MemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace MoonSharp.Interpreter.Interop.BasicDescriptors
{
  public static class MemberDescriptor
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool HasAllFlags(this MemberDescriptorAccess access, MemberDescriptorAccess flag) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanRead(this IMemberDescriptor desc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanWrite(this IMemberDescriptor desc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static bool CanExecute(this IMemberDescriptor desc) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static DynValue GetGetterCallbackAsDynValue(
      this IMemberDescriptor desc,
      Script script,
      object obj)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static IMemberDescriptor WithAccessOrNull(
      this IMemberDescriptor desc,
      MemberDescriptorAccess access)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CheckAccess(
      this IMemberDescriptor desc,
      MemberDescriptorAccess access,
      object obj)
    {
      throw null;
    }
  }
}
