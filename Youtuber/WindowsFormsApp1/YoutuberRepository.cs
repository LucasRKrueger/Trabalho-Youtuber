using System;
using Model;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    class YoutuberRepository
    {
        
       List<Youtuber> youtubers = new List<Youtuber>();

        public YoutuberRepository()
        {
            if (File.Exists(Form1.ARQUIVO))
            {
                BinaryFormatter binaryReader = new BinaryFormatter();
                Stream stream = File.OpenRead(Form1.ARQUIVO);
                youtubers = ((YoutuberRepository)binaryReader.Deserialize(stream)).ObterYoutuber();
                stream.Close();
            }
        }

        public void AdicionarYoutuber(Youtuber youtuber)
        {
            youtubers.Add(youtuber);
            EscreverNoArquivoDosYoutubers();
        }

        private void EscreverNoArquivoDosYoutubers()
        {
            BinaryFormatter binaryWriter = new BinaryFormatter();
            Stream stream = new FileStream(Form1.ARQUIVO, FileMode.Create, FileAccess.Write);
            binaryWriter.Serialize(stream, this);
            stream.Close();
        }

        public List<Youtuber> ObterYoutuber()
        {
            return youtubers;
        }

        internal void ApagarYoutuber(string nome)
        {
            foreach (Youtuber youtuber in youtubers)
            {
                if (youtuber.GetNome() == nome)
                {
                    youtubers.Remove(youtuber);
                    EscreverNoArquivoDosYoutubers();
                    return;
                }
            }
        }

        internal void EditarYoutuber(Youtuber youtuber, int posicao)
        {
            youtubers[posicao] = youtuber;
            EscreverNoArquivoDosYoutubers();
        }

    }
}
