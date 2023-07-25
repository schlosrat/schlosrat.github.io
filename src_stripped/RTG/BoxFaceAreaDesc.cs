// Decompiled with JetBrains decompiler
// Type: RTG.BoxFaceAreaDesc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;

namespace RTG
{
  public struct BoxFaceAreaDesc
  {
    public BoxFaceAreaType AreaType;
    public float Area;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public BoxFaceAreaDesc(BoxFaceAreaType areaType, float area) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static BoxFaceAreaDesc GetInvalid() => throw null;
  }
}
