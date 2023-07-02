// Decompiled with JetBrains decompiler
// Type: UnityEngine.PostProcessing.GetSetAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace UnityEngine.PostProcessing
{
  public sealed class GetSetAttribute : PropertyAttribute
  {
    public readonly string name;
    public bool dirty;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public GetSetAttribute(string name) => throw null;
  }
}
