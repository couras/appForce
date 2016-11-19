using appForce.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using
using System.ComponentModel.DataAnnotations.Schema;

namespace appForce.Model
{
    class Cliente : Persistencia
    {
        private int _id;
        private string _nome;
        private string _sobrenome;
        private int _idade;

        [Column("id")]
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        [Column("nome")]
        public string Nome
        {
            get
            {
                return _nome;
            }

            set
            {
                _nome = value;
            }
        }

        [Column("sobrenome")]
        public string Sobrenome
        {
            get
            {
                return _sobrenome;
            }

            set
            {
                _sobrenome = value;
            }
        }

        [Column("idade")]
        public int Idade
        {
            get
            {
                return _idade;
            }

            set
            {
                _idade = value;
            }
        }
    }
}
