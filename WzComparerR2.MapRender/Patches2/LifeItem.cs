﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using WzComparerR2.Rendering;
using WzComparerR2.WzLib;

namespace WzComparerR2.MapRender.Patches2
{
    public class LifeItem : SceneItem
    {
        public int ID { get; set; }
        public LifeType Type { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int MobTime { get; set; }
        public bool Flip { get; set; }
        public bool Hide { get; set; }
        public int Fh { get; set; }
        public int Cy { get; set; }
        public int Rx0 { get; set; }
        public int Rx1 { get; set; }

        public ItemView View { get; set; }

        public LifeInfo LifeInfo { get; set; }
        public bool HideName { get; set; }
        public CustomFontFunc CustomFont { get; set; }

        public static LifeItem LoadFromNode(Wz_Node node)
        {
            var item = new LifeItem()
            {
                ID = node.Nodes["id"].GetValueEx(0),
                Type = ParseLifeType(node.Nodes["type"].GetValueEx<string>(null)),
                X = node.Nodes["x"].GetValueEx(0),
                Y = node.Nodes["y"].GetValueEx(0),
                MobTime = node.Nodes["mobTime"].GetValueEx(0),
                Flip = node.Nodes["f"].GetValueEx(false),
                Hide = node.Nodes["hide"].GetValueEx(false),
                Fh = node.Nodes["fh"].GetValueEx(0),
                Cy = node.Nodes["cy"].GetValueEx(0),
                Rx0 = node.Nodes["rx0"].GetValueEx(0),
                Rx1 = node.Nodes["rx1"].GetValueEx(0)
            };
            return item;
        }

        public static CustomFontFunc LoadCustomFontFunc(Wz_Node node)
        {
            var customFontFunc = new CustomFontFunc()
            {
                Font = node.Nodes["font"].GetValueEx<string>(null),
                FontSize = node.Nodes["fontSize"]?.GetValue<int>(),
            };
            string fontColor = node.Nodes["fontColor"].GetValueEx<string>(null);
            if (fontColor != null && int.TryParse(fontColor, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int argbColor))
            {
                customFontFunc.FontColor = MonogameUtils.ToXnaColor(argbColor);
            }
            return customFontFunc;
        }

        private static LifeType ParseLifeType(string text)
        {
            switch (text)
            {
                case "m": return LifeType.Mob;
                case "n": return LifeType.Npc;
                default: return LifeType.Unknown;
            }
        }

        public class ItemView
        {
            /// <summary>
            /// 时间关联，单位为毫秒。
            /// </summary>
            public int Time { get; set; }

            /// <summary>
            /// 动画资源。
            /// </summary>
            public object Animator { get; set; }
        }

        public enum LifeType
        {
            Unknown = 0,
            Mob = 1,
            Npc = 2
        }

        public class CustomFontFunc
        {
            public string Font { get; set; }
            public Color? FontColor { get; set; }
            public int? FontSize { get; set; }
        }
    }
}
