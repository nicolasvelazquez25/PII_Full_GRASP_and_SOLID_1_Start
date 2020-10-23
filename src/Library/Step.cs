//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        /*

        Clase Step: aplica el patrón Expert

        Aplica el patrón Expert ya que la clase Step posee toda la información necesaria para hacer 
        el cálculo del precio de cada paso de la receta, 
        esto es porque la clase Step esta formada por el producto usado, 
        el cual brindará el costo por cada unidad, y
        por el equipamiento, que brindará el costo por cada hora de uso. 
        A esto se suman las variables de cantidad y tiempo que 
        se multiplicarán por los valores anteriormente mencionados respectivamente.

        De este modo es mas fácil que cada paso en sí calcule su precio para poder determinar 
        el precio final en base a la suma de los mismos
        sin operar toda la funcion en la clase Recipe dependiendo así completamente de ella. 

        */
        public double GetStepCost()
        {    
            return (this.Input.UnitCost * this.Quantity) + (this.Equipment.HourlyCost * this.Time);
        }
    }
}