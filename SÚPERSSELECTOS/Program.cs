using System.Collections;

class arraylistShow
{
    public static void Main(string[] args)
    {
        ArrayList productos = new ArrayList() { "Chile verde", "Pera", "Manzana", "Huevos", "Leche", "Cereal", "Carne", "Papel higienico", "Pollo", "Tomates", 
            "Cebolla", "Snacks", "Cerveza", "Soda", "Agua", "Shampoo", "Agua", "Sasonadores", "Mantequilla", "Limpiadores" };

        Console.WriteLine("Ingrese sus credenciales");
        string usuario = Console.ReadLine();


        if (usuario == "admin")
        {
            Console.WriteLine("Bienvenido administrador");
            Console.WriteLine("Menu admin");
            Console.WriteLine("1. Editar precio de producto");
            Console.WriteLine("2. Agregar descuentos");
            Console.WriteLine("3. Borrar productos ");
            Console.WriteLine("4. Buscar productos");
            int opcion;
            while (true)

            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out opcion) && (opcion >= 1 && opcion <= 4))
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingrese el nombre del producto que desea editar");
                            string edit = (Console.ReadLine());
                            if (productos.Contains(edit))
                            {
                                Console.WriteLine("Ingrese el nuevo precio");
                                string newpri = (Console.ReadLine());
                                Console.WriteLine($"El precio del" + edit + "se ha actualizado a" + newpri);
                            }
                            else
                            {
                                Console.WriteLine("Producto no existente");
                            }
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Ingrese el nombre del producto que al desea agregar un descuento");
                            string desc = (Console.ReadLine());
                            if (productos.Contains(desc))
                            {
                                Console.WriteLine("Ingrese el nuevo precio");
                                string newdesc = (Console.ReadLine());
                                Console.WriteLine($"El precio del" + desc + "se ha actualizado a" + newdesc);
                            }
                            else
                            {
                                Console.WriteLine("Producto no existente");
                            }
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Escriba el nombre del producto que desea eliminar");
                            string elimipro = (Console.ReadLine());
                            if (productos.Contains(elimipro))
                            {
                                productos.Remove(elimipro);
                                Console.WriteLine("El producto a eliminar es " + elimipro);
                            }
                            else
                            {
                                Console.WriteLine("Producto no existente");
                            }
                            break;
                        case 4:

                            Console.Clear();
                            string buscar;
                            Console.WriteLine("Ingrese el nombre del pais a buscar");
                            buscar = Console.ReadLine();

                            if (productos.Contains(buscar))
                            {
                                Console.WriteLine($"{buscar} sí está en la lista");
                            }
                            else
                                Console.WriteLine($"{buscar} no está en la lista");
                            break;

                    }
                break;
                Console.WriteLine("Por favor introduzca número dentro de los parametros del 1 al 4");
                {
                }
            }

        }
        if (usuario== cliente)
        {

        }
    }
}
    

        