package game;

/*
 * 为了方便计算，每个格子内的值为2的指数 (1=2, 2=4, 3=8, 4=16, ...)
 * 格子中的值为0时代表是空格子 (新数字应当在空格子中产生)
 */

import static util.Constant.*;

import java.awt.Frame;

public class Game_2048 extends Frame{

	public int[][] chessboard = new int[CHESSBOARD_LENGTH][CHESSBOARD_LENGTH]; // 值为0代表空

	// 构造器
	public Game_2048() {
		initChessboard(chessboard);
		runGame(chessboard);
	}

	private static void initChessboard(int[][] chessboard) {
		for (int i = 0; i < CHESSBOARD_LENGTH; i++)
			for (int j = 0; j < CHESSBOARD_LENGTH; j++)
				chessboard[i][j] = 0;
	}


	// 游戏在这里运行
	private static void runGame(int[][] chessboard) {
		while (true) {
			
		}
	}

	// 绘制棋盘
	private static void showChessboard(int[][] chessboard) {
		for (int i = 0; i < CHESSBOARD_LENGTH; i++)
			for (int j = 0; j < CHESSBOARD_LENGTH; j++)
				System.out.println(i + "," + j + ": " + chessboard[i][j]);
	}

	
	// TODO
	private static void randomGenerate() {

	}

	// TODO
	private static void shiftRight() {

	}

	// TODO
	private static void shiftLeft() {

	}

	// TODO
	private static void shiftUp() {

	}

	// TODO
	private static void shiftDown() {

	}

}
