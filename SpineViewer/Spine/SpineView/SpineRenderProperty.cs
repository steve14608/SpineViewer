﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpineViewer.Spine;
using SpineViewer.Utils.Localize;

namespace SpineViewer.Spine.SpineView
{
    /// <summary>
    /// 用于在 PropertyGrid 上显示 Spine 渲染设置的包装类
    /// </summary>
    public class SpineRenderProperty(SpineObject spine)
    {
        [Browsable(false)]
        public SpineObject Spine { get; } = spine;

		/// <summary>
		/// 是否被隐藏, 被隐藏的模型将仅仅在列表显示, 不参与其他行为
		/// </summary>
		[LocalizedDisplayName(typeof(Properties.Resources), "isHidden")]
        public bool IsHidden { get => Spine.IsHidden; set => Spine.IsHidden = value; }

		/// <summary>
		/// 是否使用预乘Alpha
		/// </summary>
		[LocalizedDisplayName(typeof(Properties.Resources), "usePremultipliedAlpha")]
		public bool UsePremultipliedAlpha { get => Spine.UsePma; set => Spine.UsePma = value; }
    }
}
