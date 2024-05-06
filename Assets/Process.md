基本信息
==
赛车游戏画幅：160X120

文件命名规则
==
|名称|含义|
|--|--|
|Contach|康塔什，即玩家驾驶的赛车名称|
|Control|C#控制脚本，如ContachControl|
|Controller|动画控制器，如ContachController|
|l2m|Left to Mid 从左车道变到中车道，m2l 从中车道到左车道|
|r2m|Right to Mid 从右车道变道中车道，m2r 从中车道到右车道|


5/6
==
1. 创建项目
2. 导入了赛车素材
3. 创建了赛车，道路，地面的动画
4. 赛车绑定了脚本“ContachControl.cs”

问题
--
1. 道路动画的切换，需要添加过渡动画
2. 赛车的控制有时会卡住