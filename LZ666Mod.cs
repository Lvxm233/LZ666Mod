
using System;
using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.UI;
using Terraria.DataStructures;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using ReLogic.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

// 用两个斜杠开头的句子都是注释QAQ，对程序运行没有任何影响，读我就行了，不用删

// 以上都是需要使用的程序集，不要乱动，不然代码会出问题

// 引入命名空间，这里就是MOD的名字417Mod
namespace LZ666Mod
{
	// MOD的主类名字，需要与文件名、MOD名完全一致，并且继承Mod类
	public class LZ666Mod : Mod
	{
		public LZ666Mod()
		{
			// MOD的初始化函数，用来设置一些属性
			// 注意，这跟Load() 函数不一样
			Properties = new ModProperties()
			{
				// 自动加载贴图什么的
				Autoload = true,

				// 自动加载血块贴图
				AutoloadGores = true,

				// 自动加载声音文件
				AutoloadSounds = true,

				// 自动加载背景图片
				AutoloadBackgrounds = true
			};

			// 以上这些了解一下就行了，每个mod都要有这个
		}
	}

}

