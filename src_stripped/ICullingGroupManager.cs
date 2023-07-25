// Decompiled with JetBrains decompiler
// Type: ICullingGroupManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 57799B60-A4CD-4DF8-B3C9-AEC811D65AED
// Assembly location: C:\KSP2\DLL_stripped\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_stripped\Assembly-CSharp.xml

using System;
using UnityEngine;

public interface ICullingGroupManager
{
  int ReserveSphere(Action<CullingGroup, CullingGroupEvent> callback);

  void ReleaseSphere(int index);

  void SetSphere(int idex, Vector3 center, float radius);
}
