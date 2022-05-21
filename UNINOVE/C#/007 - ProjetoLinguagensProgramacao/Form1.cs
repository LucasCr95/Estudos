using System;
using System.Windows.Forms;

namespace _007___ProjetoLinguagensProgramacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboLinguagens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //          Limpar os itens do ComboBox
            cboLinguagens.Items.Clear();

            //         Adicionar os itens
            cboLinguagens.Items.Add("PHP");
            cboLinguagens.Items.Add("JavaScript");
            cboLinguagens.Items.Add("C#");
            cboLinguagens.Items.Add("Java");
            cboLinguagens.Items.Add("Python");
            cboLinguagens.Items.Add("Kotlin");
            cboLinguagens.Items.Add("C++");
            cboLinguagens.Items.Add("TypeScript");
            cboLinguagens.Items.Add("Ruby");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string strLinguagem = cboLinguagens.Text;

            switch (strLinguagem)
            {
                case "PHP":
                    pctLinguagens.Load("php.png");
                    MessageBox.Show("O PHP (um acrônimo recursivo para PHP: Hypertext Preprocessor ) é uma linguagem de script open source de uso geral, muito utilizada, e especialmente adequada para o desenvolvimento web e que pode ser embutida dentro do HTML.", "PHP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "JavaScript":
                    pctLinguagens.Load("javascript.png");
                    MessageBox.Show("JavaScript é uma linguagem de programação que permite a você implementar itens complexos em páginas web — toda vez que uma página da web faz mais do que simplesmente mostrar a você informação estática — mostrando conteúdo que se atualiza em um intervalo de tempo, mapas interativos ou gráficos 2D/3D animados, etc.", "JavaScript", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "C#":
                    pctLinguagens.Load("c#.png");
                    MessageBox.Show("C# (CSharp) é uma linguagem de programação orientada a objetos criada pela Microsoft, faz parte da sua plataforma . Net. A companhia baseou C# na linguagem C++ e Java. C# (CSharp) é uma linguagem de programação orientada a objetos criada pela Microsoft, faz parte da sua plataforma .", "C#", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Java":
                    pctLinguagens.Load("java.png");
                    MessageBox.Show("Java é uma linguagem de programação e plataforma computacional lançada pela primeira vez pela Sun Microsystems em 1995. Existem muitas aplicações e sites que não funcionarão, a menos que você tenha o Java instalado, e mais desses são criados todos os dias. O Java é rápido, seguro e confiável.", "Java", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Python":
                    pctLinguagens.Load("python.png");
                    MessageBox.Show("Python para que serve? Python é uma linguagem Open-Source de propósito geral usado bastante em data science, machine learning, desenvolvimento de web, desenvolvimento de aplicativos, automação de scripts, fintechs e mais.", "Python", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "Kotlin":
                    pctLinguagens.Load("kotlin.png");
                    MessageBox.Show("Kotlin é uma linguagem de programação de código aberto estática, compatível com programação orientada a objetos e funcional. O Kotlin fornece sintaxe e conceitos semelhantes de outras linguagens, incluindo C#, Java e Scala, entre muitos outros.", "Kotlin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "C++":
                    pctLinguagens.Load("c++.png");
                    MessageBox.Show("C++ é uma das linguagens mais versáteis que existem, permitindo desenvolver desde tarefas simples como aplicações na linha de comando ou web, até sistemas complexos de tempo real, muito usadas no mercado financeiro.", "C++", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case "TypeScript":
                    pctLinguagens.Load("typescript.png");
                    MessageBox.Show("Além de ajudar o ambiente de desenvolvimento, o TypeScript possibilita o uso de diferentes funcionalidades do superset que não estão inclusas na forma nativa e, também, a migração de linguagem gradativamente, refletindo no aumento da produtividade das equipes.", "TypeScript", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                default:
                    pctLinguagens.Load("ruby.png");
                    MessageBox.Show("Muitas aplicações famosas utilizam o Ruby, como os sites Airbnb e SoundCloud, a rede social Twitch e o site de streaming de séries e filmes Hulu. O Ruby pode ser muito útil, pois serve para criar diversos programas para desktop", "Ruby", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

            }

        }
    }
}
