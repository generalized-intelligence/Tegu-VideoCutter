![Tegu Logo](https://s2.ax1x.com/2019/01/30/kl6rzF.jpg)
# TIA-Python
## Tegu Video Cutter based on Qt
## Tegu视频切割工具（Qt版）用户手册

### 概述
Tegu 视频切割工具（Tegu Video Cutter）是Tegu Core 的一个配套工具，用于为计算机视觉方向的深度学习模型提供标注数据。该工具能以可视化的形式，帮助用户方便快捷地为将视频文件按照指定的时间间隔切割成一系列图片文件，供Tegu 其他工具使用。该工具目前已在 Windows 10 1803 x64 平台测试通过，理论上可以直接在Linux和macOS平台上运行（未经测试）。

本软件要求屏幕分辨率不小于 1024X768 。
---
Tegu Video Cutter is a tool working with Tegu Core, it's used to provide data for deep learning models on computer vision. It can help users to cut video files into a series of image files in a fixed time interval, to be used by other Tegu tool series. 

The Tegu Video Cutter has been tested on Windows 10 1803 x64 platform, and also provides support of the Linux and macOS platforms (not tested).

The Tegu Video Cutter requires that your screen resolution is not smaller than 1024 X 768
---


### 功能

* 选择单个视频文件，或选择整个文件夹中的所有视频文件
* 设置切割图片的时间间隔。
* 设置保存图片的方式（直接保存或者新建文件夹）

---
* Select single video file or all the files in a folder
* Set the time interval
* Set the way to save picture files(save directly or create a new folder)

---


### 使用说明
软件启动之后，主界面如图所示：

---
When the Tegu Video Cutter launches, the main window shows as follow:
//01 main


点击“选择文件”可以选择要切割的视频文件，支持`*.avi`和`*.mp4`格式。也可以点击“选择目录”选择一个文件夹，软件会递归地搜索文件夹中的所有视频文件。
---
Click "Select File" to select the video file to cut, which supports the `*.avi` and `*.mp4` format. You can also click "Select Folder" to select a folder, the software will search recursively for all the video files in the folder.

//02 open
右侧文本区域会显示当前已找到的视频文件。
---
The text space rightside will show the video files found.

//03 found

左侧界面可以选择切割图片的时间间隔，你可以选择每0.5s/1s/3s/5s切割一张图片。
---
In the left area, you can select the frequency of video cutting, choose 0.5s/1s/3s/5s per image to cut.

点击“选择保存路径”可以选择图片文件的保存位置。在下方您可以选择如何保存：
- 将所有图片文件直接保存在保存文件夹里。
- 为每一个视频文件单独建立一个以视频文件名命名的子文件夹，然后将该视频文件切割出的图片保存在子文件夹里。

---
Click "Select Save Path" to choose the path to save image files.You can choose how to save the image files:
- Save all the picture files in the save folder directly.
- Create a subfolder for every video file named as the video file name, and save the pictures in those subfolders.

点击“开始切割”可以开始切割，若要中途停止，可以点击“取消切割”。

---
Click "Start Cutting" to start, if you want to stop, click "Cancel Cutting".

//finished

生成文件如图所示：分别以两种保存方式保存。
---
The picture files generated are showed as follow picture, saved in two modes:
//save


