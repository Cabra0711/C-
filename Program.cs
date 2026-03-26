using Models.Users;

string? names = "";
int option;
List<Users> users = new List<Users>();
int idCounter = 1;

while (true)
{
            Console.Write(@"
            ===================BIENVENIDO A RegistrarUsuarios ======================
            1. Registrar Usuario
            2. Listar Usuario
            3. Ingreso Plataforma
            4. Salir
            INGRESE UN NUMERO PARA CONTINUAR 1/4: ");
        if (!int.TryParse(Console.ReadLine(), out option))
        {
            Console.Write("Ingrese un numero del valido");
        };

        if (option == 1)
        {

            // user data requierement
            Console.Write("Ingrese el nombre del usuario: ");
            names = Console.ReadLine() ?? "";

            Console.Write("Ingrese la edad del usuario: ");
            int currentAge;
            int.TryParse(Console.ReadLine(), out currentAge);

            string city = ""; 
            Console.Write("Ingrese la ciudad del usuario: ");
            city = Console.ReadLine() ?? "";
            users.Add(new Users(
                idCounter++,
                names,
                currentAge,
                city
            ));
            Console.Write("El usuario fue registrado correctamente ");

        }else if (option == 2)
        {
            foreach (Users user in users)
            {
                Console.WriteLine($@"Tus Usuarios listados son:
============================================================
ID: {user.Id} NAME: {user.Name} AGE: {user.Age} CITY: {user.City} 
=======================================================
");
            };
        }else if (option == 3)
            //Johan Activity FLow
        {
            Console.Write("Ingrese el nombre del usuario: ");
            names = Console.ReadLine() ?? "";

            Console.Write("Ingrese la edad del usuario: ");
            int currentAge;
            int.TryParse(Console.ReadLine(), out currentAge);

            string city = ""; 
            Console.Write("Ingrese la ciudad del usuario: ");
            city = Console.ReadLine() ?? "";
            users.Add(new Users(
                idCounter++,
                names,
                currentAge,
                city
            ));

            if (currentAge <= 17)
            {
                Console.Write("Acceso Denegado Eres MENOR DE EDAD");
            }else
            {
                foreach (Users user in users)
                {
                    Console.WriteLine($@"Hola {user.Name} Desde {user.City}
PERTENECES A LA CATEGORIA: {user.Age} ADULTO
Acceso Permitido");
                }
            }
        }
        

};
