﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Classe_e_Objeto
{
    //Classe
    public class Casa
    {
        public int TamanhoM2 { get; set; }

        public int Andares { get; set; }

        public decimal Valor { get; set; }

        public int NumeroVagas { get; set; }
    }

    public class Objeto
    {
        public Objeto()
        {
            //Objeto
            //Instancia a Classe criando o objeto(New Casa)
            Casa casa = new Casa
            {
                TamanhoM2 = 100,
                Andares = 2,
                Valor = 100000,
                NumeroVagas = 3
            };
        }
    }
}