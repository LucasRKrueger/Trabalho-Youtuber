using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Youtuber
    {
        private static int CodigoFinal; 
        private string Nome; //
        private string Sobrenome; //
        private string NomeCanal; //
        private string Apelido; //
        private int QuantidadeLikes;
        private long QuantidadeVisualizacoes;//
        private long QuantidadeInscritos;//
        private int QuantidadeVideos;//
        private double Renda;//
        private bool SeEhStreamer;//
        private bool PossuiPatrocinador;//
        private string Nacionalidade;//
        private string Categoria;//
        private string Plataforma;
        private string QuantidadeStrikes;
        private int Codigo;
        private string Link;
        private string Descricao;
        private List<string> youtuber = new List<string>();

        public Youtuber()
        {
            Codigo += CodigoFinal;
        }

        public int GetCodigo()
        {
            return Codigo;
        }

   
        public void SetNome(string nome)
        {
            if (nome.Trim().Count() < 3)
            {
                throw new Exception("Nome deve conter no mínimo 3 caracteres");
                
            }
            if (nome.Trim().Count() > 20)
            {
                throw new Exception("Nome deve conter no máximo 20");
                
            }
            Nome = nome;
        }
        public void SetSobrenome(string sobrenome)
        {
            if (sobrenome.Trim().Count() < 5)
            {
                throw new Exception("Sobrenome deve conter no mínimo 3 caracteres");
            }
            if (sobrenome.Trim().Count() > 100)
            {
                throw new Exception("Sobrenome deve conter no máximo 100");
            }
            Sobrenome = sobrenome;
        }
        public void SetApelido(string apelido)
        {
            if (apelido.Trim().Count() <3)
            {
                throw new Exception("Apelido deve conter no mínimo 3 caracteres");
            }
            if (apelido.Trim().Count() > 100)
            {
                throw new Exception("Apelido deve conter no máximo 30 caracteres");
            }
            Apelido = apelido;
        }
        public void SetNomeCanal(string nomeCanal)
        {
            if (nomeCanal.Trim().Count() < 3)
            {
                throw new Exception("Nome do canal deve conter no mínimo 2 caracteres");
            }
            if (nomeCanal.Trim().Count() > 100)
            {
                throw new Exception("Nome do canal deve conter no máximo 30 caracteres");
            }
            NomeCanal = nomeCanal;
        }
        public void SetQuantidadeVisualizacoes(long quantidadeVisualizacoes)
        {
            if (quantidadeVisualizacoes < 0)
            {
                throw new Exception("Quantidade de visualizações deve haver no mínimo \"0\" visualizações");
            }
            QuantidadeVisualizacoes = quantidadeVisualizacoes;
        }
        public void SetQuantidadeInscritos(long quantidadeInscritos)
        {
            if (quantidadeInscritos < 0)
            {
                throw new Exception("Quantidade de incritos deve haver no mínimo \"0\" inscritos");
            }
            QuantidadeInscritos = quantidadeInscritos;
        }
        public void SetQuantidadeLikes(int quantidadeLikes)
        {
            if (quantidadeLikes < 0)
            {
                throw new Exception("Quantidade de likes não pode ser negativos");
            }
            QuantidadeLikes = quantidadeLikes;
        }
        public void SetRenda(double renda)
        {
            if (renda < 0.0)
            {
                throw new Exception("Sua renda não pode ter um saldo negativo amigão");
            }
            Renda = renda;
           // if (!long.TryParse(renda, out ))
            {
                
            }
        }
        public void SetSeEhStreamer(bool streamer)
        {
            if ((!true) && (!false))
            {
                throw new Exception("Informe entre Sim ou Não");
                
            }
            SeEhStreamer = streamer;
        }
        public void SetPossuiPatrocinador(bool possuiPatrocinador)
        {
            if ((!true) && (!false))
            {
                throw new Exception("Informe entre Sim e Não");
            }
            PossuiPatrocinador = possuiPatrocinador;
        }
        public void SetQuantidadeStrikes(string quantidadeStrikes)
        {
            QuantidadeStrikes = quantidadeStrikes;
        }
        public void SetPlataforma(string plataforma)
        {
            if (plataforma == null)
            {
                throw new Exception("Escolha alguma Plataforma");
            }
            Plataforma = plataforma;
        }
        public void SetLink(string link)
        {
            if (link.Count() < 24)
            {
                throw new Exception("Informe um link válido chupingole");
            }
            Link = link;
        }
        public void SetCategoria(string categoria)
        {
            if (categoria.Trim().Count() == 0)
            {
                throw new Exception("Escolha uma categoria");
            }
            Categoria = categoria;
        }
        public void SetQuantidadeVideos(int quantidadeVideos)
        {
            if (quantidadeVideos < 0)
            {
                throw new Exception("Sua quantidade de vídeos não pode ser negativa né cara?");
                
            }
            QuantidadeVideos = quantidadeVideos;
        }
        public void SetNacionalidade(string nacionalidade)
        {
            if (nacionalidade == null)
            {
                throw new Exception("Seleciona uma nacionalidade colega");
            }
            Nacionalidade = nacionalidade;

        }
        public void SetDescricao(string descricao)
        {
            if (descricao.Trim().Count() < 10)
            {
                throw new Exception("Informe uma descricão com no mínimo 10 caracteres ou mais");   
            }
            else if (descricao.Trim().Count() >= 1000)
            {
                throw new Exception("Sua descrição é muito grande, informe uma descrição com menos de 1000 caracteres");
            }
            Descricao = descricao;
        }




        public string GetNome()
        {
            return Nome;
        }
        public string GetSobrenome()
        {
            return Sobrenome;
        }
        public string GetApelido()
        {
            return Apelido;
        }
        public string GetNomeCanal()
        {
            return NomeCanal;
        }
        public long GetQuantidadeVisualizacoes()
        {
            return QuantidadeVisualizacoes;
        }
        public long GetQuantidadeInscritos()
        {
            return QuantidadeInscritos;
        }
        public long GetQuantidadeLikes()
        {
            return QuantidadeLikes;
        }
        public double GetRenda()
        {
            return Renda;
        }
        public bool GetSeEhStreamer()
        {
            return SeEhStreamer;
        }
        public bool GetPossuiPatrocinador()
        {
            return PossuiPatrocinador;
        }
        public string GetQuantidadeStrikes()
        {
            return QuantidadeStrikes;
        }
        public string GetPlataforma()
        {
            return Plataforma;
        }
        public string GetLink()
        {
            return Link;
        }
        public int GetQuantidadeVideos()
        {
            return QuantidadeVideos;
        }
        public string GetNacionalidade()
        {
            return Nacionalidade;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public string GetCategoria()
        {
            return Categoria;
        }





















    }
}
