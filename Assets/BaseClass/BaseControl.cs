using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_Style_Off
{
   On,
   Off
}

public class BaseControl: MonoBehaviour
{
   // 位置
   public BaseRect GUIPos;
   // 内容
   public GUIContent Content;
   // 自定义样式开关
   public E_Style_Off StyleOnOrOff = E_Style_Off.Off;
   public GUIStyle Style;

   private void OnGUI()
   {
      switch (StyleOnOrOff)
      {
         case E_Style_Off.On:
            StyleOnShow();
            break;
         case E_Style_Off.Off:
            StyleOffShow();
            break;
         default:
            throw new ArgumentOutOfRangeException();
      }
   }

   protected virtual void StyleOnShow()
   {
      GUI.Button(GUIPos.Position, Content, Style);
   }
   
   protected virtual void StyleOffShow()
   {
      GUI.Button(GUIPos.Position, Content);
   }
}
