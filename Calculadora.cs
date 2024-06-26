﻿namespace EspacioCalculadora
{
    public class Calculadora{
        private double dato;
        private double resultado;

        public double Dato { get => dato; set => dato = value; }
        public double Resultado { get => resultado;}

        public void Sumar(double num){
            Dato += num;
            resultado = Dato;
        }
        public void Restar(double num){
            Dato -= num;
            resultado = Dato;
        }
        public void Dividir(double num){
            Dato /= num;
            resultado = Dato;
        }
        public void Multiplicar(double num){
            Dato *= num;
            resultado = Dato;
        }

        public void Limpiar(){
            Dato = 0;
            resultado = Dato;
        }

    }
}