// Decompiled with JetBrains decompiler
// Type: MoonSharp.Interpreter.Interop.BasicDescriptors.MemberDescriptor
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
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
