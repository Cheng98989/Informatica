using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hu
{
    public static class MyLib
    {
        public struct Tempo
        {
            public int minuti;
            public int secondi;
            public int millisecondi;
        }
        public struct Rilevamento
        {
            public int id;
            public string pilota;
            public string team;
            public int velocitaMax;
            public string mescola;
            public Tempo tempoGiro;
        }

        public static int FindRilevamentoIndexById(int id, Rilevamento[] r, int counter)
        {
            int x = 0;
            while(x < counter)
            {
                if (r[x].id == id)
                    return x;
                x++;
            }
            return -1;
        }

        public static string RilevamentoToString(Rilevamento r)
        {
            return $"ID: {r.id}, PILOTA: {r.pilota}, TEAM: {r.team}, VELOCITA MAX: {r.velocitaMax} km/h, MESCOLA: {r.mescola}, TEMPO: ({TempoToString(r.tempoGiro)})";
        }
        public static string TempoToString(Tempo t)
        {
            return $"{t.minuti}min:{t.secondi}sec:{t.millisecondi}mmsec";
        }
        public static void Elimina(int index, Rilevamento[] r, ref int counter)
        {
            counter--;
            r[index] = r[counter];
        }

        public static int IndexMaxVelMaxInRilevamento(Rilevamento[] r, int counter)
        {
            if (counter == 0)
                return -1;
            int index = 0;
            int actMax = r[0].velocitaMax;
            int x = default;
            while(x < counter)
            {
                if(actMax < r[x].velocitaMax)
                {
                    index = x;
                    actMax = r[x].velocitaMax;
                }
                x++;
            }
            return index;
        }
        public static bool RilevamentiStreamWriter(string fileAddress, Rilevamento[] r, int counter)
        {
            try
            {
                StreamWriter file = new StreamWriter(fileAddress);
                int x = 0;
                while( x < counter)
                {
                    file.WriteLine(r[x].id.ToString());
                    file.WriteLine(r[x].pilota);
                    file.WriteLine(r[x].team);
                    file.WriteLine(r[x].velocitaMax.ToString());
                    file.WriteLine(r[x].mescola);
                    file.WriteLine(r[x].tempoGiro.minuti.ToString());
                    file.WriteLine(r[x].tempoGiro.secondi.ToString());
                    file.WriteLine(r[x].tempoGiro.millisecondi.ToString());
                    x++;
                }
                file.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool RilevamentiStreamReader(string fileAddress, Rilevamento[] r, ref int counter)
        {
            try
            {
                StreamReader file = new StreamReader(fileAddress);
                counter = 0;
                while (counter < r.Length && !file.EndOfStream)
                {
                    Rilevamento tmp = default;
                    tmp.id = int.Parse(file.ReadLine());
                    tmp.pilota= file.ReadLine();
                    tmp.team = file.ReadLine();
                    tmp.velocitaMax = int.Parse(file.ReadLine());
                    tmp.mescola = file.ReadLine();
                    tmp.tempoGiro.minuti = int.Parse(file.ReadLine());
                    tmp.tempoGiro.secondi = int.Parse(file.ReadLine());
                    tmp.tempoGiro.millisecondi = int.Parse(file.ReadLine());

                    r[counter] = tmp;
                    counter++;
                }
                file.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int SommaTempiRicorsiva(int indice, Rilevamento[] r)
        {
            if (indice == 0)
                return r[0].tempoGiro.millisecondi + r[0].tempoGiro.secondi * 1000 + r[0].tempoGiro.minuti * 60 * 1000;
            return r[indice].tempoGiro.millisecondi + r[indice].tempoGiro.secondi * 1000 + r[indice].tempoGiro.minuti * 60 * 1000 + SommaTempiRicorsiva(indice - 1, r);
        }

        public static Tempo millisecondiToTempo(int millisecondi)
        {
            Tempo tempo = default;

            tempo.minuti = millisecondi / (60 * 1000);
            millisecondi = millisecondi % (60 * 1000);
            tempo.secondi = millisecondi / 1000;
            millisecondi = millisecondi % 1000;
            tempo.millisecondi = millisecondi;

            return tempo;
        }
    }
}
