package util;

// 管理常量
public class Constant {
	
	/************************** Frame ***************************/
	
	// 窗口标题
	public static final String GAME_TITLE = "Racing 2048";
	public static final int TITLE_HEIGHT = 40; // 标题栏高度
	
	// 窗口长宽
	public static final int FRAME_WIDTH = 1000;
	public static final int FRAME_HEIGHT = 600 + TITLE_HEIGHT;
	
	/************************** Panel ***************************/
	// 左面板 （只包含赛车游戏）
	public static final int LEFT_WIDTH = 800;
	public static final int LEFT_HEIGHT = 600;
	// 右面板 （包含2048和分数面板）
	public static final int RIGHT_WIDTH = 200;
	public static final int RIGHT_HEIGHT = 600;
	
	// 赛车游戏
	public static final int RAC_WIDTH = 800;
	public static final int RAC_HEIGHT = 600;
	// 2048
	public static final int _2048_WIDTH = 170;
	public static final int _2048_HEIGHT = 170;
	// 分数面版
	public static final int SCORE_WIDTH = 170;
	public static final int SCORE_HEIGHT = 385;
	
	
	/*************************** Menu ***************************/
	
	public static final int STATE_MENU = 0;
	public static final int STATE_RUN = 1;
	public static final int STATE_OVER = 2;
	
	public static final String[] MENUS = {
			"Start",
			"Exit"
	};
	
	
	/*************************** 2048 ***************************/

	public static final byte CHESSBOARD_LENGTH = 4;
	
	
	/************************** Racing **************************/

	
}
