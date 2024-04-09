package app;

import java.awt.BorderLayout;
import java.awt.Canvas;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Frame;
import java.awt.Graphics;
import java.awt.Panel;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;
import java.awt.image.BufferedImage;
import java.io.File;
import java.io.IOException;

import javax.imageio.ImageIO;

import static util.Constant.*;

public class TestMain {
	Frame frame = new Frame();
	Panel lPanel = new Panel();
	Panel rPanel = new Panel();
	Panel p1 = new Panel();
	Panel p2 = new Panel();
	Panel p3 = new Panel();

	private final String DRAW_RAC = "rac";
	private final String DRAW_2048 = "2048";
	private final String DRAW_SCORE = "score";
	private final String DRAW_EDGE = "edge";

//	private String toDraw = "";
	private BufferedImage image;

	private class MyCanvas extends Canvas {
		private String toDraw = "";
		public void setPaint(String image) {
			toDraw = image;
		}
		
		@Override
		public void paint(Graphics g) {
			if (toDraw.equals(DRAW_RAC)) {
				try {
					image = ImageIO.read(new File("src//img//", "Rac.png"));
//					image = ImageIO.read(new File("src//img//", "mid.gif"));
				} catch (IOException e) {
					e.printStackTrace();
				}
				g.drawImage(image, 0, 0, null);
			} else if (toDraw.equals(DRAW_2048)) {
				try {
					image = ImageIO.read(new File("src//img//", "2048.png"));
				} catch (IOException e) {
					e.printStackTrace();
				}
				g.drawImage(image, 0, 0, null);
			} else if (toDraw.equals(DRAW_SCORE)) {
				try {
					image = ImageIO.read(new File("src//img//", "Score.png"));
				} catch (IOException e) {
					e.printStackTrace();
				}
				g.drawImage(image, 0, 0, null);
			} else if (toDraw.equals(DRAW_EDGE)) {
				try {
					image = ImageIO.read(new File("src//img//", "EdgeFrame.png"));
				} catch (IOException e) {
					e.printStackTrace();
				}
				g.drawImage(image, 0, 0, null);
			}
		}
	}

	MyCanvas drawRac = new MyCanvas();
	MyCanvas draw2048 = new MyCanvas();
	MyCanvas drawScore = new MyCanvas();
	MyCanvas drawEdge = new MyCanvas();

	private void init() {

		lPanel.setSize(LEFT_WIDTH, LEFT_HEIGHT);
		rPanel.setSize(RIGHT_WIDTH, RIGHT_HEIGHT);
		p1.setSize(RAC_WIDTH, RAC_HEIGHT);
		p2.setSize(_2048_WIDTH, _2048_HEIGHT);
		p3.setSize(SCORE_WIDTH, SCORE_HEIGHT);


		
//		toDraw = DRAW_RAC;
		drawRac.setPaint(DRAW_RAC);
		drawRac.repaint();
		drawRac.setPreferredSize(new Dimension(RAC_WIDTH, RAC_HEIGHT));

//		toDraw = DRAW_2048;
		draw2048.setPaint(DRAW_2048);
		draw2048.repaint();
		draw2048.setPreferredSize(new Dimension(_2048_WIDTH, _2048_HEIGHT));

//		toDraw = DRAW_SCORE;
		drawScore.setPaint(DRAW_SCORE);
		drawScore.repaint();
		drawScore.setPreferredSize(new Dimension(SCORE_WIDTH, SCORE_HEIGHT));

//		toDraw = DRAW_EDGE;
		drawEdge.setPaint(DRAW_EDGE);
		drawEdge.repaint();
		drawEdge.setPreferredSize(new Dimension(FRAME_WIDTH, FRAME_HEIGHT));
		
		p1.add(drawRac);
		p2.add(draw2048);
		p3.add(drawScore);

		lPanel.add(p1);
		rPanel.add(p2, BorderLayout.NORTH);
		rPanel.add(p3, BorderLayout.SOUTH);

		frame.setSize(FRAME_WIDTH, FRAME_HEIGHT);
		frame.add(lPanel, BorderLayout.WEST);
		frame.add(rPanel);
//		frame.add(drawEdge);

		frame.addWindowListener(new WindowAdapter() {
			@Override
			public void windowClosing(WindowEvent e) {
				System.exit(0);
			}
		});

		frame.setVisible(true);
	}

	public static void main(String[] args) {
		new TestMain().init();
	}

}
