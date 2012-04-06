﻿using Taimer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaimerGUI {
    static class Program {

        #region PARTE PRIVADA
        
        private static List<Actividad_a> asignaturas;
        private static List<User> usuarios;
        private static List<Algoritmo> algoritmos;
        private static int codAsignaturas = 0;

        private static void Init() { 
            //Aqui hay que rellenar todos los atributos privados de esta clase desde el cad
            //Esta función se llama en el main.

            asignaturas = new List<Actividad_a>();
            usuarios = new List<User>();
            algoritmos = new List<Algoritmo>();

            // =========== Datos de prueba, aquí tiene que haber un CAD que lo rellene. ============
            User usertest = new User("Aitor Tilla", "12345678X", "bill_gates@hotmail.com", "password", 1, "Ingeniería de Magisterio");

            usuarios.Add(usertest);

            Turno t1 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.M, "L04");
            Turno t2 = new Turno(new Hora(11, 30), new Hora(13, 30), dias.L, "L04");
            Turno t3 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.M, "L04");
            Turno t4 = new Turno(new Hora(10, 30), new Hora(12, 30), dias.X, "L04");
            Turno t5 = new Turno(new Hora(12, 30), new Hora(14, 30), dias.X, "L04");
            Turno t6 = new Turno(new Hora(14, 30), new Hora(16, 30), dias.L, "L04");
            Turno t7 = new Turno(new Hora(10, 30), new Hora(14, 30), dias.M, "L04");
            Turno t8 = new Turno(new Hora(11, 30), new Hora(14, 30), dias.V, "L04");
            Turno t9 = new Turno(new Hora(0, 30), new Hora(1, 30), dias.L, "L04");

            Actividad_p actP = new Actividad_p("P1", "descripcion", 6, usertest);
            actP.AddTurno(t1);

            Actividad_p actP2 = new Actividad_p("P2", "descripcion", 6, usertest);
            actP2.AddTurno(t4);
            actP2.AddTurno(t5);
            actP2.AddTurno(t6);

            Actividad_a actA = new Actividad_a("A1", "descripcion2", 7, "Un profesor");

            actA.AddTurno(t2);
            actA.AddTurno(t3);

            Actividad_a actA2 = new Actividad_a("A2", "descripcion2", 7, "Otro profesor");
            actA2.AddTurno(t7);
            //actA2.AddTurno(t8);
            actA2.AddTurno(t9);

            asignaturas.Add(actA);
            asignaturas.Add(actA2);

            Usuarios[0].ActPersonales.Add(actP);
            Usuarios[0].ActPersonales.Add(actP2);


        }

        #endregion

        #region PARTE PUBLICA

        //Obtiene/Modifica la lista de asignaturas
        public static List<Actividad_a> Asignaturas {
            set { asignaturas = value; }
            get { return asignaturas; }
        }

        //Obtiene/Modifica los usuarios
        public static List<User> Usuarios {
            set { usuarios = value; }
            get { return usuarios; }
        }

        //Obtiene/Modifica los algoritmos
        public static List<Algoritmo> Algoritmos {
            set { algoritmos = value; }
            get { return algoritmos; }
        }

        //Obtiene/Cambia el último codigo de la asignatura
        public static int CodAsignaturas {
            set { codAsignaturas = value; }
            get { return codAsignaturas; }
        }

        //Añade una asignatura
        public static void AddAsignatura(Actividad_a a) {
            codAsignaturas++;
            a.Codigo = codAsignaturas;
            asignaturas.Add(a);
        }

        //Borrar una asignatura
        public static bool BorrarAsignaturaBool(int codigo) {
            foreach(Actividad_a a in asignaturas){
                if (a.Codigo == codigo)
                    return asignaturas.Remove(a);
            }
            return false;
        }

        //Borrar una asignatura
        public static void BorrarAsignatura(int codigo)
        {
            bool borrado = false;
            foreach (Actividad_a a in asignaturas)
            {
                if (a.Codigo == codigo)
                    borrado = asignaturas.Remove(a);
            }
            if(!borrado)
                throw new MissingMemberException("La asignatura no existe");
        }

        //Añade un usuario
        public static void AddUsuario(User u) {
            usuarios.Add(u);
        }

        //Borrar un usuario
        public static bool BorrarUsuarioBool(string dni) {
            foreach (User u in usuarios) {
                if (u.DNI == dni)
                    return usuarios.Remove(u);
            }
            return false;
        }

        //Borrar un usuario
        public static void BorrarUsuario(string dni)
        {
            bool borrado = false;
            foreach (User u in usuarios)
            {
                if (u.DNI == dni)
                    borrado = usuarios.Remove(u);
            }
            if(!borrado)
                throw new MissingMemberException("El usuario no existe");
        }


        //Añade un algoritmo
        public static void AddAlgoritmo(Algoritmo a) {
            algoritmos.Add(a);
        }


        //Devuelve una actividad ya sea academica o personal a partir de código
        //CAMBIAR CUANDO SE INTEGREN LOS CADs SERÁ MÁS RÁPIDO
        public static Actividad getActividad(int codigo) {

            if (codigo > 0)
            {
                foreach (Actividad_a aa in asignaturas)
                {
                    if (aa.Codigo == codigo)
                        return aa;
                }
            }
            else
            {
                foreach (User u in Usuarios)
                {
                    List<Actividad_p> act = u.ActPersonales;
                    foreach (Actividad ap in act)
                    {
                        if (ap.Codigo == codigo)
                            return ap;
                    }
                }
            }

            throw new ArgumentException("No existe una actividad con ese código");
        }

        /// <summary>
        /// Modifica los datos de una actividad, asignándole los que tiene la actividad que se le pasa.
        /// </summary>
        /// <param name="act"></param>
        public static void ModificarActividad(Actividad act)
        {
            bool borrado = false;
            if (act.Codigo > 0) // Es académica
            {
                foreach (Actividad_a item in asignaturas)
                {
                    if (item.Codigo == act.Codigo)
                    {
                        item.CopiarDesde(act);
                        borrado = true;
                        break;
                    }
                }
                if (!borrado)
                    throw new ArgumentException("La Actividad especificada no existe");
            }
            else // Es personal
            {
                foreach (User item in usuarios)
                {
                    foreach (Actividad_p pers in item.ActPersonales)
                    {
                        if (pers.Codigo == act.Codigo)
                        {
                            pers.CopiarDesde(act);
                            borrado = true;
                            break;
                        }
                    }
                    if (borrado)
                        break;
                    
                }
                if (!borrado)
                    throw new ArgumentException("La Actividad especificada no existe");
            }
        }

        public static LoginForm loginForm;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {

            Init();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginForm = new LoginForm();
            Application.Run(loginForm);

        }
        #endregion
    }
}
