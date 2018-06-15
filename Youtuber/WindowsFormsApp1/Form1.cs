using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        public int posicao = -1;
        public static string ARQUIVO = "youtubers.bin";
        private int codigo;
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(int codigo)
        {
            this.codigo = codigo;
            for (int i = 0; i < Program.youtubers.Count(); i++)
			{
			 Youtuber youtuber = Program.youtubers[i];
             if (youtuber.GetCodigo() == codigo)
	          {
	          	 txtNome.Text = youtuber.GetNome();
                 txtSobrenome.Text = youtuber.GetSobrenome();
                 txtNomeDoCanal.Text = youtuber.GetNomeCanal();
                 txtQuantidadeDeVisualizacoes.Text = Convert.ToString(youtuber.GetQuantidadeVisualizacoes());
                 txtApelido.Text = youtuber.GetApelido();                                  
	          }             
			}             
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/");
        }

        Youtuber youtubers = new Youtuber()
        {
            
        };

        private void circularButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleciona algo no grid véi");
                return;

            }

            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            YoutuberRepository youtuberRepository = new YoutuberRepository();
            int quantidade = 0;
            foreach (Youtuber youtuber in youtuberRepository.ObterYoutuber())
            {
                if (youtuber.GetNome() == nome)
                {
                    txtNome.Text = youtuber.GetNome();
                    txtApelido.Text = youtuber.GetApelido();
                    txtSobrenome.Text = youtuber.GetSobrenome();
                    txtNomeDoCanal.Text = youtuber.GetNomeCanal();
                    txtQuantidadeDeLikes.Text = Convert.ToString(youtuber.GetQuantidadeLikes());
                    txtQuantidadeDeVideos.Text = Convert.ToString(youtuber.GetQuantidadeVideos());
                    txtQuantidadeDeInscritos.Text = Convert.ToString(youtuber.GetQuantidadeInscritos());
                    txtRenda.Text = Convert.ToString(youtuber.GetRenda());
                    txtDescricao.Text = youtuber.GetDescricao();
                    cbCategoria.SelectedItem = youtuber.GetCategoria();
                    cbNacionalidade.SelectedItem = youtuber.GetNacionalidade();
                    cbPlataforma.SelectedItem = youtuber.GetPlataforma();
                    cbQuantidadeDeStrikes.SelectedItem = youtuber.GetQuantidadeStrikes();
                    rbSimStreamer.Checked = youtuber.GetSeEhStreamer();
                    rbNaoStreamer.Checked = youtuber.GetSeEhStreamer();
                    rbNaoPossuiPatrocinador.Checked = youtuber.GetPossuiPatrocinador();
                    rbSimPossuiPatrocinador.Checked = youtuber.GetPossuiPatrocinador();
                    posicao = quantidade;
                    return;
                }
                quantidade++;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && (e.KeyCode == Keys.S))
            {
                Salvar();
            }
        }

        private void Salvar()
        {
            Youtuber youtuber = new Youtuber();
            try
            {            
                youtuber.SetNome(txtNome.Text);
                youtuber.SetSobrenome(txtSobrenome.Text);
                youtuber.SetApelido(txtApelido.Text);
                youtuber.SetNomeCanal(txtNomeDoCanal.Text);
                youtuber.SetQuantidadeInscritos(Convert.ToInt64(txtQuantidadeDeInscritos.Text));
                youtuber.SetQuantidadeLikes(Convert.ToInt32(txtQuantidadeDeLikes.Text));
                youtuber.SetRenda(Convert.ToDouble(txtRenda.Text));
                youtuber.SetQuantidadeVisualizacoes(Convert.ToInt64(txtQuantidadeDeVisualizacoes.Text));
                youtuber.SetQuantidadeVideos(Convert.ToInt32(txtQuantidadeDeVideos.Text));
                youtuber.SetNacionalidade(cbNacionalidade.SelectedItem.ToString());
                youtuber.SetPlataforma(cbPlataforma.SelectedItem.ToString());
                youtuber.SetCategoria(cbCategoria.SelectedItem.ToString());
                youtuber.SetQuantidadeStrikes(cbQuantidadeDeStrikes.SelectedItem.ToString());
                youtuber.SetLink(textBox2.Text);
                youtuber.SetPossuiPatrocinador(rbSimPossuiPatrocinador.Checked);
                youtuber.SetSeEhStreamer(rbSimStreamer.Checked);            
                youtuber.SetPossuiPatrocinador(rbSimPossuiPatrocinador.Checked); 
                youtuber.SetDescricao(txtDescricao.Text);

                YoutuberRepository tudo = new YoutuberRepository();
                if (posicao == -1)
                {
                    
                    tudo.AdicionarYoutuber(youtuber);
                    MessageBox.Show("Youtuber cadastrado com sucesso");
                    LimparCampos();
                }
                else
                {
                    tudo.EditarYoutuber(youtuber, posicao);
                    MessageBox.Show("Youtuber editado com sucesso");
                }
                AtualizarLista();       

            }
            catch (Exception el)
            {
                MessageBox.Show(el.Message);
                return;                
            }
            LimparCampos();

                   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Salvar();
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            YoutuberRepository tudo = new YoutuberRepository();
            dataGridView1.Rows.Clear();
            foreach (Youtuber youtuber in tudo.ObterYoutuber())
            {
                dataGridView1.Rows.Add(new Object[]
                {
                    youtuber.GetNome(),
                    youtuber.GetNomeCanal(),
                    youtuber.GetQuantidadeStrikes(),
                    youtuber.GetRenda(),
                    youtuber.GetQuantidadeInscritos()
                });
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtDescricao.Text = "";
            txtApelido.Text = "";
            txtSobrenome.Text = "";
            txtNomeDoCanal.Text = "";
            txtQuantidadeDeInscritos.Text = "";
            txtQuantidadeDeLikes.Text = "";
            txtQuantidadeDeVideos.Text = "";
            txtRenda.Text = "";
            cbCategoria.SelectedIndex = -1;
            cbNacionalidade.SelectedIndex = -1;
            cbPlataforma.SelectedIndex = -1;
            cbQuantidadeDeStrikes.SelectedIndex = -1;
            posicao = -1;
            rbSimPossuiPatrocinador.Checked = true;
            rbSimStreamer.Checked = true;
            textBox2.Text = "";
        }

        private void circularButton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Não trola Francisco, seleciona algo pra excluir");
                return;
            }

            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            YoutuberRepository youtuberRepository = new YoutuberRepository();
            youtuberRepository.ApagarYoutuber(nome);
            MessageBox.Show(nome + " apagado com sucesso");
            LimparCampos();
        }

        private void EditarYoutuber()
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Meu deus Francisco sai dessa hortelã");
                return;
            }
            string nome = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
            YoutuberRepository youtuberRepository = new YoutuberRepository();
            int quantidade = 0;
            foreach (Youtuber youtuber in youtuberRepository.ObterYoutuber())
            {
                if (youtuber.GetNome() == nome)
                {
                    txtNome.Text = youtuber.GetNome();
                    textBox2.Text = youtuber.GetLink();
                    txtApelido.Text = youtuber.GetApelido();
                    txtSobrenome.Text = youtuber.GetSobrenome();
                    txtNomeDoCanal.Text = youtuber.GetNomeCanal();
                    txtQuantidadeDeLikes.Text = Convert.ToString(youtuber.GetQuantidadeLikes());
                    txtQuantidadeDeVideos.Text = Convert.ToString(youtuber.GetQuantidadeVideos());
                    txtQuantidadeDeInscritos.Text = Convert.ToString(youtuber.GetQuantidadeInscritos());
                    txtRenda.Text = Convert.ToString(youtuber.GetRenda());
                    txtDescricao.Text = youtuber.GetDescricao();
                    cbCategoria.SelectedItem = youtuber.GetCategoria();
                    cbNacionalidade.SelectedItem = youtuber.GetNacionalidade();
                    cbPlataforma.SelectedItem = youtuber.GetPlataforma();
                    cbQuantidadeDeStrikes.SelectedItem = youtuber.GetQuantidadeStrikes();
                    rbSimStreamer.Checked = youtuber.GetSeEhStreamer();
                    rbNaoStreamer.Checked = youtuber.GetSeEhStreamer();
                    rbNaoPossuiPatrocinador.Checked = youtuber.GetPossuiPatrocinador();
                    rbSimPossuiPatrocinador.Checked = youtuber.GetPossuiPatrocinador();
                    posicao = quantidade;
                    return;
                }
            }
 
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            AtualizarLista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }
    }
}
