﻿//TODO: ajustar gets y sets

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Taimer
{
    public class Horario
    {

        #region PARTE PRIVADA
        private int id;                                     // Clave principal
        private string nombre;
        private List<Turno>[] arrayTurnos = new List<Turno>[7];     // Un horario tiene (0,N) turnos
        private User usuario;                             // Un horario es creado por (1,1) usuarios
        #endregion

        #region PARTE PÚBLICA

        // Constructor
        public Horario(int id_, string nom_, User usu_)
        {
            id = id_;
            nombre = nom_;
            usuario = usu_;

            for (int i = 0; i < 7; i++)
            {
                arrayTurnos[i] = new List<Turno>();
            }
        }

        public Horario(string nom_, User usu_)
        {
            id = 0;
            nombre = nom_;
            usuario = usu_;

            for (int i = 0; i < 7; i++)
            {
                arrayTurnos[i] = new List<Turno>();
            }
        }

        // Constructor de copia
        public Horario(Horario h)
        {
            id = h.id;
            nombre = h.nombre;
            usuario = h.usuario;

            for (int i = 0; i < 7; i++)
            {
                arrayTurnos[i] = new List<Turno>(h.ArrayTurnos[i]);
            }
        }

        // Ajustar/obtener nombre
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        // Ajustar/obtener id
        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        // Ajustar/obtener usuario
        public User Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public int Count
        {
            get
            {
                int cantidad = 0;

                for (int i = 0; i < 7; i++)
                {
                    cantidad += arrayTurnos[i].Count;
                }

                return cantidad;
            }
        }


        //Añadir turnos
        public void AddTurno(Turno turno)
        {
            switch (turno.Dia)
            {
                case dias.L:
                    CheckSolapamiento(turno, 0);
                    insertarOrdenado(turno, 0);
                    break;
                case dias.M:
                    CheckSolapamiento(turno, 1);
                    insertarOrdenado(turno, 1);
                    break;
                case dias.X:
                    CheckSolapamiento(turno, 2);
                    insertarOrdenado(turno, 2);
                    break;
                case dias.J:
                    CheckSolapamiento(turno, 3);
                    insertarOrdenado(turno, 3);
                    break;
                case dias.V:
                    CheckSolapamiento(turno, 4);
                    insertarOrdenado(turno, 4);
                    break;
                case dias.S:
                    CheckSolapamiento(turno, 5);
                    insertarOrdenado(turno, 5);
                    break;
                case dias.D:
                    CheckSolapamiento(turno, 6);
                    insertarOrdenado(turno, 6);
                    break;
            }
        }

        private void insertarOrdenado(Turno item, int dia)
        {
            int i = 0;
            bool insertado = false;

            for (i = 0; i < arrayTurnos[dia].Count; i++)
            {
                if (arrayTurnos[dia][i].HoraInicio > item.HoraInicio)
                {
                    arrayTurnos[dia].Insert(i, item);
                    insertado = true;
                    break;
                }
            }

            if (!insertado)
                arrayTurnos[dia].Add(item);

        }

        public void CheckSolapamiento(Turno turno, int dia)
        {
            foreach (Turno item in arrayTurnos[dia])
            {
                item.SuperponeExcepcion(turno);
            }
        }

        // Cambiar/Obtener turnos
        public List<Turno>[] ArrayTurnos
        {
            set { arrayTurnos = value; }
            get { return arrayTurnos; }
        }

        // Borrar turno (a partir de su código, si se encuentra)
        public bool BorraTurno(int codigobuscado)
        {

            for (int i = 0; i < 7; i++)
            {
                foreach (Turno t in arrayTurnos[i])
                {
                    if (t.Codigo == codigobuscado)
                        return arrayTurnos[i].Remove(t);
                }
            }
            return false;
        }

        // Dice cuál es la primera hora de un día de un horario
        public Hora minHora(int dia)
        {
            if(dia > 6 || dia < 0)
                throw new IndexOutOfRangeException();

            if(arrayTurnos[dia].Count == 0)
                throw new ArgumentNullException("El día está vacío");

            Hora minima = new Hora(23,59);

            foreach (Turno item in arrayTurnos[dia])
            {
                if (item.HoraInicio < minima)
                    minima = item.HoraInicio;
            }
            return minima;
        }

        // Dice cuál es la última hora de un día de un horario
        public Hora maxHora(int dia)
        {
            if (dia > 6 || dia < 0)
                throw new IndexOutOfRangeException();

            if (arrayTurnos[dia].Count == 0)
                throw new ArgumentNullException("El día está vacío");

            Hora maxima = new Hora(0, 0);

            foreach (Turno item in arrayTurnos[dia])
            {
                if (item.HoraFin > maxima)
                    maxima = item.HoraFin;
            }
            return maxima;
        }

        #endregion
    }
}
