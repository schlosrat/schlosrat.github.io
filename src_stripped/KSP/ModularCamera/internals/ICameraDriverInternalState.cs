// Decompiled with JetBrains decompiler
// Type: KSP.ModularCamera.internals.ICameraDriverInternalState
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: EF61A348-EB87-4C99-B6BD-CBCF875CC384
// Assembly location: C:\KSP2\DLL_min\Assembly-CSharp.dll
// XML documentation location: C:\KSP2\DLL_min\Assembly-CSharp.xml

using System.Collections.Generic;
using UnityEngine;

namespace KSP.ModularCamera.internals
{
  public interface ICameraDriverInternalState
  {
    Transform PivotTransform { get; set; }

    Transform GimbalTransform { get; set; }

    Transform CameraTransform { get; set; }

    Dictionary<CameraInputBinding, CameraInputInterpreter> InputInterpreters { get; set; }

    Dictionary<CameraInputBinding, List<CameraInputModifier>> InputModifiers { get; set; }

    Dictionary<ValidatorType, Validator> Validators { get; set; }
  }
}
