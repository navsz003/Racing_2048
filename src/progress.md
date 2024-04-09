Day 1
==
初始化窗口，以及开始搭建 Racing.java 的基本结构

创建的类
--
|包名|类名|功能|
|:-:|:-:|:-:|
|app|Main|包含main方法|
|game|Game_2048|包含2048游戏相关的代码|
|game|GameFrame|游戏主窗口，显示所有内容|
|game|Racing|包含Racing游戏相关的代码|
|util|Constant|存放代码中的常量|

创建的变量/常量
--
|变量名|类型/性质|含义|
|:-:|:-:|:-:|
|GAME_TITLE|final String|窗口标题|
|FRAME_WIDTH|final int|窗口宽度|
|FRAME_HEIGHT|final int|窗口高度|
|STATE_MENU|final int|开始菜单的状态值|
|STATE_RUN|final int|游戏运行的状态值|
|STATE_OVER|final int|游戏结束的状态值|
|CHESSBOARD_LENGTH|final byte|2048棋盘的长|
|speed|int|车辆速度|
|gear|short|车辆挡位（被注释）|
|topSpeed|final int|车辆极速|
|nitroTopSpeed|final int|氮气能达到的极速|
|land|short|当前车辆所在的车道|
|nitro|int|氮气量|
|maxNitro|final int|氮气最大量|
|shell|int|护盾量|
|maxShell|final int|护盾最大量|
|distance|int|车辆行驶的距离|
|timer|int|游戏倒计时|
|maxTimer|final int|游戏最大时长|

创建的方法
--
|方法名|传入值|功能|
|:-:|:-:|:-:|
|shiftLeft||车辆左移|
|shiftRight||车辆右移|
|accelerate||车辆加速|
|decelerate||车辆减速|
|tickTock||游戏倒计时|
|GameOver||游戏结束，跳转到结算画面|
|nitro||激活氮气|
|nitro|int increment|收集氮气|
|shell||激活护盾|
|shell|int increment|收集护盾|
|crash||车辆碰撞|


实现的功能
--
1. 初始化窗口 实现了窗口关闭，固定窗口大小
1. 实现了 shiftLeft(), shiftRight(), accelerate(), decelerate(), nitro() , nitro(int increment), shell(), shell(int increment) 的部分功能

Day 2
==




















