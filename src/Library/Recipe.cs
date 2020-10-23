//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {

        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
        /*

        Clase Recipe: aplica el patrón Expert

        Aplica el patrón Expert ya que la clase Recipe esta compuesta por un objeto de la
        clase Step, por lo que puede acceder facilmente al cálculo de cada paso mediante la
        función GetStepCost(), por lo que la función GetProductionCost() solo se encargara de
        operar la sumatoria de los costos de cada paso. 

        De este modo es mas fácil que cada paso en sí calcule su precio para poder determinar 
        el precio final en base a la suma de los mismos sin operar toda la funcion en la clase Recipe dependiendo así completamente de ella. 

        */
        public double GetProductionCost()
        {
            double result = 0;
            foreach (Step step in this.steps)
            {
                result = result + step.GetStepCost();
            }
            return result;
        }
    }
}