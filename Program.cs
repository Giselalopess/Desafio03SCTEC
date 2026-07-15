// Cria um sistema que peça para usuário e senha.
// O usuário tem 3 tentativas
// Se errar 3 vezes, o sistema bloqueia o acesso.
// Se acertar, exibe "Login realizado com sucesso".

string usuarioRoot = "admin";
string senhaRoot = "admin123";

string usuarioDigitado;
string senhaDigitada;
int contasFalhas = 0;

do
{
    Console.WriteLine("Digite seu usuario: ");
    usuarioDigitado = Console.ReadLine();


    Console.WriteLine("Digite sua senha: ");
    senhaDigitada = Console.ReadLine();



    if (usuarioRoot == usuarioDigitado && senhaRoot == senhaDigitada)
    {
        Console.WriteLine("Login realizado com sucesso");
    }
    else
    {
        contasFalhas++;
        Console.WriteLine("Usuario errado");
    }

} while (usuarioDigitado != usuarioDigitado ||
     senhaRoot != senhaDigitada && contasFalhas < 3);

if (usuarioRoot != usuarioDigitado && senhaRoot != senhaDigitada);
{
    Console.WriteLine("Usuario bloqueado!!");
}


