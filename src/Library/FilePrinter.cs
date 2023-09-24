using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter : IPrinter
    {
       public void PrintRecipe(Recipe recipe)
       {
          File.WriteAllText("Recipe.txt",recipe.GetTextToPrint());  
       }
    }
}

/*    Lo que hice para poder cumplir con la consigan, fue realizar 3 clases distintas a las que a cada una le agregue un nombre distinto, CosolePrinter, FilePrinter y IPrinter
El principio empleado para realizar esto es el de SRP, el cual hace referencia a una responsabilidad unica
*/