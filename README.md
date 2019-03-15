![Tegu Logo](https://s2.ax1x.com/2019/01/30/kl6rzF.jpg)
## Tegu 视频切割工具(Tegu Video Cutter)

Tegu 视频切割工具（Tegu Video Cutter）是Tegu Core 的一个配套工具，用于为计算机视觉方向的深度学习模型提供标注数据。该工具能以可视化的形式，帮助用户方便快捷地为将视频文件按照指定的时间间隔切割成一系列图片文件，供Tegu 其他工具使用。该工具使用 C# + WinForm 开发，支持 .Net Framework 4.6.1，目前在中文版 Windows 10 1803 x64 平台下测试通过。
---
Tegu Video Cutter is a tool working with Tegu Core, it's used to provide data for deep learning models on computer vision. It can help users to cut video files into a series of image files in a fixed time interval, to be used by other Tegu tool series. The Tegu Video Cutter is developed by C# + WinForm, provides support of .Net Framework 4.6.1, tested in Simplified Chinese version of Windows 10 1803 x64 platform. 

## 快速开始(Fast Start)
本项目提供了解决方案文件，安装 Visual Studio 2017 即可打开并运行。项目依赖于[OpenCVSharp](https://github.com/shimat/opencvsharp)，需要使用Nuget安装。

您也可以直接使用已经编译好的版本：
[release](https://github.com/generalized-intelligence/Tegu-VideoCutter/releases)
---
We have provided a solution file for you to open with Visual Studio 2017. The project depends on [OpenCVSharp](https://github.com/shimat/opencvsharp), which should be installed with Nuget.

You can also use the built executable version:
[release](https://github.com/generalized-intelligence/Tegu-VideoCutter/releases)

## 现有功能(Functions available)

* 选择单个视频文件，或选择整个文件夹中的所有视频文件
* 设置切割图片的时间间隔。
* 设置保存图片的方式（直接保存或者新建文件夹）。
---
* Select single video file or all the files in a folder
* Set the time interval
* Set the way to save picture files(save directly or create a new folder)


## 用户手册(User Manual)

参见 [用户手册](http://www.giai.tech)
---
See [USER MANUAL](http://www.giai.tech)

## 开发者文档(Developer Document)

参见 [开发者文档](http://www.giai.tech)
---
See [DEVELOPER DOCUMENT](http://www.giai.tech)
## TODO

* 解决在英文系统上的文字编码问题
* 尝试跨平台
---
* Resolve the encoding issue on English system
* Cross-platform
# Meta

泛化智能 Generalized Intelligence 出品。
本项目通过 BSD 3 协议发布及传播。详情见 LICENSE。
---
Project initialized by Generalized Intelligence Distributed under the BSD 3-Clause license. See LICENSE for more information.

# Contribute

请参阅 CONTRIBUTING.md
---
Please follow CONTRIBUTING.md