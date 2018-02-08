using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
	public partial class TicTacToe : Form
	{
		int currentPlayer = 1;

		//Player 1 = X, Player 2 = O

		public TicTacToe()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			
		}

		private void label2_Click(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (currentPlayer == 1)
			{
				button1.Text = "X";
				button1.Enabled = false;
				currentPlayer++;
			}
			else if (currentPlayer == 2)
			{
				button1.Text = "O";
				button1.Enabled = false;
				currentPlayer--;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (currentPlayer == 1)
			{
				button2.Text = "X";
				button2.Enabled = false;
				currentPlayer++;
			}
			else if (currentPlayer == 2)
			{
				button2.Text = "O";
				button2.Enabled = false;
				currentPlayer--;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (currentPlayer == 1)
			{
				button3.Text = "X";
				button3.Enabled = false;
				currentPlayer++;
			}
			else if (currentPlayer == 2)
			{
				button3.Text = "O";
				button3.Enabled = false;
				currentPlayer--;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			if (currentPlayer == 1)
			{
				button4.Text = "X";
				button4.Enabled = false;
				currentPlayer++;
			}
			else if (currentPlayer == 2)
			{
				button4.Text = "O";
				button4.Enabled = false;
				currentPlayer--;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			if (currentPlayer == 1)
			{
				button5.Text = "X";
				button5.Enabled = false;
				currentPlayer++;
			}
			else if (currentPlayer == 2)
			{
				button5.Text = "O";
				button5.Enabled = false;
				currentPlayer--;
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			if (currentPlayer == 1)
			{
				button6.Text = "X";
				button6.Enabled = false;
				currentPlayer++;
			}
			else if (currentPlayer == 2)
			{
				button6.Text = "O";
				button6.Enabled = false;
				currentPlayer--;
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			if (currentPlayer == 1)
			{
				button7.Text = "X";
				button7.Enabled = false;
				currentPlayer++;
			}
			else if (currentPlayer == 2)
			{
				button7.Text = "O";
				button7.Enabled = false;
				currentPlayer--;
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			if (currentPlayer == 1)
			{
				button8.Text = "X";
				button8.Enabled = false;
				currentPlayer++;
			}
			else if (currentPlayer == 2)
			{
				button8.Text = "O";
				button8.Enabled = false;
				currentPlayer--;
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			if (currentPlayer == 1)
			{
				button9.Text = "X";
				button9.Enabled = false;
				currentPlayer++;
			}
			else if (currentPlayer == 2)
			{
				button9.Text = "O";
				button9.Enabled = false;
				currentPlayer--;
			}
		}

	}
}
