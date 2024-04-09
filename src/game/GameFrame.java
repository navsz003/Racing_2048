package game;

import java.awt.*;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

import javax.imageio.ImageIO;

import static util.Constant.*;

/*
 *  游戏主窗口，显示所有内容
 */

public class GameFrame extends Frame {

	private int gameState; // 记录游戏状态

	private Panel leftPanel = new Panel();
	private Panel rightPanel = new Panel();

	private Panel racingPanel = new Panel();
	private Panel _2048Panel = new Panel();
	private Panel scorePanel = new Panel();

	// 绘图
	private static final String DRAW_RAC = "rac";
	private static final String DRAW_2048 = "2048";
	private static final String DRAW_SCORE = "score";
	private static final String DRAW_EDGE = "edge";
	private String toDraw = "";
	BufferedImage image;
	
	// 绘图部分
	private class MyCavas extends Canvas{
		@Override
		public void paint(Graphics g) {
			if (toDraw.equals(DRAW_RAC)) {
				try {
					image = ImageIO.read(new File("src//img//","RacingFrame.png"));
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				g.drawImage(image, 0, 0, null);
			}else if (toDraw.equals(DRAW_2048)) {
				try {
					image = ImageIO.read(new File("src//img//","_2048Frame.png"));
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				g.drawImage(image, 0, 0, null);
			}else if (toDraw.equals(DRAW_SCORE)) {
				try {
					image = ImageIO.read(new File("src//img//","ScoreFrame.png"));
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				g.drawImage(image, 0, 0, null);
			}else if (toDraw.equals(DRAW_EDGE)) {
				try {
					image = ImageIO.read(new File("src//img//","EdgeFrame.png"));
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				g.drawImage(image, 0, 0, null);
			}
		}
	}
	
	MyCavas drawRac = new MyCavas();
	MyCavas draw2048 = new MyCavas();
	MyCavas drawScore = new MyCavas();
	MyCavas drawEdge = new MyCavas();
	
	// 初始化
	public GameFrame() {
		// 每个方法不超过50行，超过就进行拆分
		initPanel();
		initFrame();
		initListener();
	}

	private void initFrame() {
		gameState = STATE_MENU;
		setTitle(GAME_TITLE);
		setBounds(50, 50, FRAME_WIDTH, FRAME_HEIGHT);
		setResizable(false);

		add(leftPanel, BorderLayout.WEST);
		add(rightPanel);

		setVisible(true);
	}

	private void initPanel() {

		toDraw = DRAW_RAC;
		drawRac.repaint();
//		drawRac.setPreferredSize(new Dimension(RAC_WIDTH, RAC_HEIGHT));
		toDraw = DRAW_2048;
		draw2048.repaint();
		toDraw = DRAW_SCORE;
		drawScore.repaint();
		toDraw = DRAW_EDGE;
		drawEdge.repaint();
		
		leftPanel.setSize(LEFT_WIDTH, LEFT_HEIGHT);
		rightPanel.setSize(RIGHT_WIDTH, RIGHT_HEIGHT);

//		racingPanel.setSize(RAC_WIDTH, RAC_HEIGHT);
//		_2048Panel.setSize(_2048_WIDTH, _2048_HEIGHT);
//		scorePanel.setSize(SCORE_WIDTH, SCORE_HEIGHT);

//		racingPanel.setBackground(Color.CYAN);
//		_2048Panel.setBackground(Color.GREEN);
//		scorePanel.setBackground(Color.ORANGE);

//		leftPanel.add(racingPanel);
//		rightPanel.add(_2048Panel, BorderLayout.NORTH);
//		rightPanel.add(scorePanel);
		leftPanel.add(drawRac);
		rightPanel.add(draw2048, BorderLayout.NORTH);
		rightPanel.add(drawScore);
//		add(drawEdge);
	}

	private void initListener() {
		addWindowListener(new WindowAdapter() {
			@Override
			public void windowClosing(WindowEvent e) {
				System.exit(0); // 结束虚拟机
			}
		});
	}

	
	
//	@Override
//	public void update(Graphics g) {
//		switch (gameState) {
//		case STATE_MENU:
//			drawMenu();
//			break;
//		case STATE_RUN:
//			drawRun();
//			break;
//		case STATE_OVER:
//			drawOver();
//			break;
//
//		}
//	}

	private void drawMenu() {

	}

	private void drawRun() {

	}

	private void drawOver() {

	}

}
