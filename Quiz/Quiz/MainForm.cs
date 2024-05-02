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
		string nomeImagem = "transferir.jpg";
		
		// alternativas
		void ButtonAClick(object sender, EventArgs e)
		{
			if (respostacerta == "A")
			{
				pictureBox1.Load(nomeImagem);
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
				pictureBox1.Load(nomeImagem);
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
				pictureBox1.Load(nomeImagem);
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
				pictureBox1.Load(nomeImagem);
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
		void Button2Click(object sender, EventArgs e)
		{
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "Oque se coloca na box?????";
			labelA.Text = "Pirâmide na box";
			labelB.Text = "Cone na box";
			labelC.Text = "Escada na box";
			labelD.Text = "Duzeeeentus";
			respostacerta = "A";
			nomeImagem = "piramidenabox.jpg";
			
			panel1.Enabled = true;
			
			button2.Enabled = false;
			button3.Enabled = true;
			
		}
		void Button3Click(object sender, EventArgs e)
		{
			pictureBox1.Load("transferir.jpg");
			labelPergunta.Text = "testeeeeeeeeeeeeeeeeeeeeeeeeee\neeeeeeeeeeeeeee";
			labelA.Text = "day you cool";
			labelB.Text = "kozei";
			labelC.Text = "migo_zei";
			labelD.Text = "zeca_palgordinho";
			respostacerta = "C";
			nomeImagem = "piramidenabox.jpg";
			
			panel1.Enabled = true;
			
			button2.Enabled = false;
			button3.Enabled = true;
		}
	}
}
