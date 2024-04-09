package game;

import static util.Constant.*;

import java.awt.image.BufferedImage;

public class Racing {
	
	private static int speed = 60;							// 车辆速度 初始为 60km/s
	public static final int topSpeed = 295;					// 车辆极速
//	private static short gear = 0;							// 挡位 0为空挡 最高5挡
	private static final int nitroTopSpeed = 320;			// 氮气能达到的极速
	private static short lane = 2;							// 车道从0~3共4道 默认在3车道

	private static int nitro = 0;							// 氮气量
	private static final int maxNitro = 5;					// 氮气量最大为5
	private static int shell = 0;							// 护盾量
	private static final int maxShell = 5;					// 护盾量最大为5

	private static int distance = 0;						// 记录车辆行驶的距离
	private static int timer = 60;							// 游戏倒计时
	private static final int maxTimer = 90;					// 游戏最大时长
	
	BufferedImage image;

	/************************** 基本行为 **************************/
	
	private static void shiftLeft() {
		if (lane < 0)
			return;
		lane--;
		return;
	}

	private static void shiftRight() {
		if (lane > 3)
			return;
		lane++;
		return;
	}

	private static void accelerate() {
		if (speed == topSpeed || speed + 4 >= topSpeed)		// 限速
			speed = topSpeed;
		else
			speed += 4;
		return;
	}

	private static void decelerate() {
		if (speed <= 0 || speed - 1 <= 0)
			speed = 0;
		else
			speed -= 1;
		return;
	}
	
	private static void tickTock() {						// 游戏倒计时
		if (timer >= 0)
			timer--;
		else 
			GameOver();
	}
	
	private static void GameOver() {
		// TODO 跳转到结算画面
		
	}
	

	/**************************** 道具 ****************************/
	
	private static void nitro() {							// 激活氮气
		if (nitro >= 1)										// 判断氮气是否足够
			nitro--;
		else
			return;											// 若氮气不足，则不触发氮气

		if (speed < nitroTopSpeed)
			speed += 10;
		else if (speed == nitroTopSpeed || speed + 10 >= nitroTopSpeed)	// 限速
			speed = nitroTopSpeed;
		else
			;
		return;
	}

	private static void nitro(int increment) {				// 收集氮气
		if (nitro >= maxNitro || nitro + increment >= maxNitro)
			nitro = maxNitro;
		else
			nitro += increment;
		return;
	}

	private static void shell() {							// 激活护盾
		if (shell >= 1)
			shell--;
		else
			return;
		// TODO 护盾效果

	}

	private static void shell(int increment) {				// 收集护盾
		if (shell >= maxShell || nitro + increment >= maxShell)
			shell=maxShell;
		else
			shell+=increment;
		return;
	}
	
	private static void Extendedtime(int increment) {		// 延长时间
		if (timer >= maxTimer || timer + increment >= maxTimer)
			timer = maxTimer;
		else
			timer += increment;
		return;
	}

	/**************************** 互动 ****************************/
	
	private static void crash() {

	}

}
