// Decompiled with JetBrains decompiler
// Type: SgtShape
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F07798AD-7FDC-4402-AB44-D85C99F8E7B0
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class SgtShape : MonoBehaviour
{
  [MethodImpl(MethodImplOptions.NoInlining)]
  public abstract float GetDensity(Vector3 worldPoint) => throw null;

  [MethodImpl(MethodImplOptions.NoInlining)]
  protected SgtShape() => throw null;
}
