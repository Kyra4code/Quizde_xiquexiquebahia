using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Quiz
{
	public partial class MainForm : Form
	{
		public MainForm() //método construtor
		{
			InitializeComponent();
		}
		//Variaves globais 
		string respostacerta = "X";
		int pontos = 0;
		string nomeImagem = "interrogação.png";
		
		// alternativas
		void ButtonAClick(object sender, EventArgs e)
		{
			if (respostacerta == "A")
			{
				pictureBox1.Load();
				MessageBox.Show("Parabéns, você acertou!!!");
				pontos++;
				labelPontos.Text = "Pontos: " + pontos;
			}
			else
			{
				MessageBox.Show("Você errou!!!");
			}
			panel1.Enabled = false;
		}
		void ButtonBClick(object sender, EventArgs e)
		{
			if (respostacerta == "B")
			{
				pictureBox1.Load();
				MessageBox.Show("Parabéns, você acertou!!!");
				pontos++;
				labelPontos.Text = "Pontos: " + pontos;
			}
			else
			{
				MessageBox.Show("Você errou!!!");
			}
			panel1.Enabled = false;
		}
		void ButtonCClick(object sender, EventArgs e)
		{
			if (respostacerta == "C")
			{
				pictureBox1.Load();
				MessageBox.Show("Parabéns, você acertou!!!");
				pontos++;
				labelPontos.Text = "Pontos: " + pontos;
			}
			else
			{
				MessageBox.Show("Você errou!!!");
			}
			panel1.Enabled = false;
		}
		void ButtonDClick(object sender, EventArgs e)
		{
			if (respostacerta == "D")
			{
				pictureBox1.Load();
				MessageBox.Show("Parabéns, você acertou!!!");
				pontos++;
				labelPontos.Text = "Pontos: " + pontos;
			}
			else
			{
				MessageBox.Show("Você errou!!!");
			}
			panel1.Enabled = false;
		}
		void Button1Click(object sender, EventArgs e)
		{
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "Qual a capital de Xique -Xique,BA?";
			labelA.Text = "Panamá";
			labelB.Text = "tocantins";
			labelC.Text = "Zamaica";
			labelD.Text = "Bolso do Zimbabuei";
			respostacerta = "D";
			nomeImagem = "bolsodozimbabwei.jpg";
			
			panel1.Enabled = true;
			
			button1.Enabled = false;
			button2.Enabled = true;
			
		}
		void ButtomReiniciarClick(object sender, EventArgs e)
		{
			Application.Restart();
		}
	}
}
