*<s>使用前先大喊 niconiconi! poi! duang!以减少bug发生率</s>*  

[![Build Status](https://dev.azure.com/kagamiastudio/WzComparerR2/_apis/build/status/Kagamia.WzComparerR2?branchName=master)](https://dev.azure.com/kagamiastudio/WzComparerR2/_build/latest?definitionId=4&branchName=master)

# Maintenance Status

⚠️ The WzComparerR2 project is now in deep maintenance status. This means that only critical bugs or wz file format breaking changes are being considered for inclusion by owner. Expect slow replies to issues.

# WzComparerR2
这是一个用C# latest/.Net4.62+.Net8组装的冒险岛提取器...  
包含了一些奇怪的机能比如stringWZ搜索 客户端对比 装备模拟 地图模拟等等..  

tips: WcR2将尽力维持每周更新，Releases里**不会**提供最稳定版下载，最新版会通过azure-pipeline自动发布。  
links: [\[更新日志\]](https://github.com/Kagamia/WzComparerR2/tree/master/UpdateLogs)  [\[版本计划\]](https://github.com/Kagamia/WzComparerR2/wiki/Roadmap)  [\[最新版下载\]](https://github.com/Kagamia/WzComparerR2/releases/tag/ci-build)

# Modules
- **WzComparerR2** 主程序
- **WzComparerR2.Common** 一些通用类
- **WzComparerR2.PluginBase** 插件管理器
- **WzComparerR2.WzLib** wz文件读取相关
- **CharaSimResource** 用于装备模拟的资源文件
- **WzComparerR2.LuaConsole** (可选插件)Lua控制台
- **WzComparerR2.MapRender** (可选插件)地图仿真器
- **WzComparerR2.Avatar** (可选插件)纸娃娃
- **WzComparerR2.Network** (可选插件)在线聊天室

# Prerequisite
- **2.x**: Win7sp1+/.net4.6.2+/dx11.0
- **1.x**: WinXp+/.net2.0+/dx9.0

# Installation
```sh
git clone --recurse-submodules -j8 git://github.com/Kagamia/WzComparerR2.git
```
Clone repository with submodules.

# Compile
- vs2022 or higher/.net 8 SDK

# Credits and Acknowledgement
- **Fiel** ([Southperry](http://www.southperry.net))  wz文件读取代码改造自WzExtract 以及WzPatcher
- **Index** ([Exrpg](http://bbs.exrpg.com/space-uid-137285.html)) MapRender的原始代码 以及libgif
- **Deneo** For .ms file format and video format
- [DotNetBar](http://www.devcomponents.com/)
- [SharpDX](https://github.com/sharpdx/SharpDX) & [Monogame](https://github.com/MonoGame/MonoGame)
- [BassLibrary](http://www.un4seen.com/)
- [IMEHelper](https://github.com/JLChnToZ/IMEHelper)
- [Spine-Runtime](https://github.com/EsotericSoftware/spine-runtimes)
- [EmptyKeysUI](https://github.com/EmptyKeys)
- [libvpx](https://www.webmproject.org/code/) & [libyuv](https://chromium.googlesource.com/libyuv/libyuv/) for video decoding
- [VC-LTL5](https://github.com/Chuyu-Team/VC-LTL5) for native library build
- All testers from CMST tester group.
