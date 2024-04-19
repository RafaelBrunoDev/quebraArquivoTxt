using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quebraArquivoTxt
{
    public partial class Form1 : Form
    {
        private string diretorioDestino;
        private List<string> caminhosArquivosQuebrados = new List<string>();
        private string caminhoDestinoUnificado = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtSelecionar.Text = openFileDialog.FileName;
                }
            }
        }

        private void txtQuebrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSelecionar.Text))
            {
                MessageBox.Show("Selecione um arquivo antes de quebrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int palavrasPorArquivo = 150;
            string caminhoArquivoOriginal = txtSelecionar.Text;

            string todoTexto = File.ReadAllText(caminhoArquivoOriginal);

            string[] blocos = todoTexto.Split(new string[] { Environment.NewLine + Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            int totalBlocos = blocos.Length;

            int indiceInicial = 0;
            int palavrasAcumuladas = 0;
            int numeroArquivo = 1;

            while (indiceInicial < totalBlocos)
            {
                int blocosNesteArquivo = 0;

                while (indiceInicial + blocosNesteArquivo < totalBlocos &&
                       palavrasAcumuladas + blocos[indiceInicial + blocosNesteArquivo].Split().Length <= palavrasPorArquivo)
                {
                    palavrasAcumuladas += blocos[indiceInicial + blocosNesteArquivo].Split().Length;
                    blocosNesteArquivo++;
                }

                string nomeOriginal = Path.GetFileNameWithoutExtension(caminhoArquivoOriginal);
                string nomeNovoArquivo = Path.Combine(diretorioDestino, $"{nomeOriginal}_parte_{numeroArquivo}.txt");


                numeroArquivo++;

                string[] blocosParaEsteArquivo = blocos.Skip(indiceInicial).Take(blocosNesteArquivo).ToArray();

                File.WriteAllText(nomeNovoArquivo, string.Join(Environment.NewLine + Environment.NewLine, blocosParaEsteArquivo));

                indiceInicial += blocosNesteArquivo;
                palavrasAcumuladas = 0;
            }

            MessageBox.Show("Arquivo quebrado com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnDestino_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestino.Text = folderBrowserDialog.SelectedPath;
                    diretorioDestino = folderBrowserDialog.SelectedPath;
                }
            }
        }

        private void btnSelecionarArquivosUnificar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhosArquivosQuebrados = new List<string>(openFileDialog.FileNames);
                    txtCaminhosArquivosQuebrados.Text = string.Join(Environment.NewLine, caminhosArquivosQuebrados);
                }
            }
        }

        private void btnSelecionarDestinoUnificado_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    caminhoDestinoUnificado = folderBrowserDialog.SelectedPath;
                    txtCaminhoDestinoUnificado.Text = caminhoDestinoUnificado;
                }
            }
        }

        private void btnUnificarTxt_Click(object sender, EventArgs e)
        {
            if (caminhosArquivosQuebrados.Count == 0 || string.IsNullOrEmpty(caminhoDestinoUnificado))
            {
                MessageBox.Show("Selecione os arquivos para unificar e um local para salvar o arquivo unificado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder textoUnificado = new StringBuilder();
            foreach (string arquivo in caminhosArquivosQuebrados)
            {
                if (textoUnificado.Length > 0)
                {
                    textoUnificado.AppendLine();
                }

                textoUnificado.AppendLine(File.ReadAllText(arquivo));
            }

            string nomeOriginalSemExtensao = Path.GetFileNameWithoutExtension(txtSelecionar.Text);

            string nomeArquivoFinal = $"{nomeOriginalSemExtensao}_arquivo_final.txt";

            File.WriteAllText(Path.Combine(caminhoDestinoUnificado, nomeArquivoFinal), textoUnificado.ToString());


            MessageBox.Show("Arquivos unificados com sucesso!", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





    }
}
